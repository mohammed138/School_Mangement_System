using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.ViewModels;
using School.DataAccess;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("Manger")]
    [Authorize(Roles = "MangerRole")]
    public class SubjectsController : Controller
    {

        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public SubjectsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

        }

        // GET: Manger/Subjects
        public async Task<IActionResult> GetAll()
        {
            var model = new SubjectViewModel();
            model.SubjectList = _context.Subject.Where(d=>d.IsDelete != true).Include(s => s.Class).Include(s => s.Teacher).ToList();
            return View(model);
        }

         public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .Include(s => s.Class)
                .Include(s => s.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

         public IActionResult Create()
         {
            SubjectViewModel model = new SubjectViewModel()
            {
                ClassDrop = _context.Classes.Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                }),
                TeacherDrop = _context.Teacher.Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.FullName
                }),

            };
  
            return View(model);
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Subject.CreatedAt = DateTime.Now;
                model.Subject.CreatedBy = UserEmail;
                model.Subject.IsDelete = false;


                _context.Add(model.Subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetAll));
            }
             return View(model);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = new SubjectViewModel();
            model.Subject = await _context.Subject.FindAsync(id);

            model.ClassDrop = _context.Classes.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            model.TeacherDrop = _context.Teacher.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.FullName
            });

            if (model.Subject == null)
            {
                return NotFound();
            }
            return View(model);
 
        }

           [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SubjectViewModel model)
        {
            if (id != model.Subject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Subject.UpdatedAt = DateTime.Now;
                    model.Subject.UpdatedBy = UserEmail; 

                    _context.Update(model.Subject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectExists(model.Subject.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(GetAll));
            }
             return View(model);
        }

         public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .Include(s => s.Class)
                .Include(s => s.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

         [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subject = await _context.Subject.FindAsync(id);
            subject.IsDelete = true;
            _context.Subject.Update(subject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetAll));
        }





        [HttpPost]
        public IActionResult ExporDataToFile()
        {
            var dictioneryexportType = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
            var exportType = dictioneryexportType["Export"];
            var model = GetDataDetail();
            switch (exportType)
            {


                case "Pdf":
                    ExportToPdf(model);
                    break;


            }
            return null;
        } 
        private void ExportToPdf(DataTable model)
        {

            if (model.Rows.Count > 0)
            {
                string fontLoc = @"C:\Users\hp\Desktop\arial-unicode-ms\ARIALUNI.ttf"; // make sure to have the correct path to the font file

                int pdfRowIndex = 1;
                string filename = "عرض المواد الدراسية  " + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
                string filepath = MyServer.MapPath("\\") + "" + filename + ".pdf";
                Document document = new Document(PageSize.A4, 5f, 5f, 10f, 10f);
                FileStream fs = new FileStream(filepath, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                Font font1 = FontFactory.GetFont(FontFactory.COURIER_BOLD, 13);
                Font font2 = FontFactory.GetFont(FontFactory.COURIER, 8);
                BaseFont bf = BaseFont.CreateFont(fontLoc, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font f = new Font(bf, 8);

                Font fHeader = new Font(bf, 11);


                float[] columnDefinitionSize = { 5f, 5f, 5f };
                PdfPTable table;
                PdfPCell cell;

                table = new PdfPTable(3)
                {
                    WidthPercentage = 100
                };

               
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                table.AddCell(new Phrase("اسم المادة    ", fHeader));
                table.AddCell(new Phrase("للصف  ", fHeader));
                table.AddCell(new Phrase("مدرس المادة    ", fHeader));

      


                foreach (DataRow data in model.Rows)
                {
                    table.AddCell(new Phrase(data["Name"].ToString(), f));
                    table.AddCell(new Phrase(data["Class"].ToString(), f));
                    table.AddCell(new Phrase(data["Teacher"].ToString(), f));
               

 
                    pdfRowIndex++;
                }
                document.Add(table);
                document.Close();
                document.CloseDocument();
                document.Dispose();
                writer.Close();
                writer.Dispose();
                fs.Close();
                fs.Dispose();
                FileStream sourceFile = new FileStream(filepath, FileMode.Open);
                float fileSize = 0;
                fileSize = sourceFile.Length;
                byte[] getContent = new byte[Convert.ToInt32(Math.Truncate(fileSize))];
                sourceFile.Read(getContent, 0, Convert.ToInt32(sourceFile.Length));
                sourceFile.Close();
                Response.Clear();
                Response.Headers.Clear();
                Response.ContentType = "application/pdf";
                Response.Headers.Add("Content-Length", getContent.Length.ToString());
                Response.Headers.Add("Content-Disposition", "attachment; filename=" + filename + ".pdf;");
                Response.Body.WriteAsync(getContent);
                Response.Body.Flush();
            }
        }
        private DataTable GetDataDetail()
        {
            var ModelList = _context.Subject
            .Include(w => w.Class)
             .Include(w => w.Teacher) 
            .ToList();

            DataTable dtProduct = new DataTable(" عرض التقييمات الدراسية  ");
            dtProduct.Columns.AddRange(new DataColumn[] {
                 new DataColumn("Name"),
                new DataColumn("Class"),
                new DataColumn("Teacher") 


            });
            foreach (var model in ModelList)
            {
                dtProduct.Rows.Add(model.Name, model.Class.Name, model.Teacher.FullName 
                                   );
            }

            return dtProduct;
        }



        private bool SubjectExists(int id)
        {
            return _context.Subject.Any(e => e.Id == id);
        }
    }
}

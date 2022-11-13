using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.ViewModels;
using School.DataAccess;

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("Manger")]
    [Authorize(Roles = "MangerRole")]
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public StudentsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

        }

        public async Task<IActionResult> GetAll()
        {
            var model = new StudentViewModel();
            model.StudentList = _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender).Include(s => s.Semester).Where(d => d.IsDelete != true).ToList();


            if (model.StudentList.Count()>0 )
            {
                model.IsActive = true;

            }
            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Semester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult Create()
        {
            var model = new StudentViewModel()
            {
                ClassDrop = _context.Classes.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name } ),
                GenderDrop = _context.Gender.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name } ),
                SemesterDrop = _context.Semester.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name })

            };
            return View(model);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel  model)
        {
            if (ModelState.IsValid)
            {
                model.Student.CreatedAt = DateTime.Now;
                model.Student.CreatedBy = UserEmail;
                model.Student.IsDelete = false;
                _context.Add(model.Student);
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
            var model = new StudentViewModel()
            {
                ClassDrop = _context.Classes.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                GenderDrop = _context.Gender.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                SemesterDrop = _context.Semester.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                Student = await _context.Student.FindAsync(id)
            };
            
            
            if (model.Student == null)
            {
                return NotFound();
            }
             return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentViewModel model)
        {
            if (id !=  model.Student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Student.UpdatedAt = DateTime.Now;
                    model.Student.UpdatedBy = UserEmail;


                    _context.Update(model.Student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(model.Student.Id))
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

            var student = await _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Semester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Manger/Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            student.IsDelete = true;
            _context.Student.Update(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
                string fontLoc = @"./ARIALUNI.ttf"; // make sure to have the correct path to the font file

                int pdfRowIndex = 1;
                string filename = "عرض طلاب المدرسة  " + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
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


                float[] columnDefinitionSize = { 2f, 2f, 2f, 2f, 2f, 2f };
                PdfPTable table;
                PdfPCell cell;

                table = new PdfPTable(6)
                {
                    WidthPercentage = 100
                };

                cell = new PdfPCell
                {
                    BackgroundColor = new BaseColor(0xC0, 0xC0, 0xC0)
                };
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                table.AddCell(new Phrase("اسم الطالب   ", fHeader));
                table.AddCell(new Phrase("رقم الهاتف  ", fHeader));
                table.AddCell(new Phrase("البريد الإلكتروني  ", fHeader));

                table.AddCell(new Phrase(" تاريخ الميلاد    ", fHeader));
                table.AddCell(new Phrase("الصف   ", fHeader));
                table.AddCell(new Phrase("الفصل  ", fHeader));


                foreach (DataRow data in model.Rows)
                {
                    table.AddCell(new Phrase(data["FullName"].ToString(), f));
                    table.AddCell(new Phrase(data["PhoneNumber"].ToString(), f));
                    table.AddCell(new Phrase(data["EmailAddress"].ToString(), f));

                    table.AddCell(new Phrase(data["DOP"].ToString(), f));
                     table.AddCell(new Phrase(data["Class"].ToString(), f));
                    table.AddCell(new Phrase(data["Semester"].ToString(), f));

                     
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
            var ModelList = _context.Student
            .Include(w => w.Class)
             .Include(w => w.Semester)
             .Include(w => w.Gender)
            .ToList();
             
            DataTable dtProduct = new DataTable(" عرض التقييمات الدراسية  ");
            dtProduct.Columns.AddRange(new DataColumn[] {
                 new DataColumn("FullName"),
                new DataColumn("PhoneNumber"),
                new DataColumn("EmailAddress"),
                new DataColumn("DOP"),
                new DataColumn("AddressName"),
                new DataColumn("Class"),
                new DataColumn("Semester")
             

            });
            foreach (var model in ModelList)
            {
                dtProduct.Rows.Add(model.FullName , model.PhoneNumber, model.EmailAddress,
                                   model.DOP, model.AddressName, model.Class.Name, model.Semester.Name
                                   );
            }

            return dtProduct;
        }














        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}

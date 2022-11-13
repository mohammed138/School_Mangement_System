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
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public TeachersController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

        }
        public async Task<IActionResult> GetAll()
        {

            var model = new TeachersViewModel();
            model.TeacherList = _context.Teacher.Where(d=>d.IsDelete != true).ToList();
            return View(model);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        public IActionResult Create()
        {
            var model = new TeachersViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeachersViewModel model)
        {
            if (ModelState.IsValid)
            {
           
                model.Teacher.CreatedAt = DateTime.Now;
                model.Teacher.CreatedBy = UserEmail;
                model.Teacher.IsDelete = false;


                _context.Add(model.Teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetAll));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var model = new TeachersViewModel();
            if (id == null)
            {
                return NotFound();
            }

            model.Teacher = await _context.Teacher.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TeachersViewModel model)
        {
            if (id != model.Teacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Teacher.UpdatedAt = DateTime.Now;
                    model.Teacher.UpdatedBy = UserEmail;
                    _context.Update(model.Teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(model.Teacher.Id))
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

            var teacher = await _context.Teacher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);
            teacher.IsDelete = true;
            _context.Teacher.Update(teacher);
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
                string fontLoc = @"./ARIALUNI.ttf"; // make sure to have the correct path to the font file

                int pdfRowIndex = 1;
                string filename = "عرض معلمين المدرسة    " + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
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

                table.AddCell(new Phrase(" الاسم الأول ", fHeader));
                table.AddCell(new Phrase("اسم العائلة  ", fHeader));
                table.AddCell(new Phrase("رقم الهاتف     ", fHeader));


                table.AddCell(new Phrase("الإيميل     ", fHeader));
                table.AddCell(new Phrase("تخصص المعلم      ", fHeader));
  
                foreach (DataRow data in model.Rows)
                {
                    table.AddCell(new Phrase(data["FirstName"].ToString(), f));
                    table.AddCell(new Phrase(data["LastName"].ToString(), f));
                    table.AddCell(new Phrase(data["PhoneNumber"].ToString(), f));
                    table.AddCell(new Phrase(data["EmailAddress"].ToString(), f));
                    table.AddCell(new Phrase(data["AppointmentYear"].ToString(), f));
                    table.AddCell(new Phrase(data["Specialization"].ToString(), f));














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
            var ModelList = _context.Teacher 
            .ToList();

            DataTable dtProduct = new DataTable(" عرض معلمين المدرسة   ");
            dtProduct.Columns.AddRange(new DataColumn[] {
                 new DataColumn("FirstName"),
                new DataColumn("LastName"),
                new DataColumn("PhoneNumber"),
                new DataColumn("EmailAddress"),
                new DataColumn("Specialization")  
            });
            foreach (var model in ModelList)
            {
                dtProduct.Rows.Add(model.FirstName, model.LastName, model.PhoneNumber,
                                   model.EmailAddress,  model.Specialization );
            }

            return dtProduct;
        }








        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}

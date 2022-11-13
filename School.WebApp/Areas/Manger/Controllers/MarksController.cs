using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
     public class MarksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Mark.Include(m => m.Class).Include(m => m.Student).Include(m => m.Subject).Include(m => m.Teacher);
            return View(await applicationDbContext.ToListAsync());
        }
         
        public IActionResult Find(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MarkViewModel model = new MarkViewModel()
            {
                   MarkList = _context.Mark.Include(d => d.Class)
                   .Include(d => d.Student).Include(d => d.Teacher)
                    .Include(d => d.Subject).Where(d => d.StudentId == id).ToList(),
                   Student = _context.Student.Where(d => d.Id == id).FirstOrDefault()                   

            };

            if (model.MarkList.Count() > 0)
            {
                model.IsActive = true;
            }

            return View(model);
        }


        [HttpPost]
        public IActionResult ExporDataToFile()
        {
            var dictioneryexportType = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
            var exportType = dictioneryexportType["Export"];
            var Class = GetDataDetail();
            switch (exportType)
            {


                case "Pdf":
                    ExportToPdf(Class);
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
                string filename = "عرض درجات الطلاب" + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
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


                float[] columnDefinitionSize = { 2f, 2f, 2f, 2f, 2f, 2f, 2f, 2f };
                PdfPTable table;
                PdfPCell cell;

                table = new PdfPTable(8)
                {
                    WidthPercentage = 100
                };

                cell = new PdfPCell
                {
                    BackgroundColor = new BaseColor(0xC0, 0xC0, 0xC0)
                };
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                table.AddCell(new Phrase("اسم الطالب ", fHeader));
                table.AddCell(new Phrase("المادة   ", fHeader));
                table.AddCell(new Phrase("الصف ", fHeader));
                table.AddCell(new Phrase("المعلم ", fHeader));

                table.AddCell(new Phrase("الإختبارات القصيرة  ", fHeader));
                table.AddCell(new Phrase("درجات التقويم النوعي ", fHeader));
                table.AddCell(new Phrase("النهائي ", fHeader));
                table.AddCell(new Phrase("المجموع ", fHeader));
             

                foreach (DataRow data in model.Rows)
                {
                    table.AddCell(new Phrase(data["Student"].ToString(), f));
                    table.AddCell(new Phrase(data["Subject"].ToString(), f));
                    table.AddCell(new Phrase(data["Class"].ToString(), f));
                    table.AddCell(new Phrase(data["Teacher"].ToString(), f));
                    table.AddCell(new Phrase(data["ShortQuizzes"].ToString(), f));
                    table.AddCell(new Phrase(data["QualitativeAssessmentGrades"].ToString(), f));
                    table.AddCell(new Phrase(data["FinalTermValue"].ToString(), f));
                    table.AddCell(new Phrase(data["Total"].ToString(), f));
                  

                    pdfRowIndex++;
                }
                //Response.ContentEncoding = System.Text.Encoding.UTF8;


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
            var Marks = _context.Mark.Include(d => d.Class)
                   .Include(d => d.Student).Include(d => d.Teacher)
                    .Include(d => d.Subject).ToList();

            DataTable dtProduct = new DataTable("عرض صفوف المدرسة ");
            dtProduct.Columns.AddRange(new DataColumn[] {
                new DataColumn("Id"),
                new DataColumn("ShortQuizzes"),
                new DataColumn("QualitativeAssessmentGrades"),
                new DataColumn("FinalTermValue"),
                new DataColumn("Total"),
                new DataColumn("Student"),
                new DataColumn("Subject"),
                new DataColumn("Class"),
                new DataColumn("Teacher") 

            });
            foreach (var model in Marks)
            {
                dtProduct.Rows.Add(model.Id , model.ShortQuizzes, model.QualitativeAssessmentGrades, model.FinalTermValue,
                                 /*  model.Total,*/ model.Student.FullName, model.Subject.Name, model.Class.Name,
                                   model.Teacher.FullName);
            }

            return dtProduct;
        }


    }
}

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
    public class SkillsBehaviorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;

        public SkillsBehaviorsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

        }



        public async Task<IActionResult> GetStudentSkillsBehaviors(int? id)
        {
            var model = new SkillsBehaviorViewModel();
            if (id == null)
            {
                return NotFound();
            }
            model.Decisions = _context.Decisions.FirstOrDefault();
            model.SkillsBehaviorList = _context.SkillsBehavior
            .Include(w => w.Class)
            .Include(w => w.Student)
            .Include(w => w.Subject)
            .Include(w => w.Teacher)
            .Where(m => m.StudentId == id)
            .ToList();
            if (model.SkillsBehaviorList.Any() == true)
            {
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }

            return View(model);
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
                string filename = "عرض التقييمات السلوكية " + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
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


                float[] columnDefinitionSize = { 2f, 2f, 2f, 2f, 2f, 2f, 2f};
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

                table.AddCell(new Phrase("اسم البند ", fHeader));
                table.AddCell(new Phrase("اسم الطالب   ", fHeader));
                table.AddCell(new Phrase("الصف  ", fHeader));
                table.AddCell(new Phrase("المادة  ", fHeader));

                table.AddCell(new Phrase(" اسم المعلم  ", fHeader));
                table.AddCell(new Phrase("الشهر  ", fHeader));
                table.AddCell(new Phrase("التقييم ", fHeader)); 


                foreach (DataRow data in model.Rows)
                {
                     table.AddCell(new Phrase(data["Name"].ToString(), f));
                    table.AddCell(new Phrase(data["Student"].ToString(), f));
                    table.AddCell(new Phrase(data["Class"].ToString(), f));
                    table.AddCell(new Phrase(data["Subject"].ToString(), f));
                    table.AddCell(new Phrase(data["Teacher"].ToString(), f));
                    table.AddCell(new Phrase(data["Duration"].ToString(), f));
                    table.AddCell(new Phrase(data["CompletionType"].ToString(), f));
 

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
            var ModelList = _context.SkillsBehavior
            .Include(w => w.Subject)
            .Include(w => w.Class)
            .Include(w => w.Teacher)
            .Include(w => w.Duration) 
            .Include(w => w.CompletionType)
            .Include(w => w.Student)
            
            .ToList();
             


            DataTable dtProduct = new DataTable("عرض صفوف المدرسة ");
            dtProduct.Columns.AddRange(new DataColumn[] {
                 new DataColumn("Name"),
                new DataColumn("Student"),
                new DataColumn("Class"),
                new DataColumn("Subject"),
                new DataColumn("Teacher"),
                new DataColumn("Duration"),
                new DataColumn("CompletionType") 

            });
            foreach (var model in ModelList)
            {
                dtProduct.Rows.Add(model.Name, model.Student.FullName, model.Class.Name,
                                   model.Subject.Name, model.Teacher.FullName, model.Duration.Name, model.CompletionType.Name
                                   );
            }

            return dtProduct;
        }




        private bool SkillsBehaviorExists(int id)
        {
            return _context.SkillsBehavior.Any(e => e.Id == id);
        }
    }
}

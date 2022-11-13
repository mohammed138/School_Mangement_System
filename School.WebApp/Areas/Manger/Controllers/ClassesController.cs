using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.DataAccess;
using School.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("Manger")]
    [Authorize(Roles = "MangerRole")]
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult ExporDataToFile()
        {
            var dictioneryexportType = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
            var exportType = dictioneryexportType["Export"];
            var Class = GetClassDetail();
            switch (exportType)
            {


                case "Pdf":
                    ExportToPdf(Class);
                    break;


            }
            return null;
        }
         
        private void ExportToPdf(DataTable @class)
        {

            if (@class.Rows.Count > 0)
            {
                string fontLoc = @"./ARIALUNI.ttf"; // make sure to have the correct path to the font file
                //string fontLoc = Static.FontFamily; // make sure to have the correct path to the font file

                int pdfRowIndex = 1;
                string filename = "الفصول الدراسية -" + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
                string filepath = MyServer.MapPath("\\") + "" + filename + ".pdf";
                Document document = new Document(PageSize.A4, 5f, 5f, 10f, 10f);
                FileStream fs = new FileStream(filepath, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                Font font1 = FontFactory.GetFont(FontFactory.COURIER_BOLD, 13);
                Font font2 = FontFactory.GetFont(FontFactory.COURIER, 8);
                BaseFont bf = BaseFont.CreateFont(fontLoc, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font f = new Font(bf, 8);



                float[] columnDefinitionSize = { 5F};
                PdfPTable table;
                PdfPCell cell;

                table = new PdfPTable(columnDefinitionSize)
                {
                    WidthPercentage = 100
                };

                cell = new PdfPCell
                {
                    BackgroundColor = new BaseColor(0xC0, 0xC0, 0xC0)
                };
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                 table.AddCell(new Phrase("اسم الصف", font1));

                foreach (DataRow data in @class.Rows)
                {
                     table.AddCell(new Phrase(data["Name"].ToString(), f));

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
        private DataTable GetClassDetail()
        {
            var Class = _context.Classes.ToList();

            DataTable dtProduct = new DataTable("عرض صفوف المدرسة ");
            dtProduct.Columns.AddRange(new DataColumn[] {
                new DataColumn("Name")
            });
            foreach (var @Classes in Class)
            {
                dtProduct.Rows.Add(@Classes.Name);
            }

            return dtProduct;
        }
        public async Task<IActionResult> Index()
        {
            var model = new ClassViewModel()
            {
                ClassList = _context.Classes.ToList(),
                TeacherList = _context.Teacher.ToList(),
                Class = new Class(),
                Teacher = new School.Data.Entities.Teacher(),

            };

            return View(model);
        }
        public IActionResult GetTeachers(int? id)
        {
            List<int> TeacherIDs = new List<int>();
            List<Teacher> TeacherList = new List<Teacher>();


            if (id == null)
            {
                return NotFound();
            }

            ClassViewModel model = new ClassViewModel()
            {
                Class = _context.Classes.Where(d => d.Id == id).FirstOrDefault(),

            };
            TeacherIDs = _context.Subject.Where(d => d.ClassId == id).Select(h => h.TeacherId).ToList();

            foreach (var item in TeacherIDs)
            {
                TeacherList.Add(_context.Teacher.Where(d => d.Id == item).FirstOrDefault());
            }


            model.TeacherList = TeacherList;
            model.Capacity = model.TeacherList.Count();



            if (TeacherIDs.Count() > 0)
            {
                model.IsActive = true;
            }


            if (model.Class == null)
            {
                return NotFound();
            }

            return View(model);
        }
        public IActionResult GetStudents(int? id)
        {
            List<int> StudentIDs = new List<int>();
            List<Student> StudentList = new List<Student>();


            if (id == null)
            {
                return NotFound();
            }

            ClassViewModel model = new ClassViewModel()
            {
                Class = _context.Classes.Where(d => d.Id == id).FirstOrDefault(),
                //StudentList = _context.Student.Where(d => d.ClassId == id).ToList(),

            };
            StudentIDs = _context.Student.Where(d => d.ClassId == id).Select(h => h.Id).ToList();

            foreach (var item in StudentIDs)
            {
                StudentList.Add(_context.Student.Where(d => d.Id == item).FirstOrDefault());
            }
            model.StudentList = StudentList;
            model.Capacity = model.StudentList.Count();

            if (model.Class == null)
            {
                return NotFound();
            }

            return View(model);
        }
        public IActionResult GetSubjects(int? id)
        {
            List<int> SubjectIDs = new List<int>();
            List<Subject> SubjectList = new List<Subject>();


            if (id == null)
            {
                return NotFound();
            }

            ClassViewModel model = new ClassViewModel()
            {
                Class = _context.Classes.Where(d => d.Id == id).FirstOrDefault(),

            };
            SubjectIDs = _context.Subject.Where(d => d.ClassId == id).Select(h => h.Id).ToList();

            foreach (var item in SubjectIDs)
            {
                SubjectList.Add(_context.Subject.Where(d => d.Id == item).Include(c => c.Teacher).Include(d => d.Class).FirstOrDefault());
            }
            model.SubjectList = SubjectList;
            model.Capacity = model.SubjectList.Count();

            if (model.Class == null)
            {
                return NotFound();
            }

            return View(model);
        }

     



    }
}

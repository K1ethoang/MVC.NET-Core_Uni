using Lab_02.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Bai_1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        [Route("123")]
        //Action trả về một View là một trang html và nó có thể truyền tham số hóa model
        public ViewResult TestViewResult()
        {
            return View();
        }

        //Action trả về một PartialViewResult
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        //Action trả về một View trống (null)
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        // Action đáp ứng việc chuyển trực tiếp tới một view khác
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");
        }
        //Action trả về một kết quả dạng Json
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>
            {
                new Student()
                {
                    ID = 001,
                    Name = "Nguyễn Quang Huy",
                    ClassName = "C1311L"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Nguyễn Quang Huy",
                    ClassName = "C1311J"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Nguyễn Quang Hiển",
                    ClassName = "C1311H"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Nguyễn Duy Huân",
                    ClassName = "C1311T"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Vũ Quang Huy",
                    ClassName = "C1311C"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Trần Quang Huy",
                    ClassName = "C1311L"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Phạm Quang Huy",
                    ClassName = "C1311L"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Trịnh Quang Huy",
                    ClassName = "C1311B"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Vũ Quang Huy",
                    ClassName = "C1311L"
                },
                new Student()
                {
                    ID = 001,
                    Name = "Vũ Minh Trịnh",
                    ClassName = "C1311M"
                }
            };
            return Json(listStudent);
        }

        //Acion tra về một ContentResult dữ liệu là dạng văn bản
        public ContentResult TestContentResult()
        {
            XElement contentXML = new XElement("Students",
            new XElement("Student",
            new XElement("ID", "001"),
            new XElement("FullName", "Nguyễn Viết Nam"),
            new XElement("ClassName", "C1308H")),
            new XElement("Student",
            new XElement("ID", "002"),
            new XElement("FullName", "Nguyễn Hoàng Anh"),
            new XElement("ClassName", "C1411P")),
            new XElement("Student",
            new XElement("ID", "003"),
            new XElement("FullName", "Phạm Ngọc Anh"),
            new XElement("ClassName", "C1411L")),
            new XElement("Student",
            new XElement("ID", "004"),
            new XElement("FullName", "Trần Ngọc Linh"),
            new XElement("ClassName", "C1411H")),
            new XElement("Student",
            new XElement("ID", "005"),
            new XElement("FullName", "Nguyễn Hồng Anh"),
            new XElement("ClassName", "C1411L")));
            return Content(contentXML.ToString(), "text/xml", Encoding.UTF8);
        }
        // Cả ba kiểu FileContentResult,FileStreamResult,FilePathResult đều cho phép trình duyệt mở hộp thoại lưu file và tải file về
        // phương thức trả về có 3 tham số
        // tham số thứ nhất đối với kiểu FileContentResult là một mảng byte của file
        // tham số thứ nhất đối với kiểu FileStreamResult là một FileStream
        // tham sô thứ nhất đổi với kiểu PathFileResult là một đường dẫn file
        // tham số thứ hai chỉ ra loại định dạng của file
        // tham số thứ ba tên file mà trình duyệt sẽ tải về
        public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Contents/videodemo.mp4"));
            string fileName = "videodemo.mp4";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(fileBytes, "video/mp4", fileName);
        }

        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/khung.docx");
            string fileName = "khung.docx";
            return File(new FileStream(pathFile, FileMode.Open), "text/doc", fileName);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/khung.docx");
            string fileName = "khung.docx";
            return File(pathFile, "text/doc", fileName);
        }
    }
}
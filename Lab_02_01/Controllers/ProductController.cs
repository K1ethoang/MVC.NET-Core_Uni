using Lab_02.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace Lab_02.Controllers
{
    [Route("first")]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
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
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311J"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Hiển",
                ClassName = "C1311H"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Duy Huân",
                ClassName = "C1311T"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Vũ Quang Huy",
                ClassName = "C1311C"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Trần Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Phạm Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Trịnh Quang Huy",
                ClassName = "C1311B"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Vũ Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Vũ Minh Trịnh",
                ClassName = "C1311M"
            });
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
            // ko con dung duoc
            //byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Contents/videodemo.mp4"));

            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentsPath = Path.Combine(webRootPath, "contents");
            string filePath = Path.Combine(contentsPath, "videodemo.mp4");
            string fileName = "videodemo.mp4";

            byte[] bytes = System.IO.File.ReadAllBytes(filePath);

            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(bytes, "video/mp4", fileName);
        }

        public FileStreamResult TestFileStreamResult()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentsPath = Path.Combine(webRootPath, "contents");
            string filePath = Path.Combine(contentsPath, "khung.xlsx");
            string fileName = "khung.xlsx";

            byte[] bytes = System.IO.File.ReadAllBytes(filePath);

            return File(new FileStream(filePath, FileMode.Open), "application/vnd.ms-excel", fileName);
        }
    }
}

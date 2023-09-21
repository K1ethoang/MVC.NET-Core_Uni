using Microsoft.AspNetCore.Mvc;

namespace Lab_02_02.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ShowProduct()
        {
            return View();
        }
        // GET: Action sửa sản phẩm
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        //GET: Action chi tiết sản phẩm
        public ActionResult DetailsProduct(string productName, int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }

    }
}

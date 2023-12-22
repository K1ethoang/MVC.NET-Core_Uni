using Lab4_Bai2.Models;
using Lab4_Bai2.Repositories;
using System.Web.Mvc;

namespace Lab4_Bai2.Controllers
{
    public class CustomerController : Controller
    {
        //khai báo biến CustomerRepository
        static CustomerRepository listCustomer;

        public CustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new CustomerRepository();
        }

        public ActionResult GetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }

        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }

        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }

        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }

        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult Edit(Customer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }

        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
}

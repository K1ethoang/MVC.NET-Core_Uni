using Lab4_Bai1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerDetail()
        {
            Customer customer = new Customer()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
            };
            return View(customer);
        }

        public ActionResult CustomerList()
        {
            List<Customer> listCustomer = new List<Customer>()
            {
                new Customer()
                {
                  CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
                },
                new Customer()
                {
                     CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
                },
                new Customer()
                {
                      CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
                },
                new Customer()
                {
                      CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
                },
                new Customer()
                {
                     CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
                },
                new Customer()
                {
                      CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "TP.HCM",
                Email = "abc@gmail.com",
                Phone = "0123.456.789",
                Balance = 1520000
                },
            };

            ViewBag.list = listCustomer;

            return View();
        }
    }
}
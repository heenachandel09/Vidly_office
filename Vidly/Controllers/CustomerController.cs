﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models; 

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Customer")]
        public ActionResult RenderCustomer()
        {
            var customer = new List<Customer>
           {
               new Customer {CustomerName="Yes Bank",Id=1},
               new Customer {CustomerName="Axis Bank",Id=2 }
           };

            CustomerListViewModel cust = new CustomerListViewModel
            {
                customerviewmodel = customer
            };

            return View(cust);
        }
       public ActionResult Details(int id)
        {
            var customer = new List<Customer>
           {
               new Customer {CustomerName="Yes Bank",Id=1},
               new Customer {CustomerName="Axis Bank",Id=2 }
           };
            var query = from cust in customer
                        where cust.Id == id
                        select cust.CustomerName;


            ViewBag.CustomerName = query.ToList();
          
            return View();
        }
    }
}

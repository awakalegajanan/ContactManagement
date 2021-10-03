using OnionContactManagementSolution.UI.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnionContactManagementSolution.Core.Models;

namespace OnionContactManagementSolution.UI.Controllers
{
    public class HomeController : Controller
    {
        ServiceRepository serviceRepo;

        public HomeController()
        {
            serviceRepo = new ServiceRepository(ConfigurationManager.AppSettings.Get("ServiceUrl"));
        }
        public ActionResult Index()
        {
           var result = serviceRepo.GetResponse("contacts").ToList<Contact>();            
            return View(result);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact model)
        {
            model.Status = "A";
            var result = serviceRepo.PostResponse("contacts", model);            
            ViewBag.Message = "Data Insert Successfully";
            var contacts = serviceRepo.GetResponse("contacts").ToList<Contact>();
            return View("Index", contacts);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = serviceRepo.GetResponseById($"contacts", id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Contact model)
        {
            int id = model.CustId;
            var data = serviceRepo.PutResponse($"contacts/{id}", model);             

            return RedirectToAction("index");
        }

        public ActionResult Detail(int id)
        {
            var data = serviceRepo.GetResponseById("contacts", id); 
            return View(data);
        }
 
        public ActionResult Delete(int id)
        {
            var model = serviceRepo.GetResponseById("contacts", id);
            model.Status = "N";            
            var data = serviceRepo.PutResponse($"contacts/{id}", model);
            
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
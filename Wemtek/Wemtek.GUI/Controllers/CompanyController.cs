using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wemtek.Domain.Entities;
using Wemtek.GUI.Models;
using Wemtek.Service.Services;

namespace Wemtek.GUI.Controllers
{
    public class CompanyController : Controller
    {
        CompanyService service = null;
        public CompanyController()
        {
                service = new CompanyService();
        }
        // GET: Company
        public ActionResult Index()
        {
            IEnumerable<company> listCompany = service.GetMany();

            List<CompanyModels> listCompanyModels=new List<CompanyModels>();
            
            
            foreach (company c in listCompany)
            {
                CompanyModels cm=new CompanyModels() ;
                cm.Id = c.Id;
                cm.Name = c.Name;
                cm.Website = c.Website;
                cm.Country = c.Country;
                listCompanyModels.Add(cm);
            }
            
            return View(listCompanyModels);
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(companyViewModel company)
        {
            try
            {
                // TODO: Add insert logic here

                company c = new company();
                c.Website = company.Website;
                c.Name = company.Name;
                c.Country = company.Country;
               // c.Id = 1;

                service.Add(c);
                service.Commit();
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

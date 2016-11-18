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
    public class DocumentController : Controller
    {
        DocumentService service = null;
        public DocumentController()
        {
            service = new DocumentService();
        }
        // GET: Document
        public ActionResult Index()
        {
            IEnumerable<document> listDocuments= service.GetMany();
            List<DocumentModels> listDocumentModels = new List<DocumentModels>();


            foreach (document d in listDocuments)
            {
                DocumentModels dm = new DocumentModels();
                dm.Id = d.id;
                dm.Name = d.name;
                dm.numberDownloading = d.numberDownloading;
                dm.path = d.path;
                listDocumentModels.Add(dm);
            }
            return View(listDocumentModels);
        }

        // GET: Document/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document/Create
        [HttpPost]
        public ActionResult Create(DocumentModels dm)
        {
            try
            {
                document d = new document();
                d.name = dm.Name;
                d.numberDownloading = dm.numberDownloading;
                d.path = dm.path;

                service.Add(d);
                service.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Document/Edit/5
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

        // GET: Document/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Document/Delete/5
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

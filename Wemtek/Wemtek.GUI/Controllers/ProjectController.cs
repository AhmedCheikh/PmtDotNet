using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wemtek.Domain.Entities;
using Wemtek.GUI.Helpers;
using Wemtek.GUI.Models;
using Wemtek.Service.Services;

namespace Wemtek.GUI.Controllers
{
    public class ProjectController : Controller
    {
        ProjectService service;
        CategoryService catService;
        public ProjectController()
        {
            service = new ProjectService();
            catService = new CategoryService();
        }
        // GET: Project
        public ActionResult Index()
        {
            IEnumerable<project> projects = service.GetMany();
            
            List<projectViewModel> listProjects = new List<projectViewModel>();
            

            foreach (project p in projects)
            {
                projectViewModel pvm = new projectViewModel();
                pvm.Id = p.id;
                pvm.Name = p.Name;
                pvm.Description = p.Description;
                pvm.CategoryId = p.category_idCategory;

                listProjects.Add(pvm);
            }
            return View(listProjects);
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            IEnumerable<category> categories = catService.GetMany();
            List<categoryViewModel> listCategories = new List<categoryViewModel>();            
            foreach (category cc in categories)
            {
                categoryViewModel cvm = new categoryViewModel();
                cvm.idCategory = cc.idCategory;
                cvm.name = cc.name;


                listCategories.Add(cvm);
            }
            projectViewModel pvm = new projectViewModel();
            pvm.Categories = categories.ToSelectCatPerProject();
            return View(pvm);
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(projectViewModel pm)
        {
            try
            {
                project p = new project();
                p.Name = pm.Name;
                p.Description = pm.Description;
                p.category_idCategory = pm.CategoryId;
                service.addProject(p);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
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

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            project p = service.GetById(id);
            projectViewModel pvm = new projectViewModel();
            pvm.Name = p.Name;
            return View(pvm);
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, projectViewModel pvm)
        {
            try
            {
                // TODO: Add delete logic here
                service.Delete(service.GetById(id));
                service.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

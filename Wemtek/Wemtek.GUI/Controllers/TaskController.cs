﻿using Service.Pattern;
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
    public class TaskController : Controller
    {
        TaskService service = null;
         public TaskController()
    {
        service = new TaskService();
    }
    
        // GET: Task
        public ActionResult Index()
        {
            return View(service.GetMany());
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create(taskViewModel task)
        {
            try
            {
               task c = new task();
                c.complexity = task.complexity;
                c.duration = task.duration;        
                c.etat = task.etat;             
                service.Add(c);
                service.Commit();



                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
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

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
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

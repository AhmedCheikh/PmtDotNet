using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wemtek.Domain.Entities;
using Wemtek.GUI.Models;
using Wemtek.Service.Services;
using Wemtek.GUI.Helpers; 

namespace Wemtek.GUI.Controllers
{
    public class UserController : Controller
    {

        IUserService service = null;
        ICompanyService companieservice = null;
        public UserController()
        {
            service = new UserService();
            companieservice = new CompanyService();
        }

        //
        // GET: /User/
        public ActionResult Index()
        {
            IEnumerable<user> users = service.GetMany();
            List<userViewModel> models = new List<userViewModel>();

            foreach (user us in users)
            {
                userViewModel u = new userViewModel();
                u.idUser = us.idUser;
                u.FirstName = us.FirstName;
                u.LastName = us.LastName;
                u.Password = us.Password;
                u.Email = us.Email;
                u.company_Id = us.company_Id;
                models.Add(u);

            }


            return View(models);
        }

        //
        // GET: /User/Details/5
        public ActionResult Details(int id)
        {
            var user = service.GetById(id);
            userViewModel u = new userViewModel();
            u.idUser = user.idUser;
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.Password = user.Password;
            u.Email = user.Email;
            u.company_Id = user.company_Id;
            return View(u);
        }

        //
        // GET: /User/Create
        public ActionResult Create()
        {
            userViewModel user = new userViewModel();

            List<company> listcompany = new List<company>();
            listcompany = companieservice.GetMany().ToList();

            user.companies = listcompany.ToSelectListItems(); 

            return View(user);
        }

        //
        // POST: /User/Create
        [HttpPost]
        public ActionResult Create(userViewModel user)
        {
            user u = new user();
            if (ModelState.IsValid)
            {
                u.idUser = user.idUser;
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Password = user.Password;
                u.Email = user.Email;
                u.company_Id = user.company_Id;

                service.Add(u);
                service.Commit();
            }

            return RedirectToAction("Index");
        }

        //
        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = service.GetById(id);
            userViewModel u = new userViewModel();
            u.idUser = user.idUser;
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.Password = user.Password;
            u.Email = user.Email;
            u.company_Id = user.company_Id;
            return View(u);
        }

        //
        // POST: /User/Edit/5
        [HttpPost]
        public ActionResult Edit(userViewModel user)
        {
            user u = new user();
            if (ModelState.IsValid)
            {
                u.idUser = user.idUser;
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Password = user.Password;
                u.Email = user.Email;
                u.company_Id = user.company_Id;

                service.Update(u);
                service.Commit();
            }

            return RedirectToAction("Index");
        }

        //
        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = service.GetById(id);

            service.Delete(user);
            service.Commit();

            return RedirectToAction("Index");
        }



        //
        // POST: /User/Delete/5
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TasksController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: Tasks
        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        // GET: Tasks/Details/{id}
        public ActionResult Details (int? id)
        {
            return View();
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        public ActionResult Create(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Tasks/Edit/{id}
        public ActionResult Edit(int? id)
        {
            Task task = db.Tasks.Find(id);
            return View(task);
        }

        // POST: Tasks/Edit/{id}
        [HttpPost]
        public ActionResult Edit(Task task)
        {
            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Tasks/Delete/{id}
        public ActionResult Delete(int? id)
        {
            return View();
        }

        // POST : Tasks/Delete/{id}
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            return View();
        }
    }
}
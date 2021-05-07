using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstAproach.Models;

namespace CodeFirstAproach.Controllers
{
    public class ProjectAssignDevelopersController : Controller
    {
        private CodeFirstContext db = new CodeFirstContext();

        // GET: ProjectAssignDevelopers
        public ActionResult Index()
        {
            var projectAssignDevelopers = db.ProjectAssignDevelopers.Include(p => p.Developer).Include(p => p.Project);
            return View(projectAssignDevelopers.ToList());
        }

        // GET: ProjectAssignDevelopers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectAssignDeveloper projectAssignDeveloper = db.ProjectAssignDevelopers.Find(id);
            if (projectAssignDeveloper == null)
            {
                return HttpNotFound();
            }
            return View(projectAssignDeveloper);
        }

        // GET: ProjectAssignDevelopers/Create
        public ActionResult Create()
        {
            ViewBag.DevId = new SelectList(db.Developers, "DevId", "FirstName");
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName");
            return View();
        }

        // POST: ProjectAssignDevelopers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectAssignDeveloperId,DevId,ProjectId")] ProjectAssignDeveloper projectAssignDeveloper)
        {
            if (ModelState.IsValid)
            {
                db.ProjectAssignDevelopers.Add(projectAssignDeveloper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DevId = new SelectList(db.Developers, "DevId", "FirstName", projectAssignDeveloper.DevId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName", projectAssignDeveloper.ProjectId);
            return View(projectAssignDeveloper);
        }

        // GET: ProjectAssignDevelopers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectAssignDeveloper projectAssignDeveloper = db.ProjectAssignDevelopers.Find(id);
            if (projectAssignDeveloper == null)
            {
                return HttpNotFound();
            }
            ViewBag.DevId = new SelectList(db.Developers, "DevId", "FirstName", projectAssignDeveloper.DevId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName", projectAssignDeveloper.ProjectId);
            return View(projectAssignDeveloper);
        }

        // POST: ProjectAssignDevelopers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectAssignDeveloperId,DevId,ProjectId")] ProjectAssignDeveloper projectAssignDeveloper)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectAssignDeveloper).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DevId = new SelectList(db.Developers, "DevId", "FirstName", projectAssignDeveloper.DevId);
            ViewBag.ProjectId = new SelectList(db.Projects, "ProjectId", "ProjectName", projectAssignDeveloper.ProjectId);
            return View(projectAssignDeveloper);
        }

        // GET: ProjectAssignDevelopers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectAssignDeveloper projectAssignDeveloper = db.ProjectAssignDevelopers.Find(id);
            if (projectAssignDeveloper == null)
            {
                return HttpNotFound();
            }
            return View(projectAssignDeveloper);
        }

        // POST: ProjectAssignDevelopers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectAssignDeveloper projectAssignDeveloper = db.ProjectAssignDevelopers.Find(id);
            db.ProjectAssignDevelopers.Remove(projectAssignDeveloper);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

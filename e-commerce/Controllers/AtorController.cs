using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using e_commerce.Context;
using e_commerce.Models;

namespace e_commerce.Controllers
{
    public class AtorController : Controller
    {
        private Context.Context db = new Context.Context();

        // GET: Ator
        public ActionResult Index()
        {
            return View(db.Ator.ToList());
        }

        // GET: Ator/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator ator = db.Ator.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        // GET: Ator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ator/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AtorId,AtorFotoLink,AtorNomeCompleto,AtorBio")] Ator ator)
        {
            if (ModelState.IsValid)
            {
                db.Ator.Add(ator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ator);
        }

        // GET: Ator/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator ator = db.Ator.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        // POST: Ator/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AtorId,AtorFotoLink,AtorNomeCompleto,AtorBio")] Ator ator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        // GET: Ator/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator ator = db.Ator.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        // POST: Ator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ator ator = db.Ator.Find(id);
            db.Ator.Remove(ator);
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

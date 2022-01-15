using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using e_commerce.Models;

namespace e_commerce.Controllers
{
    public class Ator_FilmeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ator_Filme
        public ActionResult Index()
        {
            var ator_Filme = db.Ator_Filme.Include(a => a.Ator);
            return View(ator_Filme.ToList());
        }

        // GET: Ator_Filme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator_Filme ator_Filme = db.Ator_Filme.Find(id);
            if (ator_Filme == null)
            {
                return HttpNotFound();
            }
            return View(ator_Filme);
        }

        // GET: Ator_Filme/Create
        public ActionResult Create()
        {
            ViewBag.AtorId = new SelectList(db.Ators, "AtorId", "AtorFotoLink");
            return View();
        }

        // POST: Ator_Filme/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmeId,AtorId")] Ator_Filme ator_Filme)
        {
            if (ModelState.IsValid)
            {
                db.Ator_Filme.Add(ator_Filme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AtorId = new SelectList(db.Ators, "AtorId", "AtorFotoLink", ator_Filme.AtorId);
            return View(ator_Filme);
        }

        // GET: Ator_Filme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator_Filme ator_Filme = db.Ator_Filme.Find(id);
            if (ator_Filme == null)
            {
                return HttpNotFound();
            }
            ViewBag.AtorId = new SelectList(db.Ators, "AtorId", "AtorFotoLink", ator_Filme.AtorId);
            return View(ator_Filme);
        }

        // POST: Ator_Filme/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmeId,AtorId")] Ator_Filme ator_Filme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ator_Filme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AtorId = new SelectList(db.Ators, "AtorId", "AtorFotoLink", ator_Filme.AtorId);
            return View(ator_Filme);
        }

        // GET: Ator_Filme/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator_Filme ator_Filme = db.Ator_Filme.Find(id);
            if (ator_Filme == null)
            {
                return HttpNotFound();
            }
            return View(ator_Filme);
        }

        // POST: Ator_Filme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ator_Filme ator_Filme = db.Ator_Filme.Find(id);
            db.Ator_Filme.Remove(ator_Filme);
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

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
    public class ProdutorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produtor
        public ActionResult Index()
        {
            return View(db.Produtors.ToList());
        }

        // GET: Produtor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtor produtor = db.Produtors.Find(id);
            if (produtor == null)
            {
                return HttpNotFound();
            }
            return View(produtor);
        }

        // GET: Produtor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtor/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutorId,ProdutorFotoLink,ProdutorNomeCompleto,ProdutorBio")] Produtor produtor)
        {
            if (ModelState.IsValid)
            {
                db.Produtors.Add(produtor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produtor);
        }

        // GET: Produtor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtor produtor = db.Produtors.Find(id);
            if (produtor == null)
            {
                return HttpNotFound();
            }
            return View(produtor);
        }

        // POST: Produtor/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdutorId,ProdutorFotoLink,ProdutorNomeCompleto,ProdutorBio")] Produtor produtor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produtor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produtor);
        }

        // GET: Produtor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtor produtor = db.Produtors.Find(id);
            if (produtor == null)
            {
                return HttpNotFound();
            }
            return View(produtor);
        }

        // POST: Produtor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produtor produtor = db.Produtors.Find(id);
            db.Produtors.Remove(produtor);
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

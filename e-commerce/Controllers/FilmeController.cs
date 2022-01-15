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
    public class FilmeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Filme
        public ActionResult Index()
        {
            var filmes = db.Filmes.Include(f => f.Cinema).Include(f => f.Produtor);
            return View(filmes.ToList());
        }

        // GET: Filme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filme filme = db.Filmes.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(filme);
        }

        // GET: Filme/Create
        public ActionResult Create()
        {
            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "CinemaLogo");
            ViewBag.ProdutorId = new SelectList(db.Produtors, "ProdutorId", "ProdutorFotoLink");
            return View();
        }

        // POST: Filme/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmeId,FilmeNome,FilmeDescricao,FilmePreco,FilmeFotoLink,FilmeDataInicio,FilmeDataFim,FilmeCategoria,CinemaId,ProdutorId")] Filme filme)
        {
            if (ModelState.IsValid)
            {
                db.Filmes.Add(filme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "CinemaLogo", filme.CinemaId);
            ViewBag.ProdutorId = new SelectList(db.Produtors, "ProdutorId", "ProdutorFotoLink", filme.ProdutorId);
            return View(filme);
        }

        // GET: Filme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filme filme = db.Filmes.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "CinemaLogo", filme.CinemaId);
            ViewBag.ProdutorId = new SelectList(db.Produtors, "ProdutorId", "ProdutorFotoLink", filme.ProdutorId);
            return View(filme);
        }

        // POST: Filme/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmeId,FilmeNome,FilmeDescricao,FilmePreco,FilmeFotoLink,FilmeDataInicio,FilmeDataFim,FilmeCategoria,CinemaId,ProdutorId")] Filme filme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "CinemaLogo", filme.CinemaId);
            ViewBag.ProdutorId = new SelectList(db.Produtors, "ProdutorId", "ProdutorFotoLink", filme.ProdutorId);
            return View(filme);
        }

        // GET: Filme/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filme filme = db.Filmes.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(filme);
        }

        // POST: Filme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filme filme = db.Filmes.Find(id);
            db.Filmes.Remove(filme);
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

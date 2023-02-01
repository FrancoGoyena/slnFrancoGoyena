using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly RecetaDBContext context;

        public RecetaController(RecetaDBContext context)
        {
            this.context = context;
        }

        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var receta = context.Recetas.ToList();
            return View(receta);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Receta>> GetByApellido(string apellido)
        {
            var receta = (from a in context.Recetas
                            where a.Apellido == apellido
                          select a).ToList();
            return View("GetByAutor", receta);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Receta>> GetByAutor(string autor)
        {
            var receta = (from a in context.Recetas
                          where a.Autor == autor
                          select a).ToList();
            return View("GetByAutor", receta);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", receta);
            }
        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", receta);
            }
        }

        [ActionName("Edit")]
        [HttpPost]
        public ActionResult EditConfirmacion(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(receta).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View(receta);

        }

    }
}

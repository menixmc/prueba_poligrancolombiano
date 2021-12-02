using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Libros.Models;
using Microsoft.EntityFrameworkCore;

namespace Libros.Controllers
{
    public class HomeController : Controller
    {
        libreriaContext db = new libreriaContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LibrosList(int? rta)
        {
            List<Libro> List = db.Libro
                             .Include(m => m.Autor)
                             .Include(m => m.Idioma)
                             .ToList();

            ViewBag.rta = rta;
            string msg = (string)TempData["msg"];
            ViewBag.msg = msg;
            return View(List);
        }

        public IActionResult Libro(int? idlibro)
        {
            Libro obj = new Libro();
            ViewBag.idiomas = db.Idioma.ToList();
            ViewBag.autores = db.Autor.ToList();

            if (idlibro == null)
            {
                return View(new Libro());
            }
            else
            {
                return View(db.Libro.Where(l => l.IdLibro == idlibro).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Libro(int idlibro, string titulo, string editorial, int idioma, int año, int npaginas, int autor)
        {
            Libro obj = new Libro();
            ViewBag.idiomas = db.Idioma.ToList();
            ViewBag.autores = db.Autor.ToList();
            try
            {
                if (idlibro != 0)
                {
                    obj = db.Libro.Where(l => l.IdLibro == idlibro).FirstOrDefault();
                }
                obj.Titulo = titulo;
                obj.Editorial = editorial;
                obj.idioma_id = idioma;
                obj.Año = año;
                obj.NumPaginas = npaginas;
                obj.AutorId = autor;
                if (idlibro != 0)
                {
                    db.SaveChanges();
                }
                else
                {
                    db.Libro.Add(obj);
                    db.SaveChanges();
                }

                TempData["msg"] = "Datos guardados correctamente";
                return RedirectToAction("LibrosList", "Home", new { rta = 1 });
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Error al procesar los datos: " + ex.Message;
                return View(new Libro());
            }
        }

        public ActionResult EliminarLibro(int idlibro)
        {
            try
            {
                Libro obj = db.Libro.Where(l => l.IdLibro == idlibro).FirstOrDefault();
                db.Libro.Remove(obj);
                db.SaveChanges();

                TempData["msg"] = "Datos eliminados correctamente";
                return RedirectToAction("LibrosList", "Home", new { rta = 1 });
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Error al realizar la acción: " + ex.Message;
                return RedirectToAction("LibrosList", "Home", new { rta = 2 });
            }
        }
    }
}

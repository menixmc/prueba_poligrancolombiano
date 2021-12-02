using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{   
    public class HomeController : Controller
    {
        readonly libreriaEntities db = new libreriaEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AutorList(int? rta)
        {
            List<autor> List = db.autor.ToList();
            ViewBag.libros = db.libro.ToList();
            ViewBag.rta = rta;
            string msg = (string)TempData["msg"];
            ViewBag.msg = msg;
            return View(List);
        }

        public ActionResult Autor(int? idautor)
        {
            autor obj = new autor();
            ViewBag.pais = db.pais.ToList();
            ViewBag.genero = db.genero.ToList();

            if (idautor == null)
            {
                return View(new autor());
            }
            else
            {
                return View(db.autor.Where(l => l.id_autor == idautor).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Autor(int idautor, string nombres, string apellidos, string fecha, int nacionalidad, int genero)
        {
            autor obj = new autor();
            ViewBag.pais = db.pais.ToList();
            ViewBag.genero = db.genero.ToList();
            try
            {
                if (idautor != 0)
                {
                    obj = db.autor.Where(l => l.id_autor == idautor).FirstOrDefault();
                }
                obj.nombres = nombres;
                obj.apellidos = apellidos;
                obj.fecha_nacimiento = Convert.ToDateTime(fecha);
                obj.pais_id = nacionalidad;
                obj.genero_id = genero;
                if (idautor != 0)
                {
                    db.SaveChanges();
                }
                else
                {
                    db.autor.Add(obj);
                    db.SaveChanges();
                }

                TempData["msg"] = "Datos guardados correctamente";
                return RedirectToAction("AutorList", "Home", new { rta = 1 });
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Error al procesar los datos: " + ex.Message;
                return View(new autor());
            }
        }

        public ActionResult EliminarAutor(int idautor)
        {
            try
            {
                autor obj = db.autor.Where(l => l.id_autor == idautor).FirstOrDefault();
                db.autor.Remove(obj);
                db.SaveChanges();

                TempData["msg"] = "Datos eliminados correctamente";
                return RedirectToAction("AutorList", "Home", new { rta = 1 });
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Error al realizar la acción: " + ex.Message;
                return RedirectToAction("AutorList", "Home", new { rta = 2 });
            }
        }


        public PartialViewResult LibrosAutor(int idautor)
        {
            List<libro> libros = db.libro.Where(l => l.autor_id == idautor).ToList();
            return PartialView(libros);
        }

    }
}
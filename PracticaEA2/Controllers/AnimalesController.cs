using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaEA2.Controllers
{
    public class AnimalesController : Controller
    {
        IAnimalesServicio AnimalesServicio;
        ITipoAnimalesServicio TipoAnimalesServicio;

        public AnimalesController()
        {
            PracticaWebServicesEntities ctx = new PracticaWebServicesEntities();
            AnimalesServicio = new AnimalesServicio(ctx);
            TipoAnimalesServicio = new TipoAnimalesServicio(ctx);
        }

        public ActionResult Lista()
        {
            ViewBag.TodosTipoAnimal = TipoAnimalesServicio.ObtenerTodos();
            List<Animal> animales = AnimalesServicio.ObtenerTodos();
            return View(animales);
        }

        [HttpPost]
        public ActionResult ListaPorTipo(int IdTipoAnimal)
        {
            List<Animal> animales;
            if (IdTipoAnimal == 0)
            {
                animales = AnimalesServicio.ObtenerTodos();
            }
            else
            {
                animales = AnimalesServicio.ObtenerPorTipo(IdTipoAnimal);
            }
            ViewBag.TodosTipoAnimal = TipoAnimalesServicio.ObtenerTodos();
            ViewBag.IdTipoAnimalSeleccionado = IdTipoAnimal;
            return View("Lista", animales);
        }
    }
}
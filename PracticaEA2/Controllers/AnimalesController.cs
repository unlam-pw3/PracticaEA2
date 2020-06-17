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

        public AnimalesController()
        {
            PracticaWebServicesEntities ctx = new PracticaWebServicesEntities();
            AnimalesServicio = new AnimalesServicio(ctx);
        }

        public ActionResult Lista()
        {
            List<Animal> animales = AnimalesServicio.ObtenerTodos();
            return View(animales);
        }
    }
}
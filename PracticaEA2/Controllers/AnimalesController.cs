﻿using DAL;
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

        [HttpGet]
        public ActionResult Alta()
        {
            ViewBag.TodosTipoAnimal = TipoAnimalesServicio.ObtenerTodos();
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Animal animal)
        {
            if (ModelState.IsValid)
            {
                AnimalesServicio.Alta(animal);
                return RedirectToAction("Lista");
            }
            else
            {
                ViewBag.IdTipoAnimalSeleccionado = animal.IdTipoAnimal;
                ViewBag.TodosTipoAnimal = TipoAnimalesServicio.ObtenerTodos();
                return View(animal);
            }
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
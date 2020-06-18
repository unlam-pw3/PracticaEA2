using DAL;
using PracticaEA2.DTOs;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticaEA2.Controllers
{
    public class AnimalesApiController : ApiController
    {
        IAnimalesServicio AnimalesServicio;

        public AnimalesApiController()
        {
            PracticaWebServicesEntities ctx = new PracticaWebServicesEntities();
            AnimalesServicio = new AnimalesServicio(ctx);
        }

        // GET api/<controller>
        public List<AnimalDTO> Get()
        {
            List<Animal> animalesEF = AnimalesServicio.ObtenerTodos();
            List<AnimalDTO> animalesDTO = new List<AnimalDTO>();
            foreach (var animalEF in animalesEF)
            {
                AnimalDTO dto = new AnimalDTO(animalEF);
                animalesDTO.Add(dto);
            }
            return animalesDTO;
        }
       
    }
}
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class AnimalesServicio : IAnimalesServicio
    {
        protected IAnimalesRepositorio AnimalesRepositorio { get; set; }

        public AnimalesServicio(PracticaWebServicesEntities ctx)
        {
            AnimalesRepositorio = new AnimalesRepositorio(ctx);
        }

        public void Alta(Animal animal)
        {
            AnimalesRepositorio.Alta(animal);
        }

        public List<Animal> ObtenerTodos()
        {
            return AnimalesRepositorio.ObtenerTodos();
        }

        public List<Animal> ObtenerPorTipo(int idTipo)
        {
            return AnimalesRepositorio.ObtenerPorTipo(idTipo);
        }
    }
}

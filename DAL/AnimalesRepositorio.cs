using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnimalesRepositorio : IAnimalesRepositorio
    {
        public PracticaWebServicesEntities Contexto { get; set; }

        public AnimalesRepositorio(PracticaWebServicesEntities ctx)
        {
            Contexto = ctx;
        }

        public void Alta(Animal animal)
        {
            Contexto.Animal.Add(animal);
            Contexto.SaveChanges();
        }   

        public List<Animal> ObtenerTodos()
        {
            return Contexto.Animal.ToList();
        }

        public List<Animal> ObtenerPorTipo(int idTipo)
        {
            #region Pregunta Codarin
            //http://localhost:1231/animales/obtener/3
            //http://localhost:1231/animales/obtener?idTipo=3
            //int? idTipo = Request["idTipo"];
            #endregion
            //con Linq
            var animalesConLinq = (
                                    from a
                                        in Contexto.Animal
                                    where a.IdTipoAnimal == idTipo
                                    select a
                                    ).ToList();

            //con Lambda
            List<Animal> animales = Contexto.Animal
                                    .Where(o => o.IdTipoAnimal == idTipo)
                                    .ToList();

            return animales;
        }
    }
}

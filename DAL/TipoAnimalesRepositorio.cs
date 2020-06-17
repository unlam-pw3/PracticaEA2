using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoAnimalesRepositorio : ITipoAnimalesRepositorio
    {
        public PracticaWebServicesEntities Contexto { get; set; }

        public TipoAnimalesRepositorio(PracticaWebServicesEntities ctx)
        {
            Contexto = ctx;
        }

        public List<TipoAnimal> ObtenerTodos()
        {
            return Contexto.TipoAnimal.ToList();
        }

    }
}

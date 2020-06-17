using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class TipoAnimalesServicio : ITipoAnimalesServicio
    {
        protected ITipoAnimalesRepositorio TipoAnimalesRepositorio { get; set; }

        public TipoAnimalesServicio(PracticaWebServicesEntities ctx)
        {
            TipoAnimalesRepositorio = new TipoAnimalesRepositorio(ctx);
        }
        public List<TipoAnimal> ObtenerTodos()
        {
            return TipoAnimalesRepositorio.ObtenerTodos();
        }

    }
}

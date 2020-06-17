using DAL;
using System.Collections.Generic;

namespace Servicios
{
    public interface ITipoAnimalesServicio
    {
        List<TipoAnimal> ObtenerTodos();
    }
}
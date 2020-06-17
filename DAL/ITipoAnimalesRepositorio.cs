using System.Collections.Generic;

namespace DAL
{
    public interface ITipoAnimalesRepositorio
    {
        PracticaWebServicesEntities Contexto { get; set; }

        List<TipoAnimal> ObtenerTodos();
    }
}
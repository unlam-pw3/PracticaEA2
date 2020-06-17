using System.Collections.Generic;

namespace DAL
{
    public interface IAnimalesRepositorio
    {
        PracticaWebServicesEntities Contexto { get; set; }

        void Alta(Animal animal);

        List<Animal> ObtenerTodos();

        List<Animal> ObtenerPorTipo(int idTipo);
    }
}
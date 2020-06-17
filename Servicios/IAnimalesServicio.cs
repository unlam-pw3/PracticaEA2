using DAL;
using System.Collections.Generic;

namespace Servicios
{
    public interface IAnimalesServicio
    {
        IAnimalesRepositorio AnimalesRepositorio { get; set; }
        void Alta(Animal animal);

        List<Animal> ObtenerTodos();

        List<Animal> ObtenerPorTipo(int idTipo);
    }
}
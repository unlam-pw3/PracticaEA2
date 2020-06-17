using DAL;
using System.Collections.Generic;

namespace Servicios
{
    public interface IAnimalesServicio
    {
        void Alta(Animal animal);

        List<Animal> ObtenerTodos();

        List<Animal> ObtenerPorTipo(int idTipo);
    }
}
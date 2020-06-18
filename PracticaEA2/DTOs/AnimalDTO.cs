using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PracticaEA2.DTOs
{
    [DataContract]
    public class AnimalDTO
    {
        [DataMember]
        public int IdAnimal { get; set; }
        [DataMember]
        public string NombreEspecie { get; set; }
        [DataMember]
        public double PesoPromedio { get; set; }
        [DataMember]
        public int EdadPromedio { get; set; }
        [DataMember]
        public int IdTipoAnimal { get; set; }

        public AnimalDTO(Animal animal)
        {
            this.IdAnimal = animal.IdAnimal;
            this.NombreEspecie = animal.NombreEspecie;
            this.PesoPromedio = animal.PesoPromedio;
            this.EdadPromedio = animal.EdadPromedio;
            this.IdTipoAnimal = animal.IdTipoAnimal;
        }
    }
}
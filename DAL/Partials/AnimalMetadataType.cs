using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Partials
{
    public class AnimalMetadataType
    {
        [Required(ErrorMessage="Nombre especie requerido")]
        public string NombreEspecie { get; set; }

        [Required(ErrorMessage="Peso promedio requerido")]
        [Range(0, 100000, ErrorMessage ="El Peso promedio debe ser entre 0-100000")]
        public double PesoPromedio { get; set; }

        [Required(ErrorMessage="Edad promedio requerida")]
        [Range(0, 300, ErrorMessage ="La Edad promedio debe ser entre 0-300")]
        public int EdadPromedio { get; set; }

        [Required(ErrorMessage="Tipo Animal requerido")]
        public int IdTipoAnimal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders72.Shared.Entities
{
    public class Country
    {
        //Definimos las propiedades del Pais (código y nombre)
        public int Id { get; set; } //Clave primaria de la entidad País
        [Display(Name = "País")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!; //Le estamos diciendo que no puede ser nulo el nombre del País.
    }

}

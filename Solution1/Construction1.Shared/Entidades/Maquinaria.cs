using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class Maquinaria
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El Campo {0} No Permiten Mas de {1} digitos ")]
        [Required(ErrorMessage = "El Campo {0} el campo es obligatorio")]

        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        [Display(Name = "Estado")]

        public bool Estado { get; set; }

        [Display(Name = "Disponibilidad")]
        public bool Disponibilidad { get; set; }

        [JsonIgnore]
        public Tarea Tareas { get; set; }
    }
}

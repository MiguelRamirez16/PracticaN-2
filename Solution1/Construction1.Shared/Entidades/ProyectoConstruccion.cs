using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class ProyectoConstruccion
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El Campo {0} No Permiten Mas de {1} digitos ")]
        [Required(ErrorMessage = "El Campo {0} el campo es obligatorio")]

        public string Nombre { get; set; }

        [Display(Name = "Ubicacion")]
        [MaxLength(70, ErrorMessage = "El Campo {0} No Permiten Mas de {1} digitos ")]
        [Required(ErrorMessage = "El Campo {0} el campo es obligatorio")]

        public string Ubicacion { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El Campo {0} No Permiten Mas de {1}digitos ")]
        [Required(ErrorMessage = "El Campo {0} el campo es obligatorio")]

        public string Descripcion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "The field {} is mandatory.")]

        public DateTime FechaInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "The field {} is mandatory.")]

        public DateTime FechaAproxFin { get; set; }

        [JsonIgnore]
        public Presupuesto Presupuestos { get; set; }
        [JsonIgnore]
        public Material Materiales { get; set; }
        [JsonIgnore]
        public Tarea Tareas { get; set; }
        [JsonIgnore]
        public Maquinaria Maquinarias { get; set; } //NO ESTOY SEGURO DE ESTE, MIRAR MER

        [JsonIgnore]
        public ICollection<AsignacionEquipo> AsignacionEquipos { get; set; } //Muchos a muchos
    }
}

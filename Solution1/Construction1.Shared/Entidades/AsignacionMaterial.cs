using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class AsignacionMaterial
    {
        public int Id { get; set; }

        [ForeignKey("IdMateriales")]
        [JsonIgnore]
        public Material Materiales { get; set; }
        public int? IdMateriales { get; set; }

        [ForeignKey("IdTarea")]
        [JsonIgnore]
        public Tarea Tareas { get; set; }
        public int? IdTarea { get; set; }
    }
}
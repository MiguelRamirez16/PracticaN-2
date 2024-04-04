using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class AsignacionMaterial
    {
        public int Id { get; set; }
        [JsonIgnore]
        public Material Materiales { get; set; }
        [JsonIgnore]
        public Tarea Tareas { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class AsignacionMaterial
    {
        public int Id { get; set; }

        public Material Materiales { get; set; }

        public Tarea Tareas { get; set; }
    }
}
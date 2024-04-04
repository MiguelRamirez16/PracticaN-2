
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class AsignacionEquipo
    {
        public int Id { get; set; }
        [JsonIgnore]
        public EquipoConstruccion EquipoContrucciones { get; set; }
        [JsonIgnore]
        public ProyectoConstruccion ProyectoConstrucciones { get; set; }
    }
}

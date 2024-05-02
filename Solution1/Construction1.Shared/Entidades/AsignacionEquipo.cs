
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class AsignacionEquipo
    {
        public int Id { get; set; }

        [ForeignKey("IdEquiContruccion")]
        [JsonIgnore]
        public EquipoConstruccion EquipoContrucciones { get; set; }
        public int? IdEquiContruccion { get; set; }

        [ForeignKey("IdProyeContruccion")]
        [JsonIgnore]
        public ProyectoConstruccion ProyectoConstrucciones { get; set; }
        public int? IdProyeContruccion { get; set; }
    }
}

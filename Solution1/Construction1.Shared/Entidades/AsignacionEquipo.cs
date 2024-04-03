
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class AsignacionEquipo
    {
        public int Id { get; set; }

        public EquipoConstruccion EquipoContrucciones { get; set; }

        public ProyectoConstruccion ProyectoConstrucciones { get; set; }
    }
}

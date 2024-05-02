using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Shared.Entidades
{
    public class Presupuesto

    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public double CostoManoObra { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public double CostoMateriales { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public double CostoMaquinas { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public double CostoProyecto { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public double CostoTarea { get; set; }



    }
}

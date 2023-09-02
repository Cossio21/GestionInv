using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInv.Shared.Entidades
{
    public class Investigador
    {
        public int Investigadorid { get; set; }

        [Required(ErrorMessage = "El documento es requerido")]
        public string Documento { get; set; } = null;

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; } = null;

        [Required(ErrorMessage = "La afiliacion es requerida")]
        public string Afiliacioninstitucional { get; set; } = null;

        [Required(ErrorMessage = "La especializacion es requerida")]
        public string especializacion { get; set; } = null;

        [Required(ErrorMessage = "El rol es requerido")]
        public string rol { get; set; } = null;
       
    }
}

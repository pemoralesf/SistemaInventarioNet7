using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public  class Marca
    {
        [Key]
        public int  Id { get; set; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="Nombre debe ser maximo de 60 caracteres")]
       public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(100, ErrorMessage = "Descripcion maximo de 100 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="El estado es Requerido")]
        public bool Estado { get; set; }
    }
}

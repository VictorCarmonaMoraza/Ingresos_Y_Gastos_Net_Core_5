using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIgresosyGastos_Net_Core.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name ="Nombre Categoria")]
        public string NombreCategoria { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name ="Tipo")]
        public string Tipo { get; set; } //IN:Ingreso GA:Gastos

        [Required]
        public bool Estado { get; set; } //True, False
    }
}

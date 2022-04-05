using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaBackend.DTO
{
    public class DronDTO
    {
        [Required]
        [StringLength(100)]
        public string NumeroSerie { get; set; }
        [Required]
        public int Modelo { get; set; }
        [Required]
        [Range(1, 500)]
        public int PesoLimite { get; set; }
        [Required]
        [Range(1, 100)]
        public int CapacidaBateria { get; set; }
        [Required]
        public int Estado { get; set; }
    }
}

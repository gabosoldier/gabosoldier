using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaBackend.Entidades
{
    public class Medicamento
    {
        public Medicamento()
        {
            DronMedicamento = new HashSet<DronMedicamento>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public string Codigo { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<DronMedicamento> DronMedicamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaBackend.Entidades
{
    public class DronMedicamento
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public virtual Dron Dron { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaBackend.Entidades
{
    public class Dron
    {
        public Dron()
        {
            DronMedicamento = new HashSet<DronMedicamento>();
        }

        public int Id { get; set; }
        public string NumeroSerie { get; set; }
        public int Modelo { get; set; }
        public int PesoLimite { get; set; }
        public int CapacidaBateria { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<DronMedicamento> DronMedicamento { get; set; }
    }
}

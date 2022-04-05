using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaBackend.Modelo
{
    public enum Modelo
    {
        PesoLigero = 1,
        PesoMedio = 2,
        PesoCrucero = 3,
        PesoPesado = 4
    }

    public enum Estado
    {
        Inactivo = 1,
        Cargando = 2,
        Cargado = 3,
        EntregandoCarga = 4,
        CargaEntregada = 5,
        Regresando = 6
    }

    public class StatesDron
    {
        private readonly static StatesDron _instance = new StatesDron();

        private StatesDron()
        {
        }

        public static StatesDron Instance => _instance;
        
        public string getNameModelo(int op)
        {
            return Enum.GetName(typeof(Modelo), op);
        }

        public string getNameEstado(int op)
        {
            return Enum.GetName(typeof(Estado), op);
        }
    }
}

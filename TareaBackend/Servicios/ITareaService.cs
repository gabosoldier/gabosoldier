using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaBackend.Entidades;

namespace TareaBackend.Servicios
{
    public interface ITareaService
    {
        Task RegistrarDron(Dron dron);
        Task CargarDronMedicamento(DronMedicamento dronMedicamento);
        Task<List<Dron>> ObtenerDronesDisponibles();
        Task<int> ComprobarNivelBateria(int DronId);
        Task<int> ComprobarPesoMedicamentosCargados(int DronId);

        Task<Dron> ObtenerDron(int DronId);
        Task<Medicamento> ObtenerMedicamento(int MedicamentoId);
    }
}

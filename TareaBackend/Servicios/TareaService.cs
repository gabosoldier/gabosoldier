using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaBackend.Entidades;

namespace TareaBackend.Servicios
{
    public class TareaService : ITareaService
    {
        private readonly ApplicationDbContext context;

        public TareaService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CargarDronMedicamento(DronMedicamento dronMedicamento)
        {
            context.DronMedicamento.Add(dronMedicamento);
            await context.SaveChangesAsync();
        }

        public async Task<int> ComprobarNivelBateria(int DronId)
        {
            var dron = await context.Dron.FirstOrDefaultAsync(x => x.Id == DronId);
            var nivelBateria = dron.CapacidaBateria;

            return nivelBateria;
        }

        public async Task<int> ComprobarPesoMedicamentosCargados(int DronId)
        {
            //var dron = await context.Dron.Join(context.DronMedicamentos, d => d.Id, dm => dm.DronId, (d, dm) => new { Dron = d, DronMedicamentos = dm });
            var query = from d in context.Dron
                        join dm in context.DronMedicamento
                        on d.Id equals dm.Dron.Id
                        join m in context.Medicamento
                        on dm.Medicamento.Id equals m.Id
                        where d.Id == DronId
                        select m.Peso;

            int peso = 0;
            foreach(int p in query)
            {
                peso += p;
            }

            return peso;
        }

        public async Task<Dron> ObtenerDron(int DronId)
        {
            return await context.Dron.FirstOrDefaultAsync(x => x.Id == DronId);
        }

        public Task<List<Dron>> ObtenerDronesDisponibles()
        {
            throw new NotImplementedException();
        }

        public async Task<Medicamento> ObtenerMedicamento(int MedicamentoId)
        {
            return await context.Medicamento.FirstOrDefaultAsync(x => x.Id == MedicamentoId);
        }

        public async Task RegistrarDron(Dron dron)
        {
            context.Add(dron);
            await context.SaveChangesAsync();
        }
    }
}

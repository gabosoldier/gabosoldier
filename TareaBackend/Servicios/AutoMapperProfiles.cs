using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaBackend.DTO;
using TareaBackend.Entidades;

namespace TareaBackend.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DronDTO, Dron>();
            CreateMap<MedicamentoDTO, Medicamento>();
            CreateMap<DronMedicamentoDTO, DronMedicamento>();
                //.ForMember(x => x.Dron.Id, x => x.MapFrom(y => y.DronId))
                //.ForMember(x => x.Medicamento.Id, x => x.MapFrom(y => y.MedicamentoId));
        }
    }
}

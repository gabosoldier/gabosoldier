using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaBackend.DTO;
using TareaBackend.Entidades;
using TareaBackend.Servicios;

namespace TareaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaService db;
        private readonly IMapper mapper;

        public TareaController(ITareaService db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Prueba!!!";
        }

        [HttpPost("Registrar/Dron")]
        public async Task<IActionResult> RegistrarDron([FromBody] DronDTO dronDTO)
        {
            if (dronDTO == null)
                return BadRequest();

            var dron = mapper.Map<Dron>(dronDTO);

            await db.RegistrarDron(dron);

            return Created("Created", true);
        }

        [HttpGet("ComprobarNivelBateria/Dron/{DronId}")]
        public async Task<ActionResult> ComprobarNivelBateria(int DronId)
        {
            int nivelBateria = await db.ComprobarNivelBateria(DronId);

            return Ok(nivelBateria);
        }

        /// <summary>
        /// Cargar dron con medicamentos
        /// </summary>
        /// <param name="DronId"></param>
        /// <param name="MedicamentoId"></param>
        /// <param name="dronMedicamentoDTO"></param>
        /// <returns></returns>
        [HttpPost("CargarDronConMedicamentos/Dron/{DronId}/Medicamento/{MedicamentoId}")]
        public async Task<IActionResult> CargarDronConMedicamentos(int DronId, int MedicamentoId, [FromBody] DronMedicamentoDTO dronMedicamentoDTO)
        {
            if (dronMedicamentoDTO == null)
                return BadRequest();

            if (DronId == 0)
                return BadRequest();

            if (MedicamentoId == 0)
                return BadRequest();

            var dronMedicamentos = mapper.Map<DronMedicamento>(dronMedicamentoDTO);
            dronMedicamentos.Dron = await db.ObtenerDron(DronId);
            dronMedicamentos.Medicamento = await db.ObtenerMedicamento(MedicamentoId);

            await db.CargarDronMedicamento(dronMedicamentos);

            return Created("Created", true);
        }

        [HttpGet("Dron/{DronId}/Peso")]
        public async Task<IActionResult> ComprobarPesoDron(int DronId)
        {
            if (DronId == 0)
                return BadRequest();

            var pesoCargado = await db.ComprobarPesoMedicamentosCargados(DronId);

            return Ok(pesoCargado);
        }
    }
}

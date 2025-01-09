using Microsoft.AspNetCore.Mvc;
using Project.BL.DTOs;
using Project.BL.Services.Abstractions;
using Project.DAL.Entities;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {

        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }


        [HttpGet]
        public async Task<IActionResult> GetSeriaNumber(string seriaNumber)
        {
            Patient patient = await _patientService.GetPatientBySeriaNumber(seriaNumber);

            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PatientPostDTO patientPostDTO)
        {
            await _patientService.CreatePatientAsync(patientPostDTO);
            return Ok();
        }
    }
}

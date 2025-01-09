using Project.BL.DTOs;
using Project.DAL.Entities;

namespace Project.BL.Services.Abstractions;

public interface IPatientService
{
    Task<Patient> GetPatientBySeriaNumber(string seriaNumber);

    Task CreatePatientAsync(PatientPostDTO patientPostDTO);
}

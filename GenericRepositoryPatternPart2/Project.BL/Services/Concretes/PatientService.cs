using Project.DAL.Entities;
using Project.DAL.Repositories.Abstractions;

namespace Project.BL.Services.Concretes;

public class PatientService
{
    private readonly IReadRepository<Patient> _readRepository;

    public PatientService(IReadRepository<Patient> readRepository)
    {
        _readRepository = readRepository;
    }

    public async Task<Patient> GetPatientBySeriaNumber(string seriaNumber)
    {
        Patient? patient = await _readRepository.GetSingleByConditionAsync(e => e.SeriaNumber == seriaNumber);

        if (patient is null)
        {
            throw new Exception($"Patient not found with this seria number{seriaNumber}");
        }

        return patient;
    }
}

using AutoMapper;
using Project.BL.DTOs;
using Project.BL.Services.Abstractions;
using Project.DAL.Entities;
using Project.DAL.Repositories.Abstractions;

namespace Project.BL.Services.Concretes;

public class PatientService : IPatientService
{
    private readonly IPatientReadRepository _readRepository;
    private readonly IPatientWriteRepository _writeRepository;

    private readonly IMapper _mapper;

    public PatientService(IPatientReadRepository readRepository, IPatientWriteRepository writeRepository, IMapper mapper)
    {
        _readRepository = readRepository;
        _writeRepository = writeRepository;
        _mapper = mapper;
    }

    public async Task CreatePatientAsync(PatientPostDTO patientPostDTO)
    {
        Patient patient = _mapper.Map<Patient>(patientPostDTO);

        await _writeRepository.CreateAsync(patient);
        int rows = await _writeRepository.SaveChangeAsync();
        if (rows == 0)
        {
            throw new Exception("Something went wrong");
        }
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

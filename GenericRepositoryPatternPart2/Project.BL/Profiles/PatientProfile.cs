using AutoMapper;
using Project.BL.DTOs;
using Project.DAL.Entities;

namespace Project.BL.Profiles;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Patient, PatientPostDTO>().ReverseMap();
    }
}

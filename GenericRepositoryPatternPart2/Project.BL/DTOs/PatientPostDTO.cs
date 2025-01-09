using Project.DAL.Enums;

namespace Project.BL.DTOs;

public class PatientPostDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DOB { get; set; }
    public Gender Gender { get; set; }
    public BloodGroup BloodGroup { get; set; }
    public string PhoneNumber { get; set; }
    public string SeriaNumber { get; set; }
    public string RegistrationAddress { get; set; }
    public string CurrentAddress { get; set; }
    public int InsuranceId { get; set; }
    public string Email { get; set; }
}

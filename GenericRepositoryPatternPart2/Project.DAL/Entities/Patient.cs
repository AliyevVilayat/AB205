using Project.DAL.Entities.Common;
using Project.DAL.Enums;

namespace Project.DAL.Entities;

public class Patient : AuditableEntity
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
    public Insurance Insurance { get; set; }
    public string Email { get; set; }
}


public class Doctor : AuditableEntity
{
    //.....
}


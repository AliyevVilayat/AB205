using Project.DAL.Enums;

namespace Project.DAL.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
}


public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public string? CreatedBy { get; set; }

    public DateTime? UpdateAt { get; set; }
    public string? UpdateBy { get; set; }

    public DateTime? DeleteAt { get; set; }
    public string? DeleteBy { get; set; }
}

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

public class Insurance : BaseEntity
{
    public string PatientInsurance { get; set; }
    public ICollection<Patient> Patients { get; set; }

}


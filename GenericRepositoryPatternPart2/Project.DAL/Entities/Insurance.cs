using Project.DAL.Entities.Common;

namespace Project.DAL.Entities;

public class Insurance : BaseEntity
{
    public string PatientInsurance { get; set; }
    public ICollection<Patient> Patients { get; set; }

}


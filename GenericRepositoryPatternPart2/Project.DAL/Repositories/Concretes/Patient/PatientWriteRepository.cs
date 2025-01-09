using Project.DAL.Contexts;
using Project.DAL.Entities;
using Project.DAL.Repositories.Abstractions;

namespace Project.DAL.Repositories.Concretes;

public class PatientWriteRepository : WriteRepository<Patient>, IPatientWriteRepository
{
    public PatientWriteRepository(AppDbContext context) : base(context)
    {
    }

}


public class PatientReadRepository : ReadRepository<Patient>, IPatientReadRepository
{
    public PatientReadRepository(AppDbContext context) : base(context)
    {
    }
}

using Project.DAL.Contexts;
using Project.DAL.Entities;
using Project.DAL.Repositories.Abstractions;

namespace Project.DAL.Repositories.Concretes;

public class DoctorReadRepository : ReadRepository<Doctor>, IDoctorReadRepository
{
    public DoctorReadRepository(AppDbContext context) : base(context)
    {
    }
}


public class DoctorWriteRepository : WriteRepository<Doctor>, IDoctorWriteRepository
{
    public DoctorWriteRepository(AppDbContext context) : base(context)
    {
    }
}
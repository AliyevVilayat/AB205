using Project.DAL.Entities;

namespace Project.DAL.Repositories.Abstractions;

public interface IDoctorReadRepository : IReadRepository<Doctor>
{
}

public interface IDoctorWriteRepository : IWriteRepository<Doctor>
{
}

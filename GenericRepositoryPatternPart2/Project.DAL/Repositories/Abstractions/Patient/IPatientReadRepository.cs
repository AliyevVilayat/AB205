using Project.DAL.Entities;

namespace Project.DAL.Repositories.Abstractions;

public interface IPatientReadRepository : IReadRepository<Patient>
{

}

public interface IPatientWriteRepository : IWriteRepository<Patient>
{

}

using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Contexts;

namespace DE.Infrastructure.Repositories;

public class EmployeeRepository(DbContextApp context)
    : GenericRepository<Employee>(context),
        IEmployeeRepository { }

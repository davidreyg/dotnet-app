using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Contexts;

namespace DE.Infrastructure.Repositories;

public class FinancierRepository(DbContextApp context)
    : GenericRepository<Financier>(context),
        IFinancierRepository { }

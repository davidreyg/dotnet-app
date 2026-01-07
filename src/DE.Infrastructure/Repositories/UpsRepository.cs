using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Contexts;

namespace DE.Infrastructure.Repositories;

public class UpsRepository(DbContextApp context)
    : GenericRepository<Ups>(context),
        IUpsRepository { }

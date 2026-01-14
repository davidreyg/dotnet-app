using System;
using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Contexts;

namespace DE.Infrastructure.Repositories;

public class ProfessionalCouncilRepository(DbContextApp context)
    : GenericRepository<ProfessionalCouncil>(context),
        IProfessionalCouncilRepository { }

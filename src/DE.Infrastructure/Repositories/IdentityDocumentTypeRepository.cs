using DE.Application.DTOs.Response;
using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DE.Infrastructure.Repositories;

public class IdentityDocumentTypeRepository
    : GenericRepository<IdentityDocumentType>,
        IIdentityDocumentTypeRepository
{
    public IdentityDocumentTypeRepository(DbContextApp context)
        : base(context) { }

    public async Task<List<IdentityDocumentTypeSelectItemResponse>> GetSelectItem()
    {
        return await _context
            .IdentityDocumentType.Where(c => !c.IsDeleted)
            .Select(c => new IdentityDocumentTypeSelectItemResponse
            {
                Id = c.Id,
                Code = c.Code,
                Description = c.Description,
            })
            .OrderByDescending(c => c.Id)
            .ToListAsync();
    }
}

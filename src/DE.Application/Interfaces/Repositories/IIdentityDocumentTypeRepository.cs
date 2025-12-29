using DE.Application.DTOs.Response;
using DE.Domain.Entities;

namespace DE.Application.Interfaces.Repositories
{
    public interface IIdentityDocumentTypeRepository : IGenericRepository<IdentityDocumentType>
    {
        //Write
        //Task<Response<long>> CreateAsync(IdentityDocumentTypeRequest model);
        //Task<Response<long>> UpdateAsync(IdentityDocumentTypeRequest model, long id);
        //Task<Response<long>> DeleteAsync(long id);

        ////Read
        //Task<IdentityDocumentTypeByIdResponse?> GetByIdAsync(long id);
        //Task<IEnumerable<IdentityDocumentTypeResponse>> GetAllAsync();

        //aqui poner otros casos
        Task<List<IdentityDocumentTypeSelectItemResponse>> GetSelectItem();
    }
}

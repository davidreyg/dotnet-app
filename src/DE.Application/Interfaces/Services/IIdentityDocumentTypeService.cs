using DE.Application.Common;
using DE.Application.DTOs.Request;
using DE.Application.DTOs.Response;

namespace DE.Application.Interfaces.Services
{
    public interface IIdentityDocumentTypeService
    {
        //Write
        Task<Response<long>> CreateAsync(IdentityDocumentTypeRequest model);
        Task<Response<long>> UpdateAsync(IdentityDocumentTypeRequest model, long id);
        Task<Response<long>> DeleteAsync(long id);

        //Read
        Task<IdentityDocumentTypeByIdResponse?> GetByIdAsync(long id);
        Task<IEnumerable<IdentityDocumentTypeResponse>> GetAllAsync();
        Task<List<IdentityDocumentTypeSelectItemResponse>> GetSelectItem();
    }
}

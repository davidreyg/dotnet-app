using DE.Application.DTOs.Response;

namespace DE.Application.Interfaces.Services;

public interface IMedicalProcedureService
{
    //Write
    // Task<Response<long>> CreateAsync(UpsRequest model);
    // Task<Response<long>> UpdateAsync(UpsRequest model, long id);
    // Task<Response<long>> DeleteAsync(long id);

    // //Read
    // Task<UpsByIdResponse?> GetByIdAsync(long id);
    Task<IEnumerable<MedicalProcedureResponse>> GetAllAsync();
    // Task<List<UpsSelectItemResponse>> GetSelectItem();
}

using DE.Application.DTOs.Response;

namespace DE.Application.Interfaces.Services;

public interface IExtraConditionService
{
    //Write
    // Task<Response<long>> CreateAsync(HealthServiceUnitRequest model);
    // Task<Response<long>> UpdateAsync(HealthServiceUnitRequest model, long id);
    // Task<Response<long>> DeleteAsync(long id);

    // //Read
    // Task<HealthServiceUnitByIdResponse?> GetByIdAsync(long id);
    Task<IEnumerable<ExtraConditionResponse>> GetAllAsync();
    // Task<List<HealthServiceUnitSelectItemResponse>> GetSelectItem();
}

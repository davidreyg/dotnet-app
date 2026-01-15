using System;
using DE.Application.DTOs.Response;

namespace DE.Application.Interfaces.Services;

public interface IFinancierService
{
    //Write
    // Task<Response<long>> CreateAsync(HealthServiceUnitRequest model);
    // Task<Response<long>> UpdateAsync(HealthServiceUnitRequest model, long id);
    // Task<Response<long>> DeleteAsync(long id);

    // //Read
    // Task<HealthServiceUnitByIdResponse?> GetByIdAsync(long id);
    Task<IEnumerable<FinancierResponse>> GetAllAsync();
    // Task<List<HealthServiceUnitSelectItemResponse>> GetSelectItem();
}

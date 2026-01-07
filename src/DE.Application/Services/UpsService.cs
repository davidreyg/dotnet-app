using System;
using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services
{
    public class UpsService(IUnitOfWork uow) : IUpsService
    {
        private readonly IUnitOfWork _uow = uow;

        public async Task<IEnumerable<UpsResponse>> GetAllAsync()
        {
            var result = await _uow.UpsRepository.GetAllAsync();
            return result.Adapt<IEnumerable<UpsResponse>>();
        }
    }
}

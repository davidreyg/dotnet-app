using DE.Application.Common;
using DE.Application.DTOs.Request;
using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using DE.Domain.Entities;
using Mapster;

namespace DE.Application.Services
{
    public class IdentityDocumentTypeService : IIdentityDocumentTypeService
    {
        private readonly IUnitOfWork _uow;

        public IdentityDocumentTypeService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Response<long>> CreateAsync(IdentityDocumentTypeRequest model)
        {
            // request validation

            var entity = model.Adapt<IdentityDocumentType>();
            await _uow.IdentityDocumentTypes.AddAsync(entity);

            if (await _uow.SaveChangesAsync() == 0)
                return Response<long>.Failure(MessageConstant.MESSAGE_FAILED);

            return Response<long>.Success(entity.Id, MessageConstant.MESSAGE_SAVE_SUCCESS);
        }

        public async Task<Response<long>> DeleteAsync(long id)
        {
            var entity = await _uow.IdentityDocumentTypes.GetByIdAsync(id);

            if (entity is null)
                return Response<long>.Failure(MessageConstant.MESSAGE_FAILED);

            entity.IsDeleted = true;

            if (await _uow.SaveChangesAsync() == 0)
                return Response<long>.Failure(MessageConstant.MESSAGE_FAILED);

            return Response<long>.Success(entity.Id, MessageConstant.MESSAGE_DELETE_SUCCESS);
        }

        public async Task<IEnumerable<IdentityDocumentTypeResponse>> GetAllAsync()
        {
            var result = await _uow.IdentityDocumentTypes.GetAllAsync();
            return result.Adapt<IEnumerable<IdentityDocumentTypeResponse>>();
        }

        public async Task<IdentityDocumentTypeByIdResponse?> GetByIdAsync(long id)
        {
            var result = await _uow.IdentityDocumentTypes.GetByIdAsync(id);
            return result.Adapt<IdentityDocumentTypeByIdResponse?>();
        }

        public async Task<List<IdentityDocumentTypeSelectItemResponse>> GetSelectItem()
        {
            return await _uow.IdentityDocumentTypes.GetSelectItem();
        }

        public async Task<Response<long>> UpdateAsync(IdentityDocumentTypeRequest model, long id)
        {
            var entity = await _uow.IdentityDocumentTypes.GetByIdAsync(id);
            if (entity is null)
                return Response<long>.Failure(MessageConstant.MESSAGE_FAILED);

            entity.Code = model.Code;
            entity.Description = model.Description;
            entity.Status = model.Status;

            // 6. Save
            //var saved = await _context.SaveChangesAsync();
            _uow.IdentityDocumentTypes.Update(entity);
            if (await _uow.SaveChangesAsync() == 0)
                return Response<long>.Failure(MessageConstant.MESSAGE_FAILED);

            return Response<long>.Success(entity.Id, MessageConstant.MESSAGE_UPDATE_SUCCESS);
        }
    }
}

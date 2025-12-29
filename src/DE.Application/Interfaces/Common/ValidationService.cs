using DE.Application.Common;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DE.Application.Interfaces.Common
{
    public interface IValidationService
    {
        Task<Response<T>> ValidateAsync<T>(T model);
    }

    public class ValidationService : IValidationService
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<Response<T>> ValidateAsync<T>(T model)
        {
            var validator = _serviceProvider.GetService<IValidator<T>>();

            if (validator is null)
                return Response<T>.Failure(
                    new List<string> { $"No validator found for {typeof(T).Name}" }
                );

            var result = await validator.ValidateAsync(model);

            if (!result.IsValid)
            {
                var errors = result.Errors.Select(e => e.ErrorMessage).ToList();
                return Response<T>.Failure(errors);
            }

            return Response<T>.Success(model);
        }
    }
}

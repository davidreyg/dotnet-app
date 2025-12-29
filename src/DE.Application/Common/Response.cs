namespace DE.Application.Common
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }

        public Response(bool isSuccess, string message, T data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        // Nuevo constructor para errores
        public Response(bool isSuccess, string message, T data, List<string> errors)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            Errors = errors;
        }

        public static Response<T> Success(
            T payload,
            string message = MessageConstant.MESSAGE_SUCCESS
        )
        {
            return new Response<T>(true, message, payload);
        }

        public static Response<T> Failure(string message = MessageConstant.MESSAGE_ERROR)
        {
            return new Response<T>(false, message, default!);
        }

        public static Response<T> Failure(
            List<string> errors,
            string message = MessageConstant.MESSAGE_ERROR
        )
        {
            return new Response<T>(false, message, default!, errors);
        }
    }
}

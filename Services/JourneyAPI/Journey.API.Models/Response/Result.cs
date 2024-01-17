
namespace Journey.API.Models.Response
{
    public class Result<T>
    {
        public Result(T data, bool isError, List<string> errorMessages)
        {
            Data = data;
            IsError = isError;
            ErrorMessages = errorMessages;
        }

        public Result(T data)
        {
            Data = data;
            IsError = false;
        }

        public Result()
        {
            IsError = false;
        }

        public T Data { get; set; }

        public bool IsError { get; set; }

        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}

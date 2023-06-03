namespace PaymentSystem.Core.ResponseModel
{
    public class Response<T>
    {
        public T Data { get; set; } 
        public bool Status { get; set; }
        public int statusCode { get; set; }
        public List<string> errors { get; set; } = new List<string>();
        public Response<T> Success(T data)
        {
            return new Response<T> { Data = data, Status = true, statusCode = 200 };
        }
        public Response<T> Success()
        {
            return new Response<T> { Status = true, statusCode = 200 };
        }
        public Response<T> Fail(List<string> errormessages)
        {
            return new Response<T> { Data = default, errors = errormessages, statusCode = 400, Status = false };
        }
        public Response<T> Fail(string errors)
        {
            var error = new List<string>();
            error.Add(errors);
            return new Response<T> { statusCode = 400, Data = default, errors = error, Status = false };
        }
    }
}

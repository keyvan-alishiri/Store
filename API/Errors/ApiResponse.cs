namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode ,string message = null )
        {
            this.StatusCode = statusCode;
            this.Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }


        public string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request,you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors ara the path to dark side,Errors lead to anger, anger leads to hate. hate leads to career change",
                _ => null,

            };
        }

    }
}
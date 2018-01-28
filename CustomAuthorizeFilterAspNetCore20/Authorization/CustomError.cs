namespace CustomAuthorizeFilterAspNetCore20.Authorization
{
    public class CustomError
    {
        public string Error { get; }

        public CustomError(string message)
        {
            Error = message;
        }
    }
}
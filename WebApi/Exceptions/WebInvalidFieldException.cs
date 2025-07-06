namespace WebApi.Exceptions
{
    public class WebInvalidFieldException : WebExceptionModel
    {
        public WebInvalidFieldException(string field, string content)
        {
            Content = content;
            Field = field;
        }
    }
}
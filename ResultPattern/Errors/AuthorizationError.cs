namespace ResultPattern.Errors;

internal sealed class AuthorizationError : Error
{
    public AuthorizationError(string code = "Error.Authorization",
                           string description = "An error occured during authorization!") 
        : base(code, description, ErrorType.Authorization)
    {
    }
}
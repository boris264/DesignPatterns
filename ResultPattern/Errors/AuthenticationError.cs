namespace ResultPattern.Errors;

internal sealed class AuthenticationError : Error
{
    public AuthenticationError(string code,
                               string description)
        : base(code, description, ErrorType.Authentication)
    {
    }
}

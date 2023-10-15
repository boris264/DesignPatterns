namespace ResultPattern.Errors;

internal sealed class UnexpectedError : Error
{
    public UnexpectedError(string code = "Error.Unexpected", 
                           string description = "An unexpected error has occured!") 
        : base(code, description, ErrorType.Unexpected)
    {
    }
}

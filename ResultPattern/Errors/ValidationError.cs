namespace ResultPattern.Errors;

internal sealed class ValidationError : Error
{
    public ValidationError(string code = "Error.Validation",
                           string description = "An error occured during validation!") 
        : base(code, description, ErrorType.Validation)
    {
    }
}

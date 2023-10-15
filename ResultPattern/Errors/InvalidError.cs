namespace ResultPattern.Errors;

internal sealed class InvalidError : Error
{
    public InvalidError(string code = "Error.Invalid",
                        string description = "An error has occured!")
        : base(code, description, ErrorType.Invalid)
    {
    }
}

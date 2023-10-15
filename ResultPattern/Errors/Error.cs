namespace ResultPattern.Errors;

public abstract class Error
{
    public string Code { get; init; }

    public string Description { get; init; }

    public ErrorType ErrorType { get; init; }

    protected Error(string code,
                  string description,
                  ErrorType errorType)
    {
        Code = code;
        Description = description;
        ErrorType = errorType;
    }

    public override string ToString()
    {
        return $"Type: {ErrorType}, Code: {Code}, Description: {Description}";
    }

    public static Error Validation(string code = "Error.Validation",
                                   string description = "An error occured during validation!")
    {
        return new ValidationError(code, description);
    }

    public static Error Authorization(string code = "Error.Authorization",
                                      string description = "An error occured during authorization!")
    {
        return new AuthorizationError(code, description);
    }

    public static Error Authentication(string code = "Error.Authentication",
                                       string description = "An error occured during authentication!")
    {
        return new AuthenticationError(code, description);
    }

    public static Error Unexpected(string code = "Error.Unexpected",
                                   string description = "An unexpected error has occured!")
    {
        return new UnexpectedError(code, description);
    }

    public static Error Invalid(string code = "Error.Invalid",
                                string description = "An error has occured!")
    {
        return new InvalidError(code, description);
    }
}
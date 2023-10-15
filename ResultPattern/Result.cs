using System.Collections.Generic;
using System.Linq;
using ResultPattern.Errors;

namespace ResultPattern;

public sealed class Result
{
    public bool IsSuccessful { get; private set; } = false;

    public IList<Error> Errors { get; private set; }
         = new List<Error>();

    private Result(bool isSuccessful = false)
    {
        IsSuccessful = isSuccessful;
    }

    public Error? First()
    {
        return Errors.FirstOrDefault();
    }

    public static implicit operator Result(Error error)
    {
        return Failure(error);
    }

    public static Result Success()
    {
        return new Result(true);
    }

    public static Result Failure(IEnumerable<Error> errors)
    {
        Result result = new();

        foreach (var error in errors)
        {
            result.Errors.Add(error);
        }

        return result;
    }

    public static Result Failure(Error error)
    {
        Result result = new();
        result.Errors.Add(error);
        
        return result;
    }
}
namespace NullObjectPattern;

public class NullUser : User
{
    public NullUser()
        : base(-1, "Guest")
    {
    }

    public override bool HasAccess()
    {
        return false;
    }
}

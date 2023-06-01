namespace ORMLib.MSSql;

using Providers;
public class MSSqlProvider :  IAccessProviders
{
    public Access Provide()
        => new SqlAccess();
} 
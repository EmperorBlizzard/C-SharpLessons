using System.Text.RegularExpressions;

namespace _02_Structs.Structs.Domain_Driven_Design;

internal struct Password
{
    private readonly string _value;

    public Password(string value)
    {
        if (!Regex.IsMatch(value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,16}$"))
            this._value = value;
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models;

public class BirthDateRangeAttribute : ValidationAttribute
{
    private readonly DateTime _min;
    private readonly DateTime _max;

    public BirthDateRangeAttribute(string min, string max)
    {
        _min = DateTime.Parse(min, System.Globalization.CultureInfo.InvariantCulture);
        _max = DateTime.Parse(max, System.Globalization.CultureInfo.InvariantCulture);
    }

    public override bool IsValid(object? value)
    {
        if (value is DateTime d)
            return d >= _min && d <= _max;
        return false;
    }
}
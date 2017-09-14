using System;
using System.Globalization;
using EcoCityUser.Abstractions;

namespace EcoCityUser.Models
{
    public class DateTimeObject : UserInputObject<string>
    {
        public DateTimeObject()
        {
            Type = "String";
            Value = DateTime.UtcNow.ToString(CultureInfo.CurrentCulture);
        }
    }
}

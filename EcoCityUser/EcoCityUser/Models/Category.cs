using EcoCityUser.Abstractions;

namespace EcoCityUser.Models
{
    public class Category : UserInputObject<string>
    {
        public Category()
        {
            Type = "String";
        }
    }
}

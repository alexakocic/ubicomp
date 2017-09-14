using EcoCityUser.Abstractions;

namespace EcoCityUser.Models
{
    public class Description : UserInputObject<string>
    {
        public Description()
        {
            Type = "String";
        }
    }
}

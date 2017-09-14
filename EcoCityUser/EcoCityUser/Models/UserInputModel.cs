using System.Runtime.Serialization;
using EcoCityUser.Properties;

namespace EcoCityUser.Models
{
    [DataContract]
    public class UserInputModel
    {
        public UserInputModel()
        {
            Type = "UserInput";
            Id = $"user-input-{Settings.Default.UserInputId}";
            Latitude = new Latitude();
            Longitude = new Longitude();
            DateTimeObject = new DateTimeObject();
        }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; private set; }


        [DataMember(Name = "category")]
        public Category Category { get; set; }

        [DataMember(Name = "latitude")]
        public Latitude Latitude { get;  set; }

        [DataMember(Name = "longitude")]
        public Longitude Longitude { get; private set; }

        [DataMember(Name = "date_time")]
        public DateTimeObject DateTimeObject { get; private set; }

        [DataMember(Name = "description")]
        public Description Description { get; set; }

    }
}

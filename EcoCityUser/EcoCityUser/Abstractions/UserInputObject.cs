using System.Runtime.Serialization;
using EcoCityUser.Models;
using Newtonsoft.Json;

namespace EcoCityUser.Abstractions
{
    public class UserInputObject<T>
    {
        public UserInputObject()
        {
            Metadata = new Metadata();
        }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "value")]
        public T Value { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

    }
}

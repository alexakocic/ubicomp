using System;
using EcoCityUser.Abstractions;

namespace EcoCityUser.Models
{
    public class Latitude : UserInputObject<float>
    {
        private float _initLat;
        public Latitude()
        {
            _initLat = 43.31f;
            Value = GenerateLatitude();

            Type = "Float";
        }

        private float GenerateLatitude()
        {
            var random = new Random(DateTime.UtcNow.Millisecond);
            _initLat += (float)random.NextDouble() / 100;

            return _initLat;
        }
    }
}

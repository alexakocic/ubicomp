using System;
using EcoCityUser.Abstractions;

namespace EcoCityUser.Models
{
    public class Longitude : UserInputObject<float>
    {
        private float _initLong;
        public Longitude()
        {
            Type = "Float";
            _initLong = 21.89f;

            Value = GenerateLongitude();
        }

        private float GenerateLongitude()
        {
            var random = new Random(1);
            _initLong += (float)random.NextDouble() / 100;

            return _initLong;
        }
    }
}

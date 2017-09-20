using System;
using System.Net.Http;

namespace EcoCityCsv
{
    public class HttpHelper
    {
        private HttpClient _client;

        public async void PostSensorData(string textPlain, string fileName)
        {
            _client = new HttpClient();
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(string.Format(Settings.Default.ApiURL, fileName)),
                Method = HttpMethod.Post,
                Content = new StringContent(textPlain)
            };

            request.Headers.Add("Fiware-Service", "ecocity");
            request.Headers.Add("Fiware-ServicePath", "/");


            var task = _client.SendAsync(request);

            var responseMessage = await task;

            Console.WriteLine($"Result message {responseMessage}");
        }
    }
}

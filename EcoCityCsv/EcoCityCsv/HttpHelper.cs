using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace EcoCityCsv
{
    public class HttpHelper
    {
        public HttpClient client;

        public HttpClient GetHttpClient()
        {
            var httpClient = new HttpClient { BaseAddress = new Uri("http://192.168.0.107:7896") };

            // clear default request headers
            httpClient.DefaultRequestHeaders.Accept.Clear();

            // accept json response
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // set timeout to 30 secs
            httpClient.Timeout = TimeSpan.FromSeconds(30);

            // add unique request id
            httpClient.DefaultRequestHeaders.Add("X-Request-ID", Guid.NewGuid().ToString());

            return httpClient;
        }

        public async void PostSensorData(string textPlain, string fileName)
        {
            client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri($"http://192.168.0.107:7896/iot/d?k=sensorinputkey&i={fileName}"),
                Method = HttpMethod.Post
            };

            request.Content = new StringContent(textPlain);
            request.Headers.Add("Fiware-Service", "EcoCity");
            request.Headers.Add("Fiware-ServicePath", "/");


            var task = client.SendAsync(request);

            var responseMessage = await task;

            Console.WriteLine($"Result message {responseMessage}");
        }
    }
}

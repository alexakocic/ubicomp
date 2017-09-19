using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EcoCityUser.Models;
using EcoCityUser.Properties;
using Newtonsoft.Json;

namespace EcoCityUser
{
    public class HttpHelper
    {
        public HttpClient client;

        public HttpClient GetHttpClient()
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(Settings.Default.ServerURL) };

            // set server base address

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

        public async Task<HttpResponseMessage> PostSensorData(UserInputModel userInputModel)
        {
            try
            {
                client = new HttpClient();
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri($"{Settings.Default.ServerURL}{Settings.Default.EntitiesApi}"),
                    Method = HttpMethod.Post
                };

                var json = JsonConvert.SerializeObject(userInputModel);

                Console.WriteLine($"Sent message {json}");


                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                request.Headers.Add("Fiware-Service", "ecocity");
                request.Headers.Add("Fiware-ServicePath", "/");

                Console.WriteLine($"Api: {request.RequestUri}");

                var responseMessage = await client.SendAsync(request);


                Console.WriteLine($"Result message {responseMessage}");
                Console.WriteLine($"Result status {responseMessage.StatusCode}");
                return responseMessage;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Timeout occured");
            }

            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }
    }
}

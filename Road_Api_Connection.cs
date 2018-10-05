using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using TFL.BAL;
using TFL.DAL;
using Xunit;

namespace TFLTest
{
    public class Road_Api_Connection
    {
        [Fact]
        public async Task Road_Api_Successful_Connection()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                RequestUri =
                    new Uri("https://api.tfl.gov.uk/Road/A2?app_id=34fb22c2&app_key=42cce35a3247e235fdf4d90aa90b7fe6"),
                Method = HttpMethod.Get
            };

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = client.SendAsync(request).Result)
            {
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}

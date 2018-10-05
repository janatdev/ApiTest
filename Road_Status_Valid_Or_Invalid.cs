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
    public class Road_Status_Valid_Or_Invalid
    {
        [Fact]
        public static void GotExpectedEvent()
        {

            var mock = new Mock<IConsumeAsyncTfl>();
            var result = mock
                .Setup(s => s.RoadStatusCheckTask());
             Assert.NotNull(result);  
        }
    }
}

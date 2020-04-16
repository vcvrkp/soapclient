using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using SayHello;

namespace MyCompany.SteeltoeExample.Controllers
{
    [Route("api/soap")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        [HttpGet]
        public async Task test([FromQuery] string value)
        {
            Hello_PortTypeClient client = new Hello_PortTypeClient();
            Console.WriteLine($"Got value as {value}");
            sayHelloResponse sayHelloResponse = await client.sayHelloAsync(value);
            Console.WriteLine($"Greeting recieved is {sayHelloResponse.greeting}");
        }

    }
}

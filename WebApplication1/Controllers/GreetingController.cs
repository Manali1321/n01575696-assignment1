using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {

        ///<summary>
        ///Message with post method
        ///</summary>
        ///<return>show the greeting message with post</return>
        ///<example>
        ///post: /api/greeting        ->Hello World
        ///</example>

        [HttpPost]
        public string WelcomeMessage()

        {
            string message = "Hello World";
            return message;


        }

        ///<summary>
        ///greeting message for id
        ///</summary>
        /// <param name="id">number of people to greeting</param>
        ///<return>show the message for number of people</return>
        ///<example>
        ///GET: /api/greeting/3        -> Greeting to 3 people!
        ///</example>
        ///<example>
        ///GET: /api/greeting/6        -> Greeting to 6 people!
        ///</example>
        ///<example>
        ///GET: /api/greeting/0        -> Greeting to 0 people!
        ///</example>

        ///get: api/greeting/{id}
        
        [HttpGet]
        [Route("api/Greeting/{ID}")]
        public string WelcomeMessage(int id)

        {
            string message = $"Greetings to {id} people!";
            return message;


        }
    }
}

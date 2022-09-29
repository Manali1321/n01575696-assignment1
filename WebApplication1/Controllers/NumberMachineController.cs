using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {

        ///<summary>
        ///Calculation with different math operation.
        ///</summary>
        ///<param name="id">input INT number</param>
        ///<return>show the int number in result after BADMAS</return>
        ///<example>
        ///GET: /api/NumberMachine/10       ->    0
        ///</example>
        ///<example>
        ///GET: /api/NumberMachine/-5       ->   -7
        ///</example>
        ///<example>
        ///GET: /api/NumberMachine/30       ->   10
        ///</example>

        ///GET: /api/NumberMachine/{id}
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public double BADMAS(int id)
        {
            double BADMAS = id / 2 * 1 + 5 - 10;
            return BADMAS;
        }

    }
}

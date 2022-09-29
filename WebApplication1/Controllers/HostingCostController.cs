using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {
        ///<summary>
        ///calculating cost per fortnight.
        ///</summary>
        ///<param name="id">Number of days which has elapsed since the beginning of the hosting</param>
        ///<return>when you put number of fortnight result will show the total cost with breakdown with charge, HST and with HST total cost. </return>
        ///<example>
        ///GET: /api/HostingCost/0	     -> 1 fortnights at $5.50 / FN = $5.5 CAD HST 13 % = $0.715 CAD Total = $6.215 CAD
        ///</example>
        ///<example>
        ///GET: /api//HostingCost/14	     -> 2 fortnights at $5.50 / FN = $11 CAD HST 13 % = $1.43 CAD Total = $12.43 CAD
        ///</example>
        ///<example>
        ///GET: /api/HostingCost/15	     -> 2 fortnights at $5.50 / FN = $11 CAD HST 13 % = $1.43 CAD Total = $12.43 CAD
        ///</example>
        ///<example>
        ///GET: /api/HostingCost/21	     -> 2 fortnights at $5.50 / FN = $11 CAD HST 13 % = $1.43 CAD Total = $12.43 CAD
        ///</example>
        ///<example>
        ///GET: /api/HostingCost/28	    -> 3 fortnights at $5.50 / FN = $16.5 CAD HST 13 % = $2.145 CAD Total = $18.645 CAD
        ///</example>

        ///GET: /api/HostingCost/{id}
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string costfortnight(int id)
        {


            int fortNight = id/14 + 1; 
           double chargepernight=  (fortNight*5.50);
            double taxes = chargepernight*0.13;
            double totalcost = chargepernight +taxes;

          string message=  fortNight.ToString() + " fortnights at $5.50 / FN = $"+ chargepernight.ToString() + " CAD HST 13 % = $" +taxes.ToString() +" CAD  Total = $"+totalcost.ToString()  + " CAD";
                return message;

        }

    }
} 
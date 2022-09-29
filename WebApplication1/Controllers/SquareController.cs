using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// square input number
        /// </summary>
        /// <param name="id">input INT number</param>
        /// <returns> square of the input number</returns>
        ///<example>
        ///GET: /api/square/2       ->   4
        ///</example>
        /// ///<example>
        ///GET: /api/square/-2       ->   4
        ///</example>
        /// ///<example>
        ///GET: /api/square/10       ->   100
        ///</example>
        /// GET: /api/square/{id}

        [HttpGet]
        [Route("api/Square/{ID}")]
        public int Get(int id)
        {
            return (id * id);
        }
    
    
    }

}

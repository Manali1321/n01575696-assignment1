using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 
namespace WebApplication1.Controllers
{
    public class AddtenController : ApiController
    {
        /// <summary>
        /// add ten from input number
        /// </summary>
        /// <param name="id">input number add ten</param>
        /// <returns>get number with added ten</returns>
        ///<example>
        ///GET: /api/AddTen/21       ->   31
        ///</example>
        ///<example>
        ///GET: /api/AddTen/0       ->   10
        ///</example>
        ///<example>
        ///GET: /api/AddTen/-9       ->   1
        ///</example>
        ///GET: /api/AddTen/{id}

        [HttpGet]
        [Route("api/AddTen/{ID}")]
        public int get(int id)
        {
            return (id + 10);
        }

    }
}

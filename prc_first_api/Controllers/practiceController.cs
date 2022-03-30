using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prc_first_api.Controllers
{
    public class practiceController : ApiController
    {
      
        [HttpGet]
        [Route("my/mypage")]
        public List<string> ab()
        {
            List<string> jh = new List<string>();
            jh.Add("prakash");
                return jh;


        }
    }
}
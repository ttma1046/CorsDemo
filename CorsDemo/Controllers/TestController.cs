using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CorsDemo.Controllers
{

    [DisableCors]
    public class TestController : ApiController
    {
        [EnableCors(origins: "http://www.example.com", headers: "*", methods: "*")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("GET: Test message")
            };
        }

        [DisableCors]
        public HttpResponseMessage Post()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("POST: Test message")
            };
        }

        [EnableCors(origins: "http://www.contoso.com,http://www.example.com", headers: "*", methods: "*")]
        public HttpResponseMessage Put()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("PUT: Test message")
            };
        }
    }
}

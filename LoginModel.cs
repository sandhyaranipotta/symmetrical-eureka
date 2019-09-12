using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace JWTTokenCreation.Models
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
   
    public class LoginResponse
        {
            //public LoginResponse()
            //{

            //    this.Token = "";
            //    this.responseMessage = new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.Unauthorized };
            //}

            public string Token { get; set; }
            public HttpResponseMessage responseMessage { get; set; }

        }

    }

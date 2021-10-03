using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OnionContactManagementSolution.WebAPI.Exception
{
    public class HttpStatusCodeException : System.Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ContentType { get; set; } = @"text/plain";
        public string Message { get; set; }

        public HttpStatusCodeException(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCodeException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCodeException(HttpStatusCode statusCode, System.Exception inner)
            : this(statusCode, inner.ToString()) { }

        public HttpStatusCodeException(HttpStatusCode statusCode, JObject errorObject)
            : this(statusCode, errorObject.ToString())
        {
            this.ContentType = @"application/json";
        }

    }
}

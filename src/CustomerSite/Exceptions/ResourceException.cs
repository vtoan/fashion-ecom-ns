using System;
using System.Net;

namespace CustomerSite.Exceptions
{
    public class ResourceException : Exception
    {
        const string erroMessage = "Resource - ";
        public ResourceException(HttpStatusCode statusCode, string msg = "")
            : base(erroMessage + (int)statusCode + " " + statusCode.ToString() + " " + msg)
        { }
    }
}
using System;

namespace CustomerSite.Exceptions
{
    public class ServeNotAvaiableException : Exception
    {
        const string erroMessage = "Can't connect to server.";
        public ServeNotAvaiableException() : base(erroMessage)
        {
        }
    }
}
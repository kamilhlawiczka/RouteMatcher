using System;

namespace RouteMatcher.HereComClient
{
    public class ClientException : Exception
    {
        public ClientException(string message) : base(message)
        {
        }
    }
}
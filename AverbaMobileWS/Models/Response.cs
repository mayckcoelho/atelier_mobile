using System;

namespace AtelierMobileWS.Models
{
    public class Response
    {
        public Response(string result, string message, object data = null)
        {
            this.result = result;
            this.message = message;
            this.data = data;
        }

        public string result { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}

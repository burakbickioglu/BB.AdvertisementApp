using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB.AdvertisementApp.Common;

namespace BB.AdvertisementApp.Core
{
    public class Response : IResponse
    {
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }

        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public Response(ResponseType responseType, string message) : this(responseType)
        {
            Message = message;
        }


    }

    public enum ResponseType
    {
        Success,
        ValidationError,
        NotFound
    }
}

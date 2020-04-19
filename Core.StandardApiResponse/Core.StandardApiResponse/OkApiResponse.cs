using System.Net;

namespace Core.StandardApiResponse
{
    public class OkApiResponse : ApiResponse
    {
        public object Result { get; set; }

        public OkApiResponse(object result, string title = null)
            : base((int)HttpStatusCode.OK, title)
        {
            Result = result;
        }
    }
}

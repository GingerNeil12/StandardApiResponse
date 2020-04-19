using System.Net;

namespace Core.StandardApiResponse
{
    public class UnauthorizedApiResponse : ApiResponse
    {
        public UnauthorizedApiResponse(string title = null)
            : base((int)HttpStatusCode.Unauthorized, title)
        {

        }
    }
}

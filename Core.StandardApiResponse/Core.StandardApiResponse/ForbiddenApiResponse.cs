using System.Net;

namespace Core.StandardApiResponse
{
    public class ForbiddenApiResponse : ApiResponse
    {
        public ForbiddenApiResponse(string title = null)
            : base((int)HttpStatusCode.Forbidden, title)
        {

        }
    }
}

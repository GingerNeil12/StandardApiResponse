using System.Net;

namespace Core.StandardApiResponse
{
    public class InternalServerErrorApiResponse : ApiResponse
    {
        public InternalServerErrorApiResponse(string title = null)
            : base((int)HttpStatusCode.InternalServerError, title)
        {

        }
    }
}

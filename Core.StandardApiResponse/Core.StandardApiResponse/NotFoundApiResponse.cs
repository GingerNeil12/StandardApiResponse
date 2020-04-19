using System.Net;

namespace Core.StandardApiResponse
{
    public class NotFoundApiResponse : ApiResponse
    {
        public object Id { get; set; }

        public NotFoundApiResponse(object id, string title = null)
            : base((int)HttpStatusCode.NotFound, title)
        {
            Id = id;
        }
    }
}

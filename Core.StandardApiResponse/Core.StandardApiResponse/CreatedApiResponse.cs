using System.Net;

namespace Core.StandardApiResponse
{
    public class CreatedApiResponse : ApiResponse
    {
        public object Id { get; set; }

        public CreatedApiResponse(object id, string title = null)
            : base((int)HttpStatusCode.Created, title)
        {
            Id = id;
        }
    }
}

using System;
using System.Net;

namespace Core.StandardApiResponse
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public DateTime RequestDate => DateTime.Now;

        public ApiResponse(int status, string title = null)
        {
            Status = status;
            Title = title ?? GetDefaultTitleForStatus(status);
        }

        private static string GetDefaultTitleForStatus(int status)
        {
            switch (status)
            {
                case (int)HttpStatusCode.OK:
                    return "Request completed successfully.";
                case (int)HttpStatusCode.Created:
                    return "Resource Created.";
                case (int)HttpStatusCode.BadRequest:
                    return "One or more validation errors occured.";
                case (int)HttpStatusCode.Unauthorized:
                    return "Access to the requested resource is Unauthorized.";
                case (int)HttpStatusCode.Forbidden:
                    return "Access to the requested resource is Forbidden.";
                case (int)HttpStatusCode.NotFound:
                    return "Requested resource not found.";
                case (int)HttpStatusCode.InternalServerError:
                    return "An unhandled error has occured.";
                default:
                    return "Default Title.";
            }
        }
    }
}

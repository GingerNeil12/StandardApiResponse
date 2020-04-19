using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Core.StandardApiResponse
{
    public class BadRequestApiResponse : ApiResponse
    {
        public object Errors { get; set; }

        public BadRequestApiResponse(ModelStateDictionary modelState, string title = null)
            : base((int)HttpStatusCode.BadRequest, title)
        {
            var errors = new Dictionary<string, IEnumerable<string>>();
            foreach (var error in modelState)
            {
                var key = error.Key;
                var value = error.Value.Errors.Select(x => x.ErrorMessage);
                errors.Add(key, value);
            }
            Errors = errors;
        }

        public BadRequestApiResponse(object errors, string title = null)
            : base((int)HttpStatusCode.BadRequest, title)
        {
            Errors = errors;
        }
    }
}

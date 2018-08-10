using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ListingsController : JsonApiController<Listing>
    {
        public ListingsController(IJsonApiContext jsonApiContext,
                                 IResourceService<Listing> resourceService,
                                 ILoggerFactory loggerFactory) 
            : base(jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class LocationsController : JsonApiController<Location>
    {
        public LocationsController(IJsonApiContext jsonApiContext,
                                   IResourceService<Location> resourceService,
                                   ILoggerFactory loggerFactory) 
            : base(jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class OfficesController : JsonApiController<Office>
    {
        public OfficesController(IJsonApiContext jsonApiContext,
                                 IResourceService<Office> resourceService,
                                 ILoggerFactory loggerFactory) 
            : base(jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
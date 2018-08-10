using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AgentsController : JsonApiController<Agent>
    {
        public AgentsController(IJsonApiContext jsonApiContext,
                                IResourceService<Agent> resourceService,
                                ILoggerFactory loggerFactory) 
            : base(jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
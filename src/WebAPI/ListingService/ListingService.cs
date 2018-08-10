using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Internal;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI
{
    public class ListingService : IResourceService<Listing>
    {
        private readonly IJsonApiContext _jsonApiContext;
        private readonly ILogger _logger;

        public ListingService(IJsonApiContext jsonApiContext,
                ILoggerFactory loggerFactory)
        {
            _jsonApiContext = jsonApiContext;
            _logger = loggerFactory.CreateLogger<ListingService>();
        }

        private static IEnumerable<Agent> Agents => new[]
        {
            new Agent
            {
                Id = 1,
                Name = "Bob Cobb",
                Email = "bob@cobb.com"
            },
            new Agent
            {
                Id = 2,
                Name = "Art Vandelay",
                Email = "art@vandelay.com"
            },
            new Agent
            {
                Id = 3,
                Name = "Todd Gack",
                Email = "todd@gack.com"
            }
        };

        private static IEnumerable<Listing> Listings => new[]
        {
            new Listing
            {
                Id = 1,
                Title = "Awesome 2 bedder close to schools",
                Price = "$150,000",
                Agents = Agents.Take(2).ToList()
            },
            new Listing
            {
                Id = 2,
                Title = "Beachfront mansion",
                Price = "$1,000,000",
                Agents = new[]
                {
                    Agents.Last()
                }
            },
            new Listing
            {
                Id = 3,
                Title = "Dream apartment",
                Price = "$270,000"
            }
        };

        public Task<Listing> CreateAsync(Listing entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Listing>> GetAsync()
        {
            return Task.FromResult(Listings);
        }

        public Task<Listing> GetAsync(int id)
        {
            return Task.FromResult(Listings.SingleOrDefault(listing => listing.Id == id));
        }

        public async Task<object> GetRelationshipAsync(int id, string relationshipName)
        {
            var listing = await GetAsync(id);
            
            if (listing == null)
            {
                throw new JsonApiException(404, $"Relationship '{relationshipName}' not found.");
            }
           

            // compound-property -> CompoundProperty
            var navigationPropertyName = _jsonApiContext.ContextGraph.GetRelationshipName<Listing>(relationshipName);
            if (navigationPropertyName == null)
                throw new JsonApiException(422, $"Relationship '{relationshipName}' does not exist on resource '{typeof(Listing)}'.");

            var relationshipValue = _jsonApiContext.ContextGraph.GetRelationship(listing, navigationPropertyName);
            return relationshipValue;
        }

        public Task<object> GetRelationshipsAsync(int id, string relationshipName) => GetRelationshipAsync(id, relationshipName);

        public Task<Listing> UpdateAsync(int id, Listing entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateRelationshipsAsync(int id, string relationshipName, List<DocumentData> relationships)
        {
            throw new System.NotImplementedException();
        }
    }
}

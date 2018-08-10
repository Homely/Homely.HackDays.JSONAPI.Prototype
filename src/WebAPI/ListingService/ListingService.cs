using System.Collections.Generic;
using System.Threading.Tasks;
using JsonApiDotNetCore.Internal;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI
{
    public class ListingService : IResourceService<Listing>
    {
        private readonly IJsonApiContext _jsonApiContext;
        private readonly ILogger _logger;
        private readonly FakeListingRepository _repository;

        public ListingService(IJsonApiContext jsonApiContext,
                ILoggerFactory loggerFactory)
        {
            _jsonApiContext = jsonApiContext;
            _logger = loggerFactory.CreateLogger<ListingService>();
            _repository = new FakeListingRepository();
        }

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
            return Task.FromResult(_repository.Get());
        }

        public Task<Listing> GetAsync(int id)
        {
            return Task.FromResult(_repository.Get(id));
        }

        public async Task<object> GetRelationshipAsync(int id, string relationshipName)
        {
            var listing = await GetAsync(id);
            
            if (listing == null)
            {
                throw new JsonApiException(404, $"ListingId: '{id}' not found.");
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

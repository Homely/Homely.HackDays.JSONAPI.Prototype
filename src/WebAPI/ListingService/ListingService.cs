using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using WebAPI.Models;

namespace WebAPI
{
    public class ListingService : IResourceService<Listing>
    {
        private static IEnumerable<Listing> Listings => new[]
        {
            new Listing
            {
                Id = 1,
                Title = "Awesome 2 bedder close to schools",
                Price = "$150,000"
            },
            new Listing
            {
                Id = 2,
                Title = "Beachfront mansion",
                Price = "$1,000,000"
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

        public Task<object> GetRelationshipAsync(int id, string relationshipName)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> GetRelationshipsAsync(int id, string relationshipName)
        {
            throw new System.NotImplementedException();
        }

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

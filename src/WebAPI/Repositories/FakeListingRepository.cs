using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class FakeListingRepository
    {
        private static IEnumerable<Agent> Agents => new[]
        {
            new Agent
            {
                Id = 1,
                Name = "Bob Cobb",
                Email = "bob@cobb.com",
                Office = Offices.First()
            },
            new Agent
            {
                Id = 2,
                Name = "Art Vandelay",
                Email = "art@vandelay.com",
                Office = Offices.First()
            },
            new Agent
            {
                Id = 3,
                Name = "Todd Gack",
                Email = "todd@gack.com",
                Office = Offices.Last()
            }
        };

        private static IEnumerable<Listing> Listings => new[]
        {
            new Listing
            {
                Id = 1,
                Title = "Awesome 2 bedder close to schools",
                Price = "$150,000",
                Agents = Agents.Take(2).ToList(),
                PropertyType = "House",
                Address = "10 Coventry St",
                Location = Locations.First(),
                Images = new[]
                {
                    "https://res-2.cloudinary.com/hd1n2hd4y/image/upload/l-Propertybase-2898169-1.jpg",
                    "https://res-2.cloudinary.com/hd1n2hd4y/image/upload/l-Propertybase-2898169-2.jpg",
                    "https://res-2.cloudinary.com/hd1n2hd4y/image/upload/l-Propertybase-2898169-3.jpg",
                    "https://res-2.cloudinary.com/hd1n2hd4y/image/upload/l-Propertybase-2898169-4.jpg"
                }
            },
            new Listing
            {
                Id = 2,
                Title = "Beachfront mansion",
                Price = "$1,000,000",
                Agents = new[]
                {
                    Agents.Last()
                },
                PropertyType = "House",
                Address = "1 Queensbridge St",
                Location = Locations.First()
            },
            new Listing
            {
                Id = 3,
                Title = "Dream apartment",
                Price = "$270,000",
                PropertyType = "Apartment",
                Address = "10 Bridge Rd",
                Location = Locations.Last()
            }
        };

        private static IEnumerable<Office> Offices => new[]
        {
            new Office
            {
                Id = 1,
                Name = "Ray White Southbank",
                Address = "10 Whiteman St"
            },
            new Office
            {
                Id = 2,
                Name = "LJ Hooker St Kilda",
                Address = "43 Acland St"
            }
        };

        private static IEnumerable<Location> Locations => new[]
        {
            new Location
            {
                Id = 1,
                Name = "Southbank",
                State = "Victoria",
                LatLong = "180.34,-90.23"
            },
            new Location
            {
                Id = 2,
                Name = "Richmond",
                State = "Victoria",
                LatLong = "180.34,-90.23"
            }
        };

        public IEnumerable<Listing> Get()
        {
            return Listings;
        }

        public Listing Get(int id)
        {
            return Listings.SingleOrDefault(listing => listing.Id == id);
        }
    }
}

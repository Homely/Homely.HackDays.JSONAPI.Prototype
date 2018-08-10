using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Listing : Identifiable
    {
        [Attr("title")]
        public string Title { get; set; }

        [Attr("propertyType")]
        public string PropertyType { get; set; }

        [Attr("price")]
        public string Price { get; set; }

        [Attr("address")]
        public string Address { get; set; }

        [HasOne("location")]
        public Location Location { get; set; }

        [HasMany("agents")]
        public IEnumerable<Agent> Agents { get; set; }
        
        [Attr("images")]
        public IEnumerable<string> Images { get; set; }
    }
}

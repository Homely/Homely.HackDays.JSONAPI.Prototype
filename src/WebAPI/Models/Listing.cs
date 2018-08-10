using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Listing : Identifiable
    {
        [Attr("title")]
        public string Title { get; set; }

        [Attr("price")]
        public string Price { get; set; }

        [HasMany("agents")]
        public IEnumerable<Agent> Agents { get; set; }
    }
}

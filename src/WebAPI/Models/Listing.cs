using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public class Listing : Identifiable<int>
    {
        [Attr("title")]
        public string Title { get; set; }

        [Attr("price")]
        public string Price { get; set; }

        [HasMany("agents")]
        public virtual ICollection<Agent> Agents { get; set; }
    }
}

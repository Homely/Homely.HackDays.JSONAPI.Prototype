using JsonApiDotNetCore.Models;

namespace WebAPI.Models
{
    public class Location : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("state")]
        public string State { get; set; }

        [Attr("latLong")]
        public string LatLong { get; set; }
    }
}

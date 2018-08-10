using JsonApiDotNetCore.Models;

namespace WebAPI.Models
{
    public class Office : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("address")]
        public string Address { get; set; }
    }
}

using JsonApiDotNetCore.Models;

namespace WebAPI.Models
{
    public class Listing : Identifiable
    {
        [Attr("title")]
        public string Title { get; set; }

        [Attr("price")]
        public string Price { get; set; }
    }
}

using JsonApiDotNetCore.Models;

namespace WebAPI.Models
{
    public class Agent : Identifiable<int>
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("email")]
        public string Email { get; set; }
    }
}

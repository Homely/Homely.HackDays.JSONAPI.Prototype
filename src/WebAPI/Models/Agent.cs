using JsonApiDotNetCore.Models;

namespace WebAPI.Models
{
    public class Agent : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("email")]
        public string Email { get; set; }
        
        [HasOne("office")]
        public Office Office { get; set; }
    }
}

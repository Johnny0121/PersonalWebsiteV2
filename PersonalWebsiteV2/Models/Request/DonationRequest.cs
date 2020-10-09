using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsiteV2.Models.Request
{
    public class DonationRequest
    {
        [Required]
        [JsonProperty]
        public string Amount { get; set; }
    }
}

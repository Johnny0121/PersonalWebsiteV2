using System.ComponentModel.DataAnnotations;

namespace PersonalWebsiteV2.Models.Request
{
    public class DonationRequest
    {
        [Required]
        public long Amount { get; set; }
    }
}

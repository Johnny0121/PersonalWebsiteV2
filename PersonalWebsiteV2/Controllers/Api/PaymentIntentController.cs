using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteV2.Models.Request;
using Stripe;

namespace PersonalWebsiteV2.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentIntentController : Controller
    {
        [HttpPost]
        public ActionResult Create(DonationRequest request)
        {
            var paymentIntents = new PaymentIntentService();
            var paymentIntent = paymentIntents.Create(new PaymentIntentCreateOptions
            {
                Amount = request.Amount * 100,
                Currency = "gbp"
            });
            return Json(new { clientSecret = paymentIntent.ClientSecret });
        }
    }
}
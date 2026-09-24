using Microsoft.AspNetCore.Mvc;
using MobileOTPVerification.Services;

namespace MobileOTPVerification.Controllers
{
    public class OtpController : Controller
    {
        private readonly OtpService _otpService;

        public OtpController(OtpService otpService)
        {
            _otpService = otpService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendOtp(string mobileNumber)
        {
            await _otpService.SendOtpAsync(mobileNumber);

            return Content("OTP sent successfully!");
        }
        [HttpPost]
        public async Task<IActionResult> VerifyOtp(string Mobilenumber, string OtpCode)
        {
            bool result = await _otpService.VerifyOtpAsync(Mobilenumber, OtpCode);

            if (result)
            {
                return Content("OTP Verified Successfully");
            }
            return Content("Invalid OTP!");
        }
    }
}
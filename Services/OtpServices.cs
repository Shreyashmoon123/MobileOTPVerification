namespace MobileOTPVerification.Services
{
    public class OtpService
    {
        private readonly SmsService _smsService;

        public OtpService(SmsService smsService)
        {
            _smsService = smsService;
        }

        public async Task SendOtpAsync(string mobileNumber)
        {
            await _smsService.SendSmsAsync(mobileNumber);
        }

        public async Task<bool> VerifyOtpAsync(string mobileNumber, string otpCode)
        {
            return await _smsService.VerifyOtpAsync(mobileNumber, otpCode);
        }
    }
}
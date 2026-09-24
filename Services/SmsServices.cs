using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace MobileOTPVerification.Services
{
    public class SmsService
    {
        public async Task SendSmsAsync(string mobileNumber)
        {
            string accountSid = "--";
            string authToken = "--";
            string serviceSid = "--";

            TwilioClient.Init(accountSid, authToken);

            await VerificationResource.CreateAsync(
                to: mobileNumber,
                channel: "sms",
                pathServiceSid: serviceSid
            );
        }

        public async Task<bool> VerifyOtpAsync(string mobileNumber, string otpCode)
        {
            string accountSid = "--";
            string authToken = "--";
            string serviceSid = "--";

            TwilioClient.Init(accountSid, authToken);

            var verificationCheck =
                await VerificationCheckResource.CreateAsync(
                    to: mobileNumber,
                    code: otpCode,
                    pathServiceSid: serviceSid
                );

            return verificationCheck.Status == "approved";
        }
    }
}
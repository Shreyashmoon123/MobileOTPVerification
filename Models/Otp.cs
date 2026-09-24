namespace MobileOTPVerification.Models
{
    public class Otp
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public int OtpCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
    }

}
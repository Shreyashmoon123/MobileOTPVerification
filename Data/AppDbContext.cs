using Microsoft.EntityFrameworkCore;
using MobileOTPVerification.Models;
namespace MobileOTPVerification.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Otp> otps { get; set; }
    }
}
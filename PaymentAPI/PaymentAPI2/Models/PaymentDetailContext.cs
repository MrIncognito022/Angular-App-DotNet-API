using Microsoft.EntityFrameworkCore;

namespace PaymentAPI2.Models
{
    public class PaymentDetailContext:DbContext
    {
        public PaymentDetailContext(DbContextOptions options):base(options){ }
        public DbSet<PaymentDetail> paymentDetails { get; set; }

    }

}

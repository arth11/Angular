using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PaymentTb
    {
        public int PId { get; set; }
        public int? CId { get; set; }
        public int? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? BankId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? BookingId { get; set; }
    }
}

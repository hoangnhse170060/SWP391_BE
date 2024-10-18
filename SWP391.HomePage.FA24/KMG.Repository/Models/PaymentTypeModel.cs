

namespace KMG.Repository.Models.Pay
{
    public class PaymentTypeModel
    {
        public int PaymentTypeId { get; set; }
        public string PaymentTypeDesc { get; set; }

        public virtual ICollection<Order> CourseReservations { get; set; } 
            = new List<Order>(); 
    }
}

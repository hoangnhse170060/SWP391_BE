using System;
using System.Collections.Generic;

namespace KMG.Repository.Models.Pay.Entities
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            CoursePackageReservations = new HashSet<Order>();
        }

        public int PaymentTypeId { get; set; }
        public string PaymentTypeDesc { get; set; }

        public virtual ICollection<Order> CoursePackageReservations { get; set; }
    }
}

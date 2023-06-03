using System;

namespace PaymentSystem.Entity.Domains
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = new DateTime();
        public DateTime ModifyDate { get; set; } = new DateTime();
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}

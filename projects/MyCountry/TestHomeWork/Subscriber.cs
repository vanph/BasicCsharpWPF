namespace TestHomeWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subscriber
    {
        public Guid SubscriberId { get; set; }

        [Required]
        [StringLength(50)]
        public string SubscriberNo { get; set; }

        public Guid CustomerId { get; set; }

        public int SubscriberTypeId { get; set; }

        public DateTime? RegisteredDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual SubsriberType SubsriberType { get; set; }
    }
}

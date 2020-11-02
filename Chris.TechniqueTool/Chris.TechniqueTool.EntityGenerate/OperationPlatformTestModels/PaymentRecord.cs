using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class PaymentRecord
    {
        public PaymentRecord()
        {
            PaymentDetail = new HashSet<PaymentDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public Guid DriversSchoolId { get; set; }
        public int PaymentStatus { get; set; }
        public Guid? ConfirmUserId { get; set; }
        public DateTime? ConfirmTime { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string ReceiptCode { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetail { get; set; }
    }
}

using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class PaymentDetail
    {
        public Guid RecordId { get; set; }
        public Guid PurchaseId { get; set; }
        public int PaymentType { get; set; }

        public virtual Purchase Purchase { get; set; }
        public virtual PaymentRecord Record { get; set; }
    }
}

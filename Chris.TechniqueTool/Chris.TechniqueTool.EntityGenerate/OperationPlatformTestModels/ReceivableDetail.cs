using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class ReceivableDetail
    {
        public Guid RecordId { get; set; }
        public Guid PurchaseId { get; set; }

        public virtual Purchase Purchase { get; set; }
        public virtual ReceivableRecord Record { get; set; }
    }
}

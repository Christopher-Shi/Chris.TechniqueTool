using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolOrderDetail
    {
        public Guid DriversSchoolOrderId { get; set; }
        public Guid PurchaseId { get; set; }

        public virtual DriversSchoolOrder DriversSchoolOrder { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}

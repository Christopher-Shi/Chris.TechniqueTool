using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolOrder
    {
        public DriversSchoolOrder()
        {
            DriversSchoolOrderDetail = new HashSet<DriversSchoolOrderDetail>();
        }

        public Guid Id { get; set; }
        public string OrderId { get; set; }
        public Guid DriversSchoolId { get; set; }
        public decimal Amount { get; set; }
        public int OrderStatus { get; set; }
        public string ReturnUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual ICollection<DriversSchoolOrderDetail> DriversSchoolOrderDetail { get; set; }
    }
}

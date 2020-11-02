using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class ReceivableRecord
    {
        public ReceivableRecord()
        {
            ReceivableDetail = new HashSet<ReceivableDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public Guid DriversSchoolId { get; set; }
        public string ReceiptCode { get; set; }
        public int ReceivableWay { get; set; }
        public int ReceivableStatus { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public Guid? ConfirmUserId { get; set; }
        public DateTime? ConfirmTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual ICollection<ReceivableDetail> ReceivableDetail { get; set; }
    }
}

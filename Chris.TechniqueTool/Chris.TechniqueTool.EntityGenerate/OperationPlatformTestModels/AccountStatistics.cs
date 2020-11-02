using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class AccountStatistics
    {
        public AccountStatistics()
        {
            DriversSchoolAccountStatistics = new HashSet<DriversSchoolAccountStatistics>();
            StudentAccountStatistics = new HashSet<StudentAccountStatistics>();
        }

        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Receivable { get; set; }
        public decimal Received { get; set; }
        public decimal Unreceived { get; set; }
        public decimal Payable { get; set; }
        public decimal Paid { get; set; }
        public decimal Unpaid { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual ICollection<DriversSchoolAccountStatistics> DriversSchoolAccountStatistics { get; set; }
        public virtual ICollection<StudentAccountStatistics> StudentAccountStatistics { get; set; }
    }
}

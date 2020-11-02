using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolAccountStatistics
    {
        public Guid Id { get; set; }
        public Guid AccountStatisticsId { get; set; }
        public Guid DriversSchoolId { get; set; }
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

        public virtual AccountStatistics AccountStatistics { get; set; }
        public virtual DriversSchool DriversSchool { get; set; }
    }
}

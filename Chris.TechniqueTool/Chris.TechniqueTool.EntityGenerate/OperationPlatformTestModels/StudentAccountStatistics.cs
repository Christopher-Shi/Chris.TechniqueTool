using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class StudentAccountStatistics
    {
        public Guid Id { get; set; }
        public Guid AccountStatisticsId { get; set; }
        public Guid DriversSchoolId { get; set; }
        public Guid StudentId { get; set; }
        public Guid PurchaseId { get; set; }
        public decimal Amount { get; set; }
        public int PurchaseStatus { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual AccountStatistics AccountStatistics { get; set; }
        public virtual DriversSchool DriversSchool { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual Student Student { get; set; }
    }
}

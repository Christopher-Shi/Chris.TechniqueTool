using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class TrainingRecord
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public Guid DriversSchoolId { get; set; }
        public Guid StudentId { get; set; }
        public DateTime TrainingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Type { get; set; }
        public int Subject { get; set; }
        public int Unit { get; set; }
        public int Number { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual Student Student { get; set; }
    }
}

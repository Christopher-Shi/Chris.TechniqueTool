using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class TrainingTime
    {
        public Guid Id { get; set; }
        public Guid DriverSchoolId { get; set; }
        public Guid StudentId { get; set; }
        public int SubjectBtotalHours { get; set; }
        public int SubjectBpurchaseHours { get; set; }
        public int SubjectBusedHours { get; set; }
        public int SubjectBremainHours { get; set; }
        public int SubjectCtotalHours { get; set; }
        public int SubjectCpurchaseHours { get; set; }
        public int SubjectCusedHours { get; set; }
        public float SubjectCremainHours { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriverSchool { get; set; }
        public virtual Student Student { get; set; }
    }
}

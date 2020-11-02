using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class ElectronicFencePoint
    {
        public Guid Id { get; set; }
        public Guid DriversSchoolId { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public string PointsString { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
    }
}

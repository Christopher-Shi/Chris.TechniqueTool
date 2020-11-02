using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Command
    {
        public Guid Id { get; set; }
        public string TerminalId { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public string ResponseContent { get; set; }
        public DateTime? ResponseTime { get; set; }
        public Guid DriverSchoolId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid DeviceId { get; set; }

        public virtual Device Device { get; set; }
        public virtual DriversSchool DriverSchool { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual UpgradeRecord UpgradeRecord { get; set; }
    }
}

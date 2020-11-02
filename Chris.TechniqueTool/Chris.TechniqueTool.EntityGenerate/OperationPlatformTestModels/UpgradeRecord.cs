using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class UpgradeRecord
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid DriverSchoolId { get; set; }
        public Guid CommandId { get; set; }
        public string CurrentEditionNo { get; set; }
        public string UpgradeEditionNo { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UpgradeStatus { get; set; }
        public string FailReason { get; set; }

        public virtual Command Command { get; set; }
        public virtual Device Device { get; set; }
        public virtual DriversSchool DriverSchool { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

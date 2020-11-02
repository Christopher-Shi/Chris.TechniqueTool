using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class VehicleAlarm
    {
        public Guid Id { get; set; }
        public Guid DriverSchoolId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid DeviceId { get; set; }
        public int AlarmType { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Device Device { get; set; }
        public virtual DriversSchool DriverSchool { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

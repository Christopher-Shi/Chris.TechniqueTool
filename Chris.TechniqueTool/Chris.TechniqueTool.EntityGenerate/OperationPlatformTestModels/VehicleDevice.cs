using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class VehicleDevice
    {
        public Guid? VehicleId { get; set; }
        public Guid DeviceId { get; set; }
        public string LanIp { get; set; }
        public int LanPort { get; set; }
        public string PublicNetworkIp { get; set; }
        public int PublicNetworkPort { get; set; }
        public string SimCard { get; set; }
        public Guid BindingUserId { get; set; }
        public bool IsBinding { get; set; }
        public DateTime BindingTime { get; set; }
        public Guid? RemoveBindingUserId { get; set; }
        public DateTime? RemoveBindingTime { get; set; }

        public virtual Device Device { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

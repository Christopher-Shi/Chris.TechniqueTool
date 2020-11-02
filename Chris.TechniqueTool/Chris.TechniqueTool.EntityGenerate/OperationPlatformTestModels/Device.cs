using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Device
    {
        public Device()
        {
            Command = new HashSet<Command>();
            DistributeEditionDetail = new HashSet<DistributeEditionDetail>();
            Location = new HashSet<Location>();
            UpgradeRecord = new HashSet<UpgradeRecord>();
            VehicleAlarm = new HashSet<VehicleAlarm>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SoftwareVrsion { get; set; }
        public string HardwareModel { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Type { get; set; }
        public string Manufacturer { get; set; }
        public string TerminalModel { get; set; }
        public string ImeiOrMacAddress { get; set; }
        public string FactorySerialNumber { get; set; }
        public string Certificate { get; set; }
        public string CertificatePassword { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual VehicleDevice VehicleDevice { get; set; }
        public virtual ICollection<Command> Command { get; set; }
        public virtual ICollection<DistributeEditionDetail> DistributeEditionDetail { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<UpgradeRecord> UpgradeRecord { get; set; }
        public virtual ICollection<VehicleAlarm> VehicleAlarm { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Command = new HashSet<Command>();
            DistributeEditionDetail = new HashSet<DistributeEditionDetail>();
            Location = new HashSet<Location>();
            UpgradeRecord = new HashSet<UpgradeRecord>();
            VehicleAlarm = new HashSet<VehicleAlarm>();
        }

        public Guid Id { get; set; }
        public string FrameNumber { get; set; }
        public string VehicleNo { get; set; }
        public string CarNumber { get; set; }
        public string VehicleType { get; set; }
        public string VehicleBrand { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string EngineNo { get; set; }
        public int LicensePlateColor { get; set; }
        public Guid? AvatarId { get; set; }
        public string Manufacturer { get; set; }
        public int TrainingModel { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid? DriversSchoolId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual File Avatar { get; set; }
        public virtual DriversSchool DriversSchool { get; set; }
        public virtual DriversSchoolVehicleDeployRecordDetail DriversSchoolVehicleDeployRecordDetail { get; set; }
        public virtual VehicleDevice VehicleDevice { get; set; }
        public virtual ICollection<Command> Command { get; set; }
        public virtual ICollection<DistributeEditionDetail> DistributeEditionDetail { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<UpgradeRecord> UpgradeRecord { get; set; }
        public virtual ICollection<VehicleAlarm> VehicleAlarm { get; set; }
    }
}

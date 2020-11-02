using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Location
    {
        public Location()
        {
            LocationExtension = new HashSet<LocationExtension>();
        }

        public Guid Id { get; set; }
        public Guid DriversSchoolId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid DeviceId { get; set; }
        public string TerminalId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public double TravelRecordSpeed { get; set; }
        public double SatellitePositioningSpeed { get; set; }
        public double Direction { get; set; }
        public DateTime Time { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Device Device { get; set; }
        public virtual DriversSchool DriversSchool { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual LocationAlarmFlag LocationAlarmFlag { get; set; }
        public virtual LocationStatusBit LocationStatusBit { get; set; }
        public virtual ICollection<LocationExtension> LocationExtension { get; set; }
    }
}

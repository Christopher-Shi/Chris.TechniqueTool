using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class LocationStatusBit
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public int Accstatus { get; set; }
        public int PositionStatus { get; set; }
        public int LatitudeStatus { get; set; }
        public int LongitudeStatus { get; set; }
        public int OperationalStatus { get; set; }
        public int LongitudeAndLatitudeEncryptedBySecurityPluginStatus { get; set; }
        public int DifferentialPositionStatus { get; set; }
        public int OrientationStatus { get; set; }
        public int EnergyStatus { get; set; }
        public int CommunicationMethod { get; set; }
        public int VehicleOilRoadStatus { get; set; }
        public int VehicleCircuitStatus { get; set; }
        public int VehicleDoorStatus { get; set; }

        public virtual Location Location { get; set; }
    }
}

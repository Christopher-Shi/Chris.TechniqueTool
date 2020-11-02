using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolVehicleDeployRecordDetail
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public Guid? DriversSchoolVehicleDeployRecordId { get; set; }
        public DateTime DeployTime { get; set; }

        public virtual DriversSchoolVehicleDeployRecord DriversSchoolVehicleDeployRecord { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

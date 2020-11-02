using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DistributeEditionDetail
    {
        public Guid Id { get; set; }
        public Guid DistributeId { get; set; }
        public Guid DeviceId { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? DriversSchoolId { get; set; }

        public virtual Device Device { get; set; }
        public virtual DistributeEdition Distribute { get; set; }
        public virtual DriversSchool DriversSchool { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

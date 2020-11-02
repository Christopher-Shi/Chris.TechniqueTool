using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolVehicleDeployNotes
    {
        public Guid Id { get; set; }
        public Guid DriversSchoolId { get; set; }
        public string VehicleIdGroupString { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
    }
}

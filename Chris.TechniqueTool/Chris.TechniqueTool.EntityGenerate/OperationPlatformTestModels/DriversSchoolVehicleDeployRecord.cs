using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolVehicleDeployRecord
    {
        public DriversSchoolVehicleDeployRecord()
        {
            DriversSchoolVehicleDeployRecordDetail = new HashSet<DriversSchoolVehicleDeployRecordDetail>();
        }

        public Guid Id { get; set; }
        public Guid DriversSchoolId { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual ICollection<DriversSchoolVehicleDeployRecordDetail> DriversSchoolVehicleDeployRecordDetail { get; set; }
    }
}

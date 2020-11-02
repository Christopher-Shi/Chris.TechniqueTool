using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolPermission
    {
        public Guid UserId { get; set; }
        public Guid DriversSchoolId { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual User User { get; set; }
    }
}

using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchoolUploadFile
    {
        public Guid DriversSchoolId { get; set; }
        public Guid FileId { get; set; }
        public int Type { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual File File { get; set; }
    }
}

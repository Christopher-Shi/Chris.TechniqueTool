using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Suffix { get; set; }
        public string ContentType { get; set; }

        public virtual DriversSchoolUploadFile DriversSchoolUploadFile { get; set; }
        public virtual Edition Edition { get; set; }
        public virtual Student StudentFingerPhoto { get; set; }
        public virtual Student StudentPhoto { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class LocationExtension
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public int ExtraInformationId { get; set; }
        public double ExtraInformationDescriptions { get; set; }

        public virtual Location Location { get; set; }
    }
}

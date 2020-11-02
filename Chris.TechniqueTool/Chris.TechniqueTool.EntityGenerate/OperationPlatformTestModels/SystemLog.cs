using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class SystemLog
    {
        public Guid Id { get; set; }
        public string LogString { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}

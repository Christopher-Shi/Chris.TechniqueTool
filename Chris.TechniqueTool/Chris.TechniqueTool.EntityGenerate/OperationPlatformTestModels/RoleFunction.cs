using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class RoleFunction
    {
        public Guid RoleId { get; set; }
        public Guid FunctionId { get; set; }

        public virtual Function Function { get; set; }
        public virtual Role Role { get; set; }
    }
}

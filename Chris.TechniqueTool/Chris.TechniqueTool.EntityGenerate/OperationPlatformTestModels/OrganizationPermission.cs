using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class OrganizationPermission
    {
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Function
    {
        public Function()
        {
            InverseParent = new HashSet<Function>();
            RoleFunction = new HashSet<RoleFunction>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual Function Parent { get; set; }
        public virtual ICollection<Function> InverseParent { get; set; }
        public virtual ICollection<RoleFunction> RoleFunction { get; set; }
    }
}

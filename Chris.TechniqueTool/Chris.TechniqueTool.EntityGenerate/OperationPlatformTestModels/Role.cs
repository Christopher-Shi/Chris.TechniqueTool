using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Role
    {
        public Role()
        {
            RoleFunction = new HashSet<RoleFunction>();
            User = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual ICollection<RoleFunction> RoleFunction { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}

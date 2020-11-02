using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class User
    {
        public User()
        {
            DriversSchoolPermission = new HashSet<DriversSchoolPermission>();
            OrganizationPermission = new HashSet<OrganizationPermission>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string TrueName { get; set; }
        public int Gender { get; set; }
        public string CardId { get; set; }
        public string Phone { get; set; }
        public int IsEnabled { get; set; }
        public Guid? AvatarId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual File Avatar { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<DriversSchoolPermission> DriversSchoolPermission { get; set; }
        public virtual ICollection<OrganizationPermission> OrganizationPermission { get; set; }
    }
}

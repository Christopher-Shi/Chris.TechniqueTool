using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Organization
    {
        public Organization()
        {
            DriversSchoolAgencyNavigation = new HashSet<DriversSchool>();
            DriversSchoolSubcompanyNavigation = new HashSet<DriversSchool>();
            InverseParent = new HashSet<Organization>();
            OrganizationPermission = new HashSet<OrganizationPermission>();
            User = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? AreaId { get; set; }
        public Guid? ParentId { get; set; }
        public int Type { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string ChargePerson { get; set; }
        public string ChargePersonPhone { get; set; }
        public string TaxNumber { get; set; }
        public string DepositBank { get; set; }
        public string BankAccount { get; set; }
        public bool IsDelete { get; set; }
        public Guid? CreatedUserId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual Area Area { get; set; }
        public virtual Organization Parent { get; set; }
        public virtual ICollection<DriversSchool> DriversSchoolAgencyNavigation { get; set; }
        public virtual ICollection<DriversSchool> DriversSchoolSubcompanyNavigation { get; set; }
        public virtual ICollection<Organization> InverseParent { get; set; }
        public virtual ICollection<OrganizationPermission> OrganizationPermission { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}

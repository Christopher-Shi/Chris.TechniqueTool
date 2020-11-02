using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Area
    {
        public Area()
        {
            DriversSchoolCityNavigation = new HashSet<DriversSchool>();
            DriversSchoolProvinceNavigation = new HashSet<DriversSchool>();
            InverseParent = new HashSet<Area>();
            Organization = new HashSet<Organization>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual Area Parent { get; set; }
        public virtual ICollection<DriversSchool> DriversSchoolCityNavigation { get; set; }
        public virtual ICollection<DriversSchool> DriversSchoolProvinceNavigation { get; set; }
        public virtual ICollection<Area> InverseParent { get; set; }
        public virtual ICollection<Organization> Organization { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Edition
    {
        public Edition()
        {
            DistributeEdition = new HashSet<DistributeEdition>();
        }

        public Guid Id { get; set; }
        public string EditionNumber { get; set; }
        public string EditionName { get; set; }
        public Guid ServicePackId { get; set; }
        public int InitiateStatus { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual File ServicePack { get; set; }
        public virtual ICollection<DistributeEdition> DistributeEdition { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DistributeEdition
    {
        public DistributeEdition()
        {
            DistributeEditionDetail = new HashSet<DistributeEditionDetail>();
        }

        public Guid Id { get; set; }
        public Guid EditionId { get; set; }
        public int DistributeStatus { get; set; }
        public bool IsDeleted { get; set; }
        public string DistributedContent { get; set; }
        public Guid? DistributedUserId { get; set; }
        public DateTime? DistributedTime { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual Edition Edition { get; set; }
        public virtual ICollection<DistributeEditionDetail> DistributeEditionDetail { get; set; }
    }
}

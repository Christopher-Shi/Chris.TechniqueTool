using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class StudentOrder
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; }
        public Guid DriversSchoolId { get; set; }
        public Guid StudentId { get; set; }
        public int PurchaseType { get; set; }
        public int? Subject { get; set; }
        public int? PurchaseUnit { get; set; }
        public int? PurchaseNumber { get; set; }
        public decimal Amount { get; set; }
        public int OrderStatus { get; set; }
        public string ReturnUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual Student Student { get; set; }
    }
}

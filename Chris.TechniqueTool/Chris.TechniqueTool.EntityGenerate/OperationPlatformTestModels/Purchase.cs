using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Purchase
    {
        public Purchase()
        {
            DriversSchoolOrderDetail = new HashSet<DriversSchoolOrderDetail>();
            PaymentDetail = new HashSet<PaymentDetail>();
            StudentAccountStatistics = new HashSet<StudentAccountStatistics>();
        }

        public Guid Id { get; set; }
        public Guid DriversSchoolId { get; set; }
        public Guid StudentId { get; set; }
        public string PurchaseCode { get; set; }
        public int PurchaseSource { get; set; }
        public int PurchaseType { get; set; }
        public int PurchaseWay { get; set; }
        public DateTime PurchaseTime { get; set; }
        public int? Subject { get; set; }
        public int? PurchaseUnit { get; set; }
        public int? PurchaseNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal DivisionProportion { get; set; }
        public decimal? ReturnAmount { get; set; }
        public decimal PlatformDivisionAmount { get; set; }
        public decimal DriversSchoolAmount { get; set; }
        public DateTime? ConfirmDateTime { get; set; }
        public int PurchaseStatus { get; set; }
        public Guid AccountingRuleId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual AccountingRule AccountingRule { get; set; }
        public virtual DriversSchool DriversSchool { get; set; }
        public virtual Student Student { get; set; }
        public virtual ReceivableDetail ReceivableDetail { get; set; }
        public virtual ICollection<DriversSchoolOrderDetail> DriversSchoolOrderDetail { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetail { get; set; }
        public virtual ICollection<StudentAccountStatistics> StudentAccountStatistics { get; set; }
    }
}

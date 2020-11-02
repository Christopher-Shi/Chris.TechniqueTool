using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class Student
    {
        public Student()
        {
            Purchase = new HashSet<Purchase>();
            StudentAccountStatistics = new HashSet<StudentAccountStatistics>();
            StudentOrder = new HashSet<StudentOrder>();
            TrainingRecord = new HashSet<TrainingRecord>();
            TrainingTime = new HashSet<TrainingTime>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public Guid? PhotoId { get; set; }
        public bool IsLocalRegister { get; set; }
        public string ResidentAddress { get; set; }
        public int TrainignModels { get; set; }
        public DateTime RegistrationTime { get; set; }
        public int StudentType { get; set; }
        public Guid DriversSchoolId { get; set; }
        public int CertificateType { get; set; }
        public string CertificateNo { get; set; }
        public string NationType { get; set; }
        public int Gender { get; set; }
        public Guid? FingerPhotoId { get; set; }
        public int BusinessType { get; set; }
        public string FormerLicenceNo { get; set; }
        public DateTime? FormerLicenceGetTime { get; set; }
        public int? FormerLicenceType { get; set; }
        public bool IsDelete { get; set; }
        public Guid? CreatedUserId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual File FingerPhoto { get; set; }
        public virtual File Photo { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
        public virtual ICollection<StudentAccountStatistics> StudentAccountStatistics { get; set; }
        public virtual ICollection<StudentOrder> StudentOrder { get; set; }
        public virtual ICollection<TrainingRecord> TrainingRecord { get; set; }
        public virtual ICollection<TrainingTime> TrainingTime { get; set; }
    }
}

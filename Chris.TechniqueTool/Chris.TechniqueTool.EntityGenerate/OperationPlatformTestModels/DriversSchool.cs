using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class DriversSchool
    {
        public DriversSchool()
        {
            Command = new HashSet<Command>();
            DistributeEditionDetail = new HashSet<DistributeEditionDetail>();
            DriversSchoolAccountStatistics = new HashSet<DriversSchoolAccountStatistics>();
            DriversSchoolOrder = new HashSet<DriversSchoolOrder>();
            DriversSchoolPermission = new HashSet<DriversSchoolPermission>();
            DriversSchoolUploadFile = new HashSet<DriversSchoolUploadFile>();
            DriversSchoolVehicleDeployNotes = new HashSet<DriversSchoolVehicleDeployNotes>();
            ElectronicFencePoint = new HashSet<ElectronicFencePoint>();
            InverseParent = new HashSet<DriversSchool>();
            Location = new HashSet<Location>();
            PaymentRecord = new HashSet<PaymentRecord>();
            Purchase = new HashSet<Purchase>();
            ReceivableRecord = new HashSet<ReceivableRecord>();
            Student = new HashSet<Student>();
            StudentAccountStatistics = new HashSet<StudentAccountStatistics>();
            StudentOrder = new HashSet<StudentOrder>();
            TrainingRecord = new HashSet<TrainingRecord>();
            TrainingTime = new HashSet<TrainingTime>();
            UpgradeRecord = new HashSet<UpgradeRecord>();
            Vehicle = new HashSet<Vehicle>();
            VehicleAlarm = new HashSet<VehicleAlarm>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public decimal AddressLatitude { get; set; }
        public decimal AddressLongitude { get; set; }
        public string Introduction { get; set; }
        public string LegalRepresentative { get; set; }
        public int Type { get; set; }
        public Guid Province { get; set; }
        public Guid City { get; set; }
        public Guid Subcompany { get; set; }
        public Guid? Agency { get; set; }
        public Guid? ParentId { get; set; }
        public string BusinessCertificateCode { get; set; }
        public DateTime BusinessCertificateDate { get; set; }
        public string BusinessLicenseCode { get; set; }
        public string UnifiedSocialCreditCode { get; set; }
        public string ContactPeople { get; set; }
        public string ContactPhone { get; set; }
        public int OperatingState { get; set; }
        public string ContactWeChat { get; set; }
        public int? CoachNumber { get; set; }
        public int? CarNumber { get; set; }
        public int? ClassifyLevel { get; set; }
        public int? InspectionNumber { get; set; }
        public int? SafeOfficerNumber { get; set; }
        public double? AllRoomArea { get; set; }
        public double? TheoryRoomArea { get; set; }
        public double? TrainPlaceArea { get; set; }
        public string BusinessScope { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual Organization AgencyNavigation { get; set; }
        public virtual Area CityNavigation { get; set; }
        public virtual DriversSchool Parent { get; set; }
        public virtual Area ProvinceNavigation { get; set; }
        public virtual Organization SubcompanyNavigation { get; set; }
        public virtual AccountingRule AccountingRule { get; set; }
        public virtual DriversSchoolVehicleDeployRecord DriversSchoolVehicleDeployRecord { get; set; }
        public virtual ICollection<Command> Command { get; set; }
        public virtual ICollection<DistributeEditionDetail> DistributeEditionDetail { get; set; }
        public virtual ICollection<DriversSchoolAccountStatistics> DriversSchoolAccountStatistics { get; set; }
        public virtual ICollection<DriversSchoolOrder> DriversSchoolOrder { get; set; }
        public virtual ICollection<DriversSchoolPermission> DriversSchoolPermission { get; set; }
        public virtual ICollection<DriversSchoolUploadFile> DriversSchoolUploadFile { get; set; }
        public virtual ICollection<DriversSchoolVehicleDeployNotes> DriversSchoolVehicleDeployNotes { get; set; }
        public virtual ICollection<ElectronicFencePoint> ElectronicFencePoint { get; set; }
        public virtual ICollection<DriversSchool> InverseParent { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<PaymentRecord> PaymentRecord { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
        public virtual ICollection<ReceivableRecord> ReceivableRecord { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<StudentAccountStatistics> StudentAccountStatistics { get; set; }
        public virtual ICollection<StudentOrder> StudentOrder { get; set; }
        public virtual ICollection<TrainingRecord> TrainingRecord { get; set; }
        public virtual ICollection<TrainingTime> TrainingTime { get; set; }
        public virtual ICollection<UpgradeRecord> UpgradeRecord { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<VehicleAlarm> VehicleAlarm { get; set; }
    }
}

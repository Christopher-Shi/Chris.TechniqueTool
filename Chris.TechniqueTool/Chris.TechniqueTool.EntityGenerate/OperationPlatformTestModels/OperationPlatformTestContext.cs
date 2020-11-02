using Microsoft.EntityFrameworkCore;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class OperationPlatformTestContext : DbContext
    {
        public OperationPlatformTestContext()
        {
        }

        public OperationPlatformTestContext(DbContextOptions<OperationPlatformTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountStatistics> AccountStatistics { get; set; }
        public virtual DbSet<AccountingRule> AccountingRule { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Command> Command { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DistributeEdition> DistributeEdition { get; set; }
        public virtual DbSet<DistributeEditionDetail> DistributeEditionDetail { get; set; }
        public virtual DbSet<DriversSchool> DriversSchool { get; set; }
        public virtual DbSet<DriversSchoolAccountStatistics> DriversSchoolAccountStatistics { get; set; }
        public virtual DbSet<DriversSchoolOrder> DriversSchoolOrder { get; set; }
        public virtual DbSet<DriversSchoolOrderDetail> DriversSchoolOrderDetail { get; set; }
        public virtual DbSet<DriversSchoolPermission> DriversSchoolPermission { get; set; }
        public virtual DbSet<DriversSchoolUploadFile> DriversSchoolUploadFile { get; set; }
        public virtual DbSet<DriversSchoolVehicleDeployNotes> DriversSchoolVehicleDeployNotes { get; set; }
        public virtual DbSet<DriversSchoolVehicleDeployRecord> DriversSchoolVehicleDeployRecord { get; set; }
        public virtual DbSet<DriversSchoolVehicleDeployRecordDetail> DriversSchoolVehicleDeployRecordDetail { get; set; }
        public virtual DbSet<Edition> Edition { get; set; }
        public virtual DbSet<ElectronicFencePoint> ElectronicFencePoint { get; set; }
        public virtual DbSet<File> File { get; set; }
        public virtual DbSet<Function> Function { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationAlarmFlag> LocationAlarmFlag { get; set; }
        public virtual DbSet<LocationExtension> LocationExtension { get; set; }
        public virtual DbSet<LocationStatusBit> LocationStatusBit { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<OrganizationPermission> OrganizationPermission { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetail { get; set; }
        public virtual DbSet<PaymentRecord> PaymentRecord { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<ReceivableDetail> ReceivableDetail { get; set; }
        public virtual DbSet<ReceivableRecord> ReceivableRecord { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleFunction> RoleFunction { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentAccountStatistics> StudentAccountStatistics { get; set; }
        public virtual DbSet<StudentOrder> StudentOrder { get; set; }
        public virtual DbSet<SystemLog> SystemLog { get; set; }
        public virtual DbSet<TrainingRecord> TrainingRecord { get; set; }
        public virtual DbSet<TrainingTime> TrainingTime { get; set; }
        public virtual DbSet<UpgradeRecord> UpgradeRecord { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleAlarm> VehicleAlarm { get; set; }
        public virtual DbSet<VehicleDevice> VehicleDevice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=OperationPlatformTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountStatistics>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Payable).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Receivable).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Received).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unpaid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unreceived).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<AccountingRule>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DriversSchoolDivisionAmountForSubjectThree).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolDivisionAmountForSubjectThreeSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolDivisionAmountForSubjectThreeSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolDivisionAmountForSubjectTwo).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolDivisionAmountForSubjectTwoSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolDivisionAmountForSubjectTwoSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolDivisionAmountForTuition).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForSubjectThree).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForSubjectThreeSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForSubjectThreeSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForSubjectTwo).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForSubjectTwoSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForSubjectTwoSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmountForTuition).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForSubjectThree).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForSubjectThreeSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForSubjectThreeSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForSubjectTwo).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForSubjectTwoSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForSubjectTwoSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProportionForTuition).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubjectThreePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubjectThreeSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubjectThreeSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubjectTwoPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubjectTwoSimulationPerHour).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubjectTwoSimulationPerLoop).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Tuition).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.DriversSchool)
                    .WithOne(p => p.AccountingRule)
                    .HasForeignKey<AccountingRule>(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.DriverSchoolId);

                entity.HasIndex(e => e.VehicleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Command)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriverSchool)
                    .WithMany(p => p.Command)
                    .HasForeignKey(d => d.DriverSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Command)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Certificate).IsRequired();

                entity.Property(e => e.CertificatePassword)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FactorySerialNumber)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HardwareModel)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ImeiOrMacAddress)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SoftwareVrsion)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TerminalModel)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<DistributeEdition>(entity =>
            {
                entity.HasIndex(e => e.EditionId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DistributedContent).HasMaxLength(200);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.DistributeEdition)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DistributeEditionDetail>(entity =>
            {
                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.DistributeId);

                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.VehicleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DistributeEditionDetail)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Distribute)
                    .WithMany(p => p.DistributeEditionDetail)
                    .HasForeignKey(d => d.DistributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.DistributeEditionDetail)
                    .HasForeignKey(d => d.DriversSchoolId);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.DistributeEditionDetail)
                    .HasForeignKey(d => d.VehicleId);
            });

            modelBuilder.Entity<DriversSchool>(entity =>
            {
                entity.HasIndex(e => e.Agency);

                entity.HasIndex(e => e.City);

                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => e.Province);

                entity.HasIndex(e => e.Subcompany);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AddressLatitude).HasColumnType("decimal(13, 10)");

                entity.Property(e => e.AddressLongitude).HasColumnType("decimal(13, 10)");

                entity.Property(e => e.BusinessCertificateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessLicenseCode).HasMaxLength(50);

                entity.Property(e => e.BusinessScope)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactPeople)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactWeChat).HasMaxLength(50);

                entity.Property(e => e.Introduction)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LegalRepresentative)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postcode).HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(50);

                entity.Property(e => e.UnifiedSocialCreditCode).HasMaxLength(50);

                entity.HasOne(d => d.AgencyNavigation)
                    .WithMany(p => p.DriversSchoolAgencyNavigation)
                    .HasForeignKey(d => d.Agency);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.DriversSchoolCityNavigation)
                    .HasForeignKey(d => d.City)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.ProvinceNavigation)
                    .WithMany(p => p.DriversSchoolProvinceNavigation)
                    .HasForeignKey(d => d.Province)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SubcompanyNavigation)
                    .WithMany(p => p.DriversSchoolSubcompanyNavigation)
                    .HasForeignKey(d => d.Subcompany)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolAccountStatistics>(entity =>
            {
                entity.HasIndex(e => e.AccountStatisticsId);

                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Payable).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Receivable).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Received).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unpaid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unreceived).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AccountStatistics)
                    .WithMany(p => p.DriversSchoolAccountStatistics)
                    .HasForeignKey(d => d.AccountStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.DriversSchoolAccountStatistics)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolOrder>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnUrl)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.DriversSchoolOrder)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.DriversSchoolOrderId, e.PurchaseId });

                entity.HasIndex(e => e.PurchaseId);

                entity.HasOne(d => d.DriversSchoolOrder)
                    .WithMany(p => p.DriversSchoolOrderDetail)
                    .HasForeignKey(d => d.DriversSchoolOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.DriversSchoolOrderDetail)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DriversSchoolId });

                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.DriversSchoolPermission)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DriversSchoolPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolUploadFile>(entity =>
            {
                entity.HasKey(e => new { e.DriversSchoolId, e.FileId });

                entity.HasIndex(e => e.FileId)
                    .IsUnique();

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.DriversSchoolUploadFile)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.File)
                    .WithOne(p => p.DriversSchoolUploadFile)
                    .HasForeignKey<DriversSchoolUploadFile>(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolVehicleDeployNotes>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.VehicleIdGroupString).IsRequired();

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.DriversSchoolVehicleDeployNotes)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolVehicleDeployRecord>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DriversSchool)
                    .WithOne(p => p.DriversSchoolVehicleDeployRecord)
                    .HasForeignKey<DriversSchoolVehicleDeployRecord>(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DriversSchoolVehicleDeployRecordDetail>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolVehicleDeployRecordId);

                entity.HasIndex(e => e.VehicleId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DriversSchoolVehicleDeployRecord)
                    .WithMany(p => p.DriversSchoolVehicleDeployRecordDetail)
                    .HasForeignKey(d => d.DriversSchoolVehicleDeployRecordId);

                entity.HasOne(d => d.Vehicle)
                    .WithOne(p => p.DriversSchoolVehicleDeployRecordDetail)
                    .HasForeignKey<DriversSchoolVehicleDeployRecordDetail>(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Edition>(entity =>
            {
                entity.HasIndex(e => e.ServicePackId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EditionName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.EditionNumber)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.ServicePack)
                    .WithOne(p => p.Edition)
                    .HasForeignKey<Edition>(d => d.ServicePackId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ElectronicFencePoint>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PointsString).IsRequired();

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.ElectronicFencePoint)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Suffix)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.VehicleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Latitude).HasColumnType("decimal(13, 10)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(13, 10)");

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationAlarmFlag>(entity =>
            {
                entity.HasIndex(e => e.LocationId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GnssmoduleFailure).HasColumnName("GNSSModuleFailure");

                entity.Property(e => e.GnssshortCircuit).HasColumnName("GNSSShortCircuit");

                entity.Property(e => e.GnsstheAntennaNotConnecteOrCut).HasColumnName("GNSSTheAntennaNotConnecteOrCut");

                entity.Property(e => e.TerminalLcdorDisplayFailure).HasColumnName("TerminalLCDOrDisplayFailure");

                entity.Property(e => e.TtsmoduleFailure).HasColumnName("TTSModuleFailure");

                entity.Property(e => e.VehicleVssmalfunction).HasColumnName("VehicleVSSMalfunction");

                entity.HasOne(d => d.Location)
                    .WithOne(p => p.LocationAlarmFlag)
                    .HasForeignKey<LocationAlarmFlag>(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationExtension>(entity =>
            {
                entity.HasIndex(e => e.LocationId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationExtension)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationStatusBit>(entity =>
            {
                entity.HasIndex(e => e.LocationId)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Accstatus).HasColumnName("ACCStatus");

                entity.HasOne(d => d.Location)
                    .WithOne(p => p.LocationStatusBit)
                    .HasForeignKey<LocationStatusBit>(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasIndex(e => e.AreaId);

                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChargePerson)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChargePersonPhone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DepositBank)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Organization)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<OrganizationPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.OrganizationId });

                entity.HasIndex(e => e.OrganizationId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationPermission)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrganizationPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.HasKey(e => new { e.RecordId, e.PurchaseId, e.PaymentType });

                entity.HasIndex(e => e.PurchaseId);

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PaymentDetail)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.PaymentDetail)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PaymentRecord>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiptCode).HasMaxLength(100);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.PaymentRecord)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasIndex(e => e.AccountingRuleId);

                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.PurchaseCode)
                    .IsUnique();

                entity.HasIndex(e => e.StudentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DivisionProportion).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DriversSchoolAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformDivisionAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PurchaseCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AccountingRule)
                    .WithMany(p => p.Purchase)
                    .HasForeignKey(d => d.AccountingRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.Purchase)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Purchase)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ReceivableDetail>(entity =>
            {
                entity.HasKey(e => new { e.RecordId, e.PurchaseId });

                entity.HasIndex(e => e.PurchaseId)
                    .IsUnique();

                entity.HasOne(d => d.Purchase)
                    .WithOne(p => p.ReceivableDetail)
                    .HasForeignKey<ReceivableDetail>(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.ReceivableDetail)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ReceivableRecord>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiptCode).HasMaxLength(100);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.ReceivableRecord)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.FunctionId });

                entity.HasIndex(e => e.FunctionId);

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.RoleFunction)
                    .HasForeignKey(d => d.FunctionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleFunction)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.FingerPhotoId)
                    .IsUnique()
                    .HasFilter("([FingerPhotoId] IS NOT NULL)");

                entity.HasIndex(e => e.PhotoId)
                    .IsUnique()
                    .HasFilter("([PhotoId] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CertificateNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FormerLicenceNo).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NationType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResidentAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FingerPhoto)
                    .WithOne(p => p.StudentFingerPhoto)
                    .HasForeignKey<Student>(d => d.FingerPhotoId);

                entity.HasOne(d => d.Photo)
                    .WithOne(p => p.StudentPhoto)
                    .HasForeignKey<Student>(d => d.PhotoId);
            });

            modelBuilder.Entity<StudentAccountStatistics>(entity =>
            {
                entity.HasIndex(e => e.AccountStatisticsId);

                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.PurchaseId);

                entity.HasIndex(e => e.StudentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.AccountStatistics)
                    .WithMany(p => p.StudentAccountStatistics)
                    .HasForeignKey(d => d.AccountStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.StudentAccountStatistics)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.StudentAccountStatistics)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentAccountStatistics)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StudentOrder>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.StudentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnUrl)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.StudentOrder)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentOrder)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LogString)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TrainingRecord>(entity =>
            {
                entity.HasIndex(e => e.DriversSchoolId);

                entity.HasIndex(e => e.StudentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.TrainingRecord)
                    .HasForeignKey(d => d.DriversSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TrainingRecord)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TrainingTime>(entity =>
            {
                entity.HasIndex(e => e.DriverSchoolId);

                entity.HasIndex(e => e.StudentId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SubjectBpurchaseHours).HasColumnName("SubjectBPurchaseHours");

                entity.Property(e => e.SubjectBremainHours).HasColumnName("SubjectBRemainHours");

                entity.Property(e => e.SubjectBtotalHours).HasColumnName("SubjectBTotalHours");

                entity.Property(e => e.SubjectBusedHours).HasColumnName("SubjectBUsedHours");

                entity.Property(e => e.SubjectCpurchaseHours).HasColumnName("SubjectCPurchaseHours");

                entity.Property(e => e.SubjectCremainHours).HasColumnName("SubjectCRemainHours");

                entity.Property(e => e.SubjectCtotalHours).HasColumnName("SubjectCTotalHours");

                entity.Property(e => e.SubjectCusedHours).HasColumnName("SubjectCUsedHours");

                entity.HasOne(d => d.DriverSchool)
                    .WithMany(p => p.TrainingTime)
                    .HasForeignKey(d => d.DriverSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TrainingTime)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UpgradeRecord>(entity =>
            {
                entity.HasIndex(e => e.CommandId)
                    .IsUnique();

                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.DriverSchoolId);

                entity.HasIndex(e => e.VehicleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CurrentEditionNo).IsRequired();

                entity.Property(e => e.UpgradeEditionNo).IsRequired();

                entity.HasOne(d => d.Command)
                    .WithOne(p => p.UpgradeRecord)
                    .HasForeignKey<UpgradeRecord>(d => d.CommandId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.UpgradeRecord)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriverSchool)
                    .WithMany(p => p.UpgradeRecord)
                    .HasForeignKey(d => d.DriverSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.UpgradeRecord)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.AvatarId)
                    .IsUnique()
                    .HasFilter("([AvatarId] IS NOT NULL)");

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TrueName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Avatar)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.AvatarId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasIndex(e => e.AvatarId)
                    .IsUnique()
                    .HasFilter("([AvatarId] IS NOT NULL)");

                entity.HasIndex(e => e.DriversSchoolId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CarNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EngineNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FrameNumber)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleBrand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleType)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Avatar)
                    .WithOne(p => p.Vehicle)
                    .HasForeignKey<Vehicle>(d => d.AvatarId);

                entity.HasOne(d => d.DriversSchool)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.DriversSchoolId);
            });

            modelBuilder.Entity<VehicleAlarm>(entity =>
            {
                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.DriverSchoolId);

                entity.HasIndex(e => e.VehicleId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.VehicleAlarm)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DriverSchool)
                    .WithMany(p => p.VehicleAlarm)
                    .HasForeignKey(d => d.DriverSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleAlarm)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VehicleDevice>(entity =>
            {
                entity.HasKey(e => e.DeviceId);

                entity.HasIndex(e => e.VehicleId)
                    .IsUnique()
                    .HasFilter("([VehicleId] IS NOT NULL)");

                entity.Property(e => e.DeviceId).ValueGeneratedNever();

                entity.Property(e => e.LanIp)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.PublicNetworkIp)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SimCard)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Device)
                    .WithOne(p => p.VehicleDevice)
                    .HasForeignKey<VehicleDevice>(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vehicle)
                    .WithOne(p => p.VehicleDevice)
                    .HasForeignKey<VehicleDevice>(d => d.VehicleId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

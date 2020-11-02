using System;
using System.Collections.Generic;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class AccountingRule
    {
        public AccountingRule()
        {
            Purchase = new HashSet<Purchase>();
        }

        public Guid Id { get; set; }
        public Guid DriversSchoolId { get; set; }
        public int MinutesPerClass { get; set; }
        public decimal Tuition { get; set; }
        public decimal ReturnAmount { get; set; }
        public int SubjectTwoHours { get; set; }
        public int SubjectThreeHours { get; set; }
        public decimal ProportionForTuition { get; set; }
        public int TotalHours { get; set; }
        public decimal PlatformDivisionAmountForTuition { get; set; }
        public decimal DriversSchoolDivisionAmountForTuition { get; set; }
        public decimal SubjectTwoPrice { get; set; }
        public decimal ProportionForSubjectTwo { get; set; }
        public decimal PlatformDivisionAmountForSubjectTwo { get; set; }
        public decimal DriversSchoolDivisionAmountForSubjectTwo { get; set; }
        public decimal SubjectThreePrice { get; set; }
        public decimal ProportionForSubjectThree { get; set; }
        public decimal PlatformDivisionAmountForSubjectThree { get; set; }
        public decimal DriversSchoolDivisionAmountForSubjectThree { get; set; }
        public decimal SubjectTwoSimulationPerLoop { get; set; }
        public decimal ProportionForSubjectTwoSimulationPerLoop { get; set; }
        public decimal PlatformDivisionAmountForSubjectTwoSimulationPerLoop { get; set; }
        public decimal DriversSchoolDivisionAmountForSubjectTwoSimulationPerLoop { get; set; }
        public decimal SubjectThreeSimulationPerLoop { get; set; }
        public decimal ProportionForSubjectThreeSimulationPerLoop { get; set; }
        public decimal PlatformDivisionAmountForSubjectThreeSimulationPerLoop { get; set; }
        public decimal DriversSchoolDivisionAmountForSubjectThreeSimulationPerLoop { get; set; }
        public decimal SubjectTwoSimulationPerHour { get; set; }
        public decimal ProportionForSubjectTwoSimulationPerHour { get; set; }
        public decimal PlatformDivisionAmountForSubjectTwoSimulationPerHour { get; set; }
        public decimal DriversSchoolDivisionAmountForSubjectTwoSimulationPerHour { get; set; }
        public decimal SubjectThreeSimulationPerHour { get; set; }
        public decimal ProportionForSubjectThreeSimulationPerHour { get; set; }
        public decimal PlatformDivisionAmountForSubjectThreeSimulationPerHour { get; set; }
        public decimal DriversSchoolDivisionAmountForSubjectThreeSimulationPerHour { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }

        public virtual DriversSchool DriversSchool { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}

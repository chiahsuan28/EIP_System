//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIP_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tEmployee()
        {
            this.tApplypunches = new HashSet<tApplypunch>();
            this.tBillboards = new HashSet<tBillboard>();
            this.tCalendars = new HashSet<tCalendar>();
            this.tLeaves = new HashSet<tLeave>();
            this.tLeavecounts = new HashSet<tLeavecount>();
            this.tMetting_date = new HashSet<tMetting_date>();
            this.tNotifies = new HashSet<tNotify>();
            this.tOvertimes = new HashSet<tOvertime>();
            this.tProjects = new HashSet<tProject>();
            this.tProjectDetails = new HashSet<tProjectDetail>();
            this.tPunchtimes = new HashSet<tPunchtime>();
            this.tSignoffs = new HashSet<tSignoff>();
            this.tTeamMembers = new HashSet<tTeamMember>();
            this.tTimeRecords = new HashSet<tTimeRecord>();
        }
    
        public int fEmployeeId { get; set; }
        public string fName { get; set; }
        public string fIdent { get; set; }
        public string fPassword { get; set; }
        public string fDepartment { get; set; }
        public string fTitle { get; set; }
        public string fEmail { get; set; }
        public System.DateTime fBirth { get; set; }
        public string fPhonePersonal { get; set; }
        public System.DateTime fHireDate { get; set; }
        public int fSalaryMonth { get; set; }
        public Nullable<int> fSalaryHour { get; set; }
        public string fPhoneHouse { get; set; }
        public string fCountry { get; set; }
        public string fBirthPlace { get; set; }
        public string fEducation { get; set; }
        public string fAddressNow { get; set; }
        public string fAddressOrigin { get; set; }
        public string fEngyName { get; set; }
        public string fEngyPhone { get; set; }
        public Nullable<double> fOld { get; set; }
        public string fState { get; set; }
        public int fAuth { get; set; }
        public Nullable<System.DateTime> fFireDate { get; set; }
        public Nullable<System.DateTime> fBackDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tApplypunch> tApplypunches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tBillboard> tBillboards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCalendar> tCalendars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tLeave> tLeaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tLeavecount> tLeavecounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tMetting_date> tMetting_date { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tNotify> tNotifies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOvertime> tOvertimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProject> tProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProjectDetail> tProjectDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tPunchtime> tPunchtimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tSignoff> tSignoffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTeamMember> tTeamMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTimeRecord> tTimeRecords { get; set; }
    }
}

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
    
    public partial class tLeavecount
    {
        public int fId { get; set; }
        public int fEmployeeId { get; set; }
        public string fSort { get; set; }
        public double fAlltime { get; set; }
        public double fUesdtime { get; set; }
        public double fRemaintime { get; set; }
        public Nullable<System.DateTime> fStartdate { get; set; }
        public Nullable<System.DateTime> fEnddate { get; set; }
    
        public virtual tEmployee tEmployee { get; set; }
    }
}

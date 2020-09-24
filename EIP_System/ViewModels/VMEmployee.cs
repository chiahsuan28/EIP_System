using EIP_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AttendSystem.ViewModels
{
    public class VMEmployee
    {
        [DisplayName("員工編號")]
        public int id { get; set; }

        [DisplayName("部門")]
        public string department { get; set; }

        [DisplayName("職稱")]
        public string job { get; set; }

        [DisplayName("姓名")]
        public string name { get; set; }

        public VMEmployee convert(tEmployee emp)
        {
            this.id = emp.fEmployeeId;
            this.department = emp.fDepartment;
            this.job = emp.fTitle;
            this.name = emp.fName;

            return this;
        }
    }
}
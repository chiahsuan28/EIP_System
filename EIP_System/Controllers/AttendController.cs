using AttendSystem.ViewModels;
using EIP_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace AttendSystem.Controllers
{
    public class AttendController : Controller
    {
        //目前登入員工
        static int EmployeeId = 2;
        static string Department = "資訊部門";

        EIP_DBEntities db = new EIP_DBEntities();
        // GET: Attend
        public ActionResult Index()
        {
           //顯示最近3筆申請紀錄
           return View(db.tSignoffs.ToList().OrderByDescending(m => m.fId).Take(3));
        }

        public ActionResult CreateLeave()
        {
            //建立ViewModel
            VMCreateLeave vmCreateLeave = new VMCreateLeave();

            //取VM所需資料

            //取得部門
            List<VMEmployee> emplist = new List<VMEmployee>();
            foreach (tEmployee emp in db.tEmployees.Where(m => m.fDepartment == Department).ToList())
            {
                emplist.Add(new VMEmployee().convert(emp));
            }
            //該名員工
            vmCreateLeave.employee = emplist.Where(m => m.id == EmployeeId).FirstOrDefault();
            //該員工的請假統計
            vmCreateLeave.leavecountList = 
                db.tLeavecounts.Where(m => m.fEmployeeId == EmployeeId).ToList();
            //該部門所有員工
            vmCreateLeave.employeelist = emplist;

            return View(vmCreateLeave);
        }
        [HttpPost]
        public ActionResult CreateLeave(VMCreateLeave vMCLeave)
        {
            //請假
            tLeave tLeave = new tLeave();
            
            tLeave.fEmployeeId = vMCLeave.employee.id;
            tLeave.fSort = vMCLeave.leavesort;
            tLeave.fApplyDate = DateTime.Now;
            tLeave.fActiveDate = vMCLeave.start;
            tLeave.fEndDate = vMCLeave.end;
            tLeave.fTimeCount = vMCLeave.timecount;
            tLeave.fReason = vMCLeave.reason;

            db.tLeaves.Add(tLeave);
            db.SaveChanges();


            //簽核表
            tSignoff tSignoff = new tSignoff();
            tSignoff.fLeaveId = int.Parse(db.tLeaves
                .OrderByDescending(p => p.fId)
                .Select(r => r.fId)
                .First().ToString());
            tSignoff.fSupervisorId = Convert.ToInt32(vMCLeave.supervisorId);
            tSignoff.fApplyClass = vMCLeave.leavesort;
            tSignoff.fStartdate = DateTime.Now;
            tSignoff.fEnddate = vMCLeave.start;

            db.tSignoffs.Add(tSignoff);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult getLeaverecord()
        {
            var Leaverecord = from l in db.tSignoffs.Take(10)
                              orderby l.tLeave.fApplyDate descending
                              select new
                              {
                                  leavesort = l.fApplyClass,
                                  applydate = l.tLeave.fApplyDate,
                                  expireddate = l.fStartdate,
                                  supervisor = l.tEmployee.fName,
                                  isagreed = l.fIsAgreed
                              };
            return Json(new { data = Leaverecord.ToList() }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Userleaveinfo()
        {
            return View();
        }
        public ActionResult CreatePunchTime()
        {
            return View();
        }
    }
}
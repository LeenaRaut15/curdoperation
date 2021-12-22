using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using curdoperation.Models;

namespace curdoperation.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveEmployee(EmployeeModel model)
        {
            try
            {
                return Json(new { msg = new EmployeeModel().SaveEmployee(model) }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }




        public ActionResult GetEmployeeList()
        {
            try
            {
                return Json(new { model = (new EmployeeModel().GetEmployeeList()) },
             JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult deleteEmployee(int id)
        {
            try
            {
                return Json(new { model = (new EmployeeModel().deleteEmployee(id)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetEditEmployee(int id)
        {
            try
            {
                return Json(new { model = (new EmployeeModel().GetEditEmployee(id)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}




         

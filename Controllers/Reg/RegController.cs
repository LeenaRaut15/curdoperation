using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using curdoperation.Models;

namespace curdoperation.Controllers.Reg
{
    public class RegController : Controller
    {
        // GET: Reg
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveReg(RegModel model)
        {
            try
            {
                return Json(new { msg = new RegModel().SaveReg(model) }, JsonRequestBehavior.AllowGet);

            }
            catch(Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
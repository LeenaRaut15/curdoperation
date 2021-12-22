using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using curdoperation.Data;

namespace curdoperation.Models
{
    public class RegModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile_no { get; set; }

        public String SaveReg(RegModel model)
        {
            string msg = "";
            internshipEntities db = new internshipEntities();
            var savereg =new tblReg()
                {
                Name = model.Name,
                Address = model.Address,
                Mobile_no = model.Mobile_no,
  };
            db.tblRegs.Add(savereg);
            db.SaveChanges();
            return msg;
        }
    }
}
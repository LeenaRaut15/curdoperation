using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using curdoperation.Data;

namespace curdoperation.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile_no { get; set; }
        public string Email_id { get; set; }

        public String SaveStudent(StudentModel model)
        {
            string msg = "";
            internshipEntities db = new internshipEntities();
            var savestudent = new tblStudent()
            {
                Name = model.Name,
                Address = model.Address,
                Mobile_no = model.Mobile_no,
                Email_id = model.Email_id,
                
            };
            db.tblStudents.Add(savestudent);
            db.SaveChanges();
            return msg;
        }
    }
}




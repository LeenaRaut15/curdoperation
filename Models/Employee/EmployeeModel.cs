using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using curdoperation.Data;

namespace curdoperation.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Address { get; set; }
        public string Emp_Mobileno { get; set; }
        public string Emp_Emailid { get; set; }
        public string Emp_Qualification { get; set; }

        public String SaveEmployee(EmployeeModel model)
        {
            string msg = "";
            internshipEntities db = new internshipEntities();
            if (model.id == 0)
            {

                var EmployeeData = new tblEmployee()
                {
                    Emp_Name = model.Emp_Name,
                    Emp_Address = model.Emp_Address,
                    Emp_Mobileno = model.Emp_Mobileno,
                    Emp_Emailid = model.Emp_Emailid,
                    Emp_Qualification = model.Emp_Qualification,
                };
                db.tblEmployees.Add(EmployeeData);
                db.SaveChanges();

            }
            else
            {
                var getEmployeeData = db.tblEmployees.Where(p => p.id == model.id).FirstOrDefault();

                if (getEmployeeData != null)
                {
                    getEmployeeData.Emp_Name = model.Emp_Name;
                    getEmployeeData.Emp_Address = model.Emp_Address;
                    getEmployeeData.Emp_Mobileno = model.Emp_Mobileno;
                    getEmployeeData.Emp_Emailid = model.Emp_Emailid;
                    getEmployeeData.Emp_Qualification = model.Emp_Qualification;
                };
                db.SaveChanges();
                msg = "Updated Successfully";
            }
            return msg;
        }
        public List<EmployeeModel> GetEmployeeList()
        {
            internshipEntities Db = new internshipEntities();
            List<EmployeeModel> lstEmployee = new List<EmployeeModel>();
            var AddEmployeeList = Db.tblEmployees.ToList();
            if (AddEmployeeList != null)
            {
                foreach (var Employee in AddEmployeeList)
                {
                    lstEmployee.Add(new EmployeeModel()
                    {
                        id = Employee.id,
                        Emp_Name = Employee.Emp_Name,
                        Emp_Address = Employee.Emp_Address,
                        Emp_Mobileno = Employee.Emp_Mobileno,
                        Emp_Emailid = Employee.Emp_Emailid,
                        Emp_Qualification = Employee.Emp_Qualification,
                    });
                }
            }
            return lstEmployee;
        }
        public string deleteEmployee(int id)
        {
            string Message = "";
            internshipEntities Db = new internshipEntities();
            var deleteRecord = Db.tblEmployees.Where(p => p.id == id).FirstOrDefault();
            if (deleteRecord != null)
            {
                Db.tblEmployees.Remove(deleteRecord);

            };
            Db.SaveChanges();
            Message = "Record Deleted Successfully";
            return Message;

        }
        public EmployeeModel GetEditEmployee(int id)
        {
            EmployeeModel model = new EmployeeModel();
            internshipEntities Db = new internshipEntities();
            var getEmployeeData = Db.tblEmployees.Where(p => p.id == id).FirstOrDefault();
            if (getEmployeeData != null)
            {
                model.id = getEmployeeData.id;
                model.Emp_Name = getEmployeeData.Emp_Name;
                model.Emp_Address = getEmployeeData.Emp_Address;
                model.Emp_Mobileno = getEmployeeData.Emp_Mobileno;
                model.Emp_Emailid = getEmployeeData.Emp_Emailid;
                model.Emp_Qualification = getEmployeeData.Emp_Qualification;

            }

            return model;
        }
    }
}   


                
            


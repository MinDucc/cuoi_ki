using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CuoiKi.DAL
{
    public class EmployeeDAL
    {
        ManagementDFContext db = new ManagementDFContext();
        private static EmployeeDAL instance;

        public static EmployeeDAL Instance
        {
            get { if (instance == null) instance = new EmployeeDAL(); return EmployeeDAL.instance; }
            private set { EmployeeDAL.instance = value; }
        }

        public List<Employee> List_Employee()
        {
            List<Employee> lstEmloyee = new List<Employee>();
            foreach(var row in db.Employees)
            {
                if(row.employee_account != null)
                {
                    Employee e = new Employee()
                    {
                        employee_id = row.employee_id,
                        employee_account = row.employee_account,
                        employee_name = row.employee_name,
                        phone = row.phone,
                        address = row.address,
                        salary = row.salary,
                        birth = row.birth,
                        shift = row.shift
                    };
                    lstEmloyee.Add(e);
                }    
            }
            return lstEmloyee;
        }
        public string Get_Employee_Name(int id)
        {
            var result = from c in db.Employees
                         where c.employee_id == id
                         select c;
            return result.FirstOrDefault().employee_name;
        }
        public bool Add_Employee(Employee employee,Account acc)
        {
            try
            {
                db.Accounts.Add(acc);
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_Employee(int id)
        {
            try
            {
                var employee = from u in db.Employees where u.employee_id == id select u;
                string account = employee.FirstOrDefault().employee_account;
                employee.FirstOrDefault().employee_account = null;
                employee.FirstOrDefault().shift = null;
                employee.FirstOrDefault().salary = null;

                var acc = db.Accounts.Find(account);
                db.Accounts.Remove(acc);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_Employee(Employee e)
        {
            try
            {               
                var employee = from u in db.Employees where u.employee_id == e.employee_id select u;
                employee.FirstOrDefault().employee_name = e.employee_name;
                employee.FirstOrDefault().phone = e.phone;
                employee.FirstOrDefault().address = e.address;
                employee.FirstOrDefault().birth = e.birth;
                employee.FirstOrDefault().shift = e.shift;

                var acc = from a in db.Accounts where a.Name == e.employee_name select a;
                acc.FirstOrDefault().Name = e.employee_name;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

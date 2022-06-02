using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CuoiKi.DAL;
namespace CuoiKi.BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;

        public static EmployeeBLL Instance
        {
            get { if (instance == null) instance = new EmployeeBLL(); return EmployeeBLL.instance; }
            private set { EmployeeBLL.instance = value; }
        }
        public List<Employee> List_Employee()
        {
            return EmployeeDAL.Instance.List_Employee();
        } 
        public string Get_Employee_Name(int id)
        {
            return EmployeeDAL.Instance.Get_Employee_Name(id);
        }    
        public string Format_Name(string name)
        {
            char[] charArray = name.ToCharArray();
            bool foundSpace = true;           
            //sử dụng vòng lặp for lặp từng phần tử trong mảng
            for (int i = 0; i < charArray.Length; i++)
            {
                //sử dụng phương thức IsLetter() để kiểm tra từng phần tử có phải là một chữ cái
                if (Char.IsLetter(charArray[i]))
                {
                    if (foundSpace)
                    {
                        //nếu phải thì sử dụng phương thức ToUpper() để in hoa ký tự đầu
                        charArray[i] = Char.ToUpper(charArray[i]);
                        foundSpace = false;
                    }
                }
                else
                {
                    foundSpace = true;
                }
            }
            //chuyển đổi kiểu mảng char thàng string
            name = new string(charArray);
           return  name;
        }    
        public bool Add_Employee(Employee employee, Account acc)
        {
            employee.employee_name = Format_Name(employee.employee_name);
            acc.Name = Format_Name(acc.Name);
            return EmployeeDAL.Instance.Add_Employee(employee, acc);
        }
        
        public bool Delete_Employee(int id)
        {
            return EmployeeDAL.Instance.Delete_Employee(id);
        }

        public bool Update_Employee(Employee e)
        {
            return EmployeeDAL.Instance.Update_Employee(e);
        }
    }
}

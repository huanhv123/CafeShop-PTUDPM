using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafee.DTO;
namespace Cafee.DAO
{
    internal class EmployeesDAO
    {
        private static EmployeesDAO instance;
        public static EmployeesDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new EmployeesDAO(); }
                return EmployeesDAO.instance;
            }
            private set { EmployeesDAO.instance = value; }
        }
        private EmployeesDAO() { }
        private Employees newEmployees(DataRow row)
        {
            Employees employees = new Employees();
            employees.id = (int)row["ID"];
            employees.name = row["name"].ToString();
            employees.birthday = (DateTime)row["birthday"];
            employees.address = row["address"].ToString();
            employees.phone = row["phone"].ToString();
            employees.position = row["position"].ToString();
            employees.workingstatus = (int)row["workingstatus"];
            return employees;
        }
        public List<Employees> LoadEmployeesList()
        {
            List<Employees> employees1 = new List<Employees>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Employees");
            foreach (DataRow item in data.Rows)
            {
                Employees employees = newEmployees(item);
                employees1.Add(employees);
            }
            return employees1;
        }
        public Employees GetDetails(int id)
        {
            Employees employees = null;
            string query = "select * from Employees where id= @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    employees = newEmployees(row);
                }
            }
            return employees;
        }
        public List<Employees> GetDetailByName(String key)
        {
            List<Employees> employees1 = new List<Employees>();
            string query = "select * from Employees where name LIKE @key";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { key });
            if (result != null)
            {
                foreach (DataRow item in result.Rows)
                {
                    Employees employeess = newEmployees(item);
                    employees1.Add( employeess);
                }
            }
            return employees1;
        }
        
        public bool AddEmployees(Employees newEmployees)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Employees(name, birthday, address, phone, position, workingstatus) VALUES( @name , @birthday , @address , @phone , @position , @workingstatus )",
                new object[] { newEmployees.name, newEmployees.birthday, newEmployees.address, newEmployees.phone, newEmployees.position, newEmployees.workingstatus , newEmployees.id });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateEmployees(Employees newEmployees)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Employees SET name = @name , birthday = @birthday , address = @address , phone = @phone , position = @position , workingstatus = @workingstatus where id= @ID",
                new object[] { newEmployees.name, newEmployees.birthday, newEmployees.address, newEmployees.phone, newEmployees.position, newEmployees.workingstatus , newEmployees.id });
            if (result == true)
                return true;
            return false;
        }
        public bool DeteleEmployees(int id)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "DELETE FROM Employees where id= @id ",
                new object[] { id });
            if (result == true)
                return true;
            return false;
        }
    }
}

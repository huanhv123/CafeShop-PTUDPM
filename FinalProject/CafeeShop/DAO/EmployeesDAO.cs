using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Employees employees = new Employees()
            {
                id = (int)row["id"],
                name = row["name"].ToString(),
                birthday = (DateTime)row["birthday"],
                address = row["address"].ToString(),
                phone = row["phone"].ToString(),
                position = row["position"].ToString(),
                workingstatus = (int)row["workingstatus"],
            };
            return employees;
        }
        public List<Employees> LoadEmployeesList()
        {
            List<Employees> employees = new List<Employees>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Employees");
            foreach (DataRow item in data.Rows)
            {
                Employees employe = newEmployees(item);
                employees.Add(employe);
            }
            return employees;
        }
        public Employees DetailEmployees(int id)
        {
            Employees employe = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Employees where id= @id ", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                employe = newEmployees(item);
            }
            return employe;
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


﻿using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.BUS
{
    class EmployeesBUS
    {
        private static EmployeesBUS instance;

        public static EmployeesBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new EmployeesBUS(); }
                return EmployeesBUS.instance;
            }
            private set { EmployeesBUS.instance = value; }
        }
        private EmployeesBUS() { }
        public Employees GetDetail(int ID)
        {
            Employees employees = EmployeesDAO.Instance.DetailEmployees(ID);
            return employees;
        }
        public List<Employees> GetDetailByName(String key)
        {
            List<Employees> employees = EmployeesDAO.Instance.GetDetailByName(key);
            return employees;
        }
        public List<Employees> ListALLEmployees()
        {
            List<Employees> employees = EmployeesDAO.Instance.LoadEmployeesList();
            return employees;
        }

        public bool AddEmployees(Employees newEmployees)
        {
            return EmployeesDAO.Instance.AddEmployees(newEmployees);
        }
        public bool UpdateEmployees(Employees Employees)
        {
            return EmployeesDAO.Instance.UpdateEmployees(Employees);
        }
        public bool DeteleEmployees(int id)
        {
            return EmployeesDAO.Instance.DeteleEmployees(id);
        }
    }
}

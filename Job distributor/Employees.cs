using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseManagment;
using System.Data;

namespace Employees
{
    interface IPerson
    {
        void Register();
        void Find();
        void LogIn();
        void LogOut();
    }
    class Employee : IPerson, StoredType<Employee>
    {
        private int id;
        private string Name;
        private string SurName;
        private List<Tasks.Task> TaskList;
        private Tasks.Task ActualTask;

        public Employee createInstance(DataRow dataRow)
        {
            return new Employee(dataRow);
        }

        Employee(DataRow dataRow)
        {
            id = int.Parse(dataRow["id"].ToString());
            Name = dataRow["name"].ToString();
            SurName = dataRow["surname"].ToString();
        }

        public void Register()
        {

        }
        public void Find()
        {


        }
        public void LogIn()
        {

        }
        public void LogOut()
        {

        }

    }

}

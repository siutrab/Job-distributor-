using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    interface IPerson
    {
        void Register();
        void Find();
        void LogIn();
        void LogOut();
    }
    class Employee : IPerson
    {
        private string Name;
        private string SurName;
         

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

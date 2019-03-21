using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDistributor
{
    abstract class Validation
    {
        public abstract void getDataFromDataBase();
        public abstract void validate();
    }

    class Login : Validation
    {
        private bool correct = false;

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string password;

        public Login()
        {

        }


        public override void getDataFromDataBase()
        {

        }

        public override void validate()
        {

        }


        // safety stuff should be here
        public void setPassword(string pass)
        {
            password = pass;
        }
    }
}

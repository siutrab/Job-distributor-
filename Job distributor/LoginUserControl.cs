using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskDistributor
{
    public partial class LoginUserControl : UserControl
    {
        private Login loginObject;

    // CONSTRUCTOR
        public LoginUserControl()
        {
            loginObject = new Login();
            InitializeComponent();
        }

    // EVENTS
        private void LogInButton_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            setName();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            setPassword();
        }

    // METHODS
        private void setName()
        {
            loginObject.Name = NameTextBox.Text;
        }

        private void setPassword()
        {
            loginObject.setPassword(PasswordTextBox.Text);
        }

    }
}

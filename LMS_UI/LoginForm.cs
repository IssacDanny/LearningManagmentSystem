using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Library;
namespace LMS_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            usertypeDropDown.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string usertype = usertypeDropDown.SelectedItem.ToString();
            if (usernameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {

                SqlConnector.InsertData s = new LMS_Library.SqlConnector.InsertData();
                int ID = s.login(username, password, usertype);
                LoginModel lm = new LoginModel();
                lm.User_ID = ID;
                lm.Username = username;
                lm.Password = password;
                lm.User_type = usertype;
                if (ID != 0)
                {
                    if (usertype == "Admin")
                    {
                        this.Hide();
                        new AdminForm().Show();
                    }
                    else if (usertype == "Teacher")
                    {
                        this.Hide();
                        new Teacher_Profile(lm).Show();
                    }
                    else
                    {
                        this.Hide();
                        new Student_Profile(lm).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    }
}

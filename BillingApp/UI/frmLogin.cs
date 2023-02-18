using BillingApp.BLL;
using BillingApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;
        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Trim() is a string method. This method is used to removes all leading and trailing white-space characters from the current String object. 

            l.username = txt_Username.Text.Trim();
            l.password = txt_Password.Text.Trim();
            l.user_type = cmb_UserType.Text;

            bool success = dal.loginCheck(l);
            if(success == true)
            {
                MessageBox.Show("Login was Successful");
                loggedIn = l.username;

                switch (l.user_type)
                {
                    case "Admin":
                        {
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            this.Hide();

                        } break;
                    default:
                        {
                            MessageBox.Show("Invalid user_type");

                        }break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed, Try again");
            }
        }

       
    }
}

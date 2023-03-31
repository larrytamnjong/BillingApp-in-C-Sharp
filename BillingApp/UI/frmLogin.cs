

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
        BusinessLogicLayer login = new BusinessLogicLayer();


        public static string loggedIn = "";
        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            bool success = login.Login(txt_Username.Text, txt_Password.Text, cmb_UserType.Text);
            if (success == true)
            {
                MessageBox.Show("Login was Successful");
                loggedIn = txt_Username.Text.ToUpper();

                switch (cmb_UserType.Text)
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

                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid user_type");

                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed, Try again");
            }
        }

      
    }
}

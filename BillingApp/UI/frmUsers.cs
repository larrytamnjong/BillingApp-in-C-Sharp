

using System;
using System.Data;
using System.Windows.Forms;

using BillingApp.DataAccess;
using BillingApp.DataModel;

namespace BillingApp.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        //Create objects from userBLL and userDAL
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {


            //Getting data from the UI using userBLL
            u.first_name = txt_FirstName.Text;
            u.last_name = txt_LastName.Text;    
            u.email = txt_Email.Text;
            u.username = txt_Username.Text;
            u.password = txt_Password.Text; 
            u.contact = txt_Contact.Text;
            u.address = txt_Address.Text;
            u.gender = cmb_Gender.Text;
            u.user_type = cmb_UserType.Text;
            u.added_date = DateTime.Now;

            //Getting username of the loggedin user
            String loggedInUser = frmLogin.loggedIn;
            userBLL usr = dal.GetUserIDByUsername(loggedInUser);    
            u.added_by = usr.id;

            //Inserting Data into database using userDAL

            bool success = dal.Insert(u);

            if(success == true)
            {
                MessageBox.Show("User successfully created");
                //Call clear method on successful user creation
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }


        //Click on form select events from properties(The thunder bolt symbol) and double tap load
        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Create load event for page so data loads up on start
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void clear()
        {
            txt_Address.Text = "";
            txt_Contact.Text = "";
            txt_Email.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Password.Text = "";
            cmb_Gender.Text = "";
            cmb_UserType.Text = "";
            txt_UserId.Text = "";
            txt_Username.Text = "";



        }

        //Select Data grid view, click properties and go to RowHeaderMouseClick 
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get index of particular row
            int rowIndex = e.RowIndex;
            txt_UserId.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txt_FirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txt_LastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Username.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();  
            txt_Password.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txt_Contact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txt_Address.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmb_Gender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmb_UserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the values from UI
            u.id = Convert.ToInt32(txt_UserId.Text);
            u.first_name = txt_FirstName.Text;
            u.last_name = txt_LastName.Text;
            u.email = txt_Email.Text;
            u.username = txt_Username.Text;
            u.password = txt_Password.Text;
            u.contact = txt_Contact.Text;
            u.address = txt_Address.Text;
            u.gender = cmb_Gender.Text;
            u.user_type = cmb_UserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            //Updating Data in the Database
            bool succes = dal.Update(u);

            //if data is updated successfully then the value of success will be true else it will be false
            if(succes == true)
            {
                MessageBox.Show("User details updated successfully");
                clear();
            }
            else
            {
                MessageBox.Show("User details not updated");
            }
            //Create load event for page so data loads up 
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txt_UserId.Text);

            bool succes = dal.Delete(u);
            if(succes == true)
            {
                MessageBox.Show("User Deleted");
                clear();

            }
            else
            {
                MessageBox.Show("User not Deleted");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from users
            string keywords = txt_Search.Text;

            //Check if keyword has value
            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;   
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;   
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using DataAccessLayer.Model;

namespace BillingApp.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }



        TblUser user = new TblUser();
        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {


            //Getting data from the UI using object from TblUser
            user.FirstName = txt_FirstName.Text;
            user.LastName = txt_LastName.Text;
            user.Email = txt_Email.Text;
            user.Username = txt_Username.Text;
            user.Password = txt_Password.Text;
            user.Contact = txt_Contact.Text;
            user.Address = txt_Address.Text;
            user.Gender = cmb_Gender.Text;
            user.UserType = cmb_UserType.Text;
            user.AddedDate = DateTime.Now;

            //Getting username of the loggedin user
            String loggedInUser = frmLogin.loggedIn;

            //Get user Id of Logged in User
            user.AddedBy = businessLogicLayer.GetUserID(loggedInUser);

            //Inserting Data into database using 

            bool success = businessLogicLayer.Insert<TblUser>(user);

            if (success == true)
            {
                MessageBox.Show("User successfully created");
                //Call clear method on successful user creation
                clear();
                updateUserTable();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }


        }


        //Click on form select events from properties(The thunder bolt symbol) and double tap load
        private void frmUsers_Load(object sender, EventArgs e)
        {
            updateUserTable();
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

        private void updateUserTable()
        {
            //Fetch Data for user table
            this.tblUserBindingSource1.DataSource = businessLogicLayer.Select<TblUser>(inventoryManagerContext.TblUsers);
            
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
            user.Id = Convert.ToInt32(txt_UserId.Text);
            user.FirstName = txt_FirstName.Text;
            user.LastName = txt_LastName.Text;
            user.Email = txt_Email.Text;
            user.Username = txt_Username.Text;
            user.Password = txt_Password.Text;
            user.Contact = txt_Contact.Text;
            user.Address = txt_Address.Text;
            user.Gender = cmb_Gender.Text;
            user.UserType = cmb_UserType.Text;
            user.AddedDate = DateTime.Now;
            user.AddedBy = 1;

            //Updating Data in the Database
            bool succes = businessLogicLayer.Update<TblUser>(user);

            //if data is updated successfully then the value of success will be true else it will be false
            if (succes == true)
            {
                MessageBox.Show("User details updated successfully");
                clear();
            }
            else
            {
                MessageBox.Show("User details not updated");
            }
            //Create load event for page so data loads up 
            updateUserTable();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            user.Id = Convert.ToInt32(txt_UserId.Text);

            bool succes = businessLogicLayer.Delete<TblUser>(user);
            if (succes == true)
            {
                MessageBox.Show("User Deleted");
                clear();

            }
            else
            {
                MessageBox.Show("User not Deleted");
            }
            updateUserTable();

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from users
            string keywords = txt_Search.Text;

            //Check if keyword has value

            if (keywords != null)
            {
                this.tblUserBindingSource1.DataSource = businessLogicLayer.Search<TblUser>(inventoryManagerContext.TblUsers, u => u.FirstName == keywords.ToString());

            }
            else
            {
                updateUserTable();
            }
        }
    }
}

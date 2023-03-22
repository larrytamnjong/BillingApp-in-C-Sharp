
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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }
        deaCustBLL dc = new deaCustBLL();
        deaCustDAL dcDal = new deaCustDAL();
        userDAL uDal = new userDAL();
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dc.type = cmb_Type.Text;
            dc.name = txt_Name.Text;
            dc.email= txt_Email.Text;
            dc.contact = txt_Contact.Text;  
            dc.address = txt_Address.Text;
            dc.added_date = DateTime.Now;
            
            //Getting id of current user from username
            userBLL usr = uDal.GetUserIDByUsername(frmLogin.loggedIn);
            dc.added_by = usr.id;

            bool success = dcDal.Insert(dc);
            if(success == true)
            {
                MessageBox.Show("Dealer or Customer Inserted Successfully");
                clear();
                refreshGridTable();

            }
            else
            {
                MessageBox.Show("Dealer or Customer not added");
            }

        }
        public void clear()
        {
            txt_Address.Text = "";
            txt_Contact.Text = "";
            txt_Email.Text = "";
            txt_Name.Text = "";
            txt_DeaCustID.Text = "";

        }
      public void refreshGridTable()
        {
            DataTable dt = dcDal.Select();
           dgv_DeaCust.DataSource= dt;  

        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            refreshGridTable();
        }

        private void dgv_DeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; 
            txt_DeaCustID.Text = dgv_DeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmb_Type.Text = dgv_DeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Name.Text = dgv_DeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgv_DeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Contact.Text = dgv_DeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Address.Text = dgv_DeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txt_DeaCustID.Text);
            dc.type = cmb_Type.Text;
            dc.name = txt_Name.Text;
            dc.email = txt_Email.Text;
            dc.contact= txt_Contact.Text;
            dc.address = txt_Address.Text;
            dc.added_date= DateTime.Now;
            //Getting id of current user from username
            userBLL usr = uDal.GetUserIDByUsername(frmLogin.loggedIn);
            dc.added_by = usr.id;

            bool successful = dcDal.Update(dc);
            if(successful == true) 
            {
                MessageBox.Show("Dealer of customer updated successfully");
                clear();
                refreshGridTable(); 
            }
            else
            {
                MessageBox.Show("Dealer of customer updated successfully");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txt_DeaCustID.Text);

            bool success = dcDal.Delete(dc);    
            if(success == true)
            {
                MessageBox.Show("Dealer of Customer Deleted");
                clear();
                refreshGridTable(); 
            }
            else
            {
                MessageBox.Show("Failed to Delete Dealer of Customer");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keywords = txt_Search.Text;

            if(keywords != null)
            {
                DataTable dt = dcDal.Search(keywords);
                dgv_DeaCust.DataSource = dt;    
            }
            else
            {
                refreshGridTable();
            }
        }
    }
}


using DataAccessLayer.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        TblDeaCust deaCust = new TblDeaCust();
        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            deaCust.Type = cmb_Type.Text;
            deaCust.Name = txt_Name.Text;
            deaCust.Email = txt_Email.Text;
            deaCust.Contact = txt_Contact.Text;
            deaCust.Address = txt_Address.Text;
            deaCust.AddedDate = DateTime.Now;

            //Getting id of current user from username
            deaCust.AddedBy = businessLogicLayer.GetUserID(frmLogin.loggedIn);

            bool success = businessLogicLayer.Insert<TblDeaCust>(deaCust);
            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Inserted Successfully");
                clear();
                updateTable();

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
        public void updateTable()
        {
            this.tblDeaCustBindingSource.DataSource = businessLogicLayer.Select<TblDeaCust>(inventoryManagerContext.TblDeaCusts);

        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            updateTable();
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
            deaCust.Id = int.Parse(txt_DeaCustID.Text);
            deaCust.Type = cmb_Type.Text;
            deaCust.Name = txt_Name.Text;
            deaCust.Email = txt_Email.Text;
            deaCust.Contact = txt_Contact.Text;
            deaCust.Address = txt_Address.Text;
            deaCust.AddedDate = DateTime.Now;
            //Getting id of current user from username

            deaCust.AddedBy = businessLogicLayer.GetUserID(frmLogin.loggedIn);

            bool successful = businessLogicLayer.Update<TblDeaCust>(deaCust);
            if (successful == true)
            {
                MessageBox.Show("Dealer of customer updated successfully");
                clear();
                updateTable();
            }
            else
            {
                MessageBox.Show("Dealer of customer updated successfully");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deaCust.Id = int.Parse(txt_DeaCustID.Text);

            bool success = businessLogicLayer.Delete<TblDeaCust>(deaCust);
            if (success == true)
            {
                MessageBox.Show("Dealer of Customer Deleted");
                clear();
                updateTable();
            }
            else
            {
                MessageBox.Show("Failed to Delete Dealer of Customer");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keywords = txt_Search.Text;

            if (keywords != null)
            {
                this.tblDeaCustBindingSource.DataSource = businessLogicLayer.Search<TblDeaCust>(inventoryManagerContext.TblDeaCusts, dc => dc.Name == keywords.ToString());

            }
            else
            {
                updateTable();
            }
        }
    }
}

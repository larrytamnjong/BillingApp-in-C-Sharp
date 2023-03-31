
using DataAccessLayer.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();
        TblCategory category = new TblCategory();
        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Get values from Category Form
            category.Title = txt_Title.Text;
            category.Description = txt_Description.Text;
            category.AddedDate = DateTime.Now;

            //Getting ID of Logged in User
            string loggedInUser = frmLogin.loggedIn;


            //Passing the id of Logged in user in the added by field
            category.AddedBy = businessLogicLayer.GetUserID(loggedInUser);

            //Creating Boolean method to insert data into database

            bool success = businessLogicLayer.Insert<TblCategory>(category);

            //Insert successful will return true else function will return false
            if (success == true)
            {
                MessageBox.Show("Category Successfully Inserted");
                clear();
                updateTable();
            }
            else
            {
                MessageBox.Show("Category Failed to Insert");
            }


        }
        public void updateTable()
        {
            this.tblCategoryBindingSource.DataSource = businessLogicLayer.Select<TblCategory>(inventoryManagerContext.TblCategories);
        }
        public void clear()
        {
            txt_CategoryID.Text = "";
            txt_Description.Text = "";
            txt_Title.Text = "";
            txt_Search.Text = "";
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            //Display category in DataTable
            updateTable();
        }

        private void dgv_Categories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the Row Index of the Row Clicked on Data Grid View
            int RowIndex = e.RowIndex;
            txt_CategoryID.Text = dgv_Categories.Rows[RowIndex].Cells[0].Value.ToString();
            txt_Title.Text = dgv_Categories.Rows[RowIndex].Cells[1].Value.ToString();
            txt_Description.Text = dgv_Categories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get values from category form
            category.Id = int.Parse(txt_CategoryID.Text);
            category.Title = txt_Title.Text;
            category.Description = txt_Description.Text;
            category.AddedDate = DateTime.Now;

            //Getting ID of Logged in User
            string loggedInUser = frmLogin.loggedIn;

            //Passing the id of Logged in user in the added by field
            category.AddedBy = businessLogicLayer.GetUserID(loggedInUser);

            bool successful = businessLogicLayer.Update<TblCategory>(category);
            if (successful == true)
            {
                MessageBox.Show("Category successfully upgraded");
                clear();
                //Display category in DataTable
                updateTable();
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the ID of the Category we want to delete

            category.Id = int.Parse(txt_CategoryID.Text);

            bool successful = businessLogicLayer.Delete<TblCategory>(category);
            if (successful == true)
            {
                MessageBox.Show("Deleted");
                clear();
                //Display category in DataTable
                updateTable();
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        //Properties thunder symbol and textchange event
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords
            string keywords = txt_Search.Text;
            //Filter the categories based on the keywords

            if (keywords != null)
            {
                this.tblCategoryBindingSource.DataSource = businessLogicLayer.Search<TblCategory>(inventoryManagerContext.TblCategories, c => c.Title == keywords.ToString());
            }
            else
            {
                updateTable();
            }
        }
    }
}

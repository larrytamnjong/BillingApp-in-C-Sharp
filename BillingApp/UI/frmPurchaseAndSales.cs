
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Transactions;
using System.Windows.Forms;
using DataAccessLayer.Model;

namespace BillingApp.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }
      

        DataTable transactionDT = new DataTable();

        InventoryManagerContext inventoryManagerContext = new InventoryManagerContext();
     
        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            lbl_top.Text = frmUserDashboard.transactionType;

            //On load specify column for datagrid view table
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from the text box
            string keyword = txt_Search.Text;
            if (keyword == "")
            {
                txt_Name.Text = "";
                txt_Contact.Text = "";
                txt_Email.Text = "";
                txt_Address.Text = "";
            }
            else
            {
                //Get details if not null and set values 
                var dealerCustomer = businessLogicLayer.Search<TblDeaCust>(inventoryManagerContext.TblDeaCusts, dc => dc.Name == keyword);
                foreach (var deaCust in (List<TblDeaCust>)dealerCustomer)
                {
                    txt_Name.Text = deaCust.Name;
                    txt_Email.Text = deaCust.Email;
                    txt_Address.Text = deaCust.Address;
                    txt_Contact.Text = deaCust.Contact;

                }
            }
        }

        private void txt_ProductSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_ProductSearch.Text;

            if (keyword == "")
            {
                txt_ProductName.Text = "";
                txt_Inventory.Text = "";
                txt_Rate.Text = "";
                txt_Quantity.Text = "";
            }
            else
            {


                var product = businessLogicLayer.Search<TblProduct>(inventoryManagerContext.TblProducts, p => p.Name == keyword);
                foreach (var prod in (List<TblProduct>)product)
                {
                    txt_ProductName.Text = prod.Name;
                    txt_Inventory.Text = prod.Qty.ToString();
                    txt_Rate.Text = prod.Rate.ToString();

                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Get Product name, rate and quantity the customer wants to buy
            string productName = txt_ProductName.Text;
            decimal rate = decimal.Parse(txt_Rate.Text);
            decimal qty = decimal.Parse(txt_Quantity.Text);

            decimal total = rate * qty; //Calculate total
            //Calculate sub total
            decimal subTotal = decimal.Parse(txt_SubTotal.Text);
            subTotal = subTotal + total;
            //Check to make sure product is selected
            if (productName == "")
            {
                MessageBox.Show("No product has been selected");
            }
            else
            {
                //Create dataTable at top level because if you create datatable at this level for each product a new table will created
                transactionDT.Rows.Add(productName, rate, qty, total);

                dgv_Added_Products.DataSource = transactionDT;
                //Display Subtotal 
                txt_SubTotal.Text = subTotal.ToString();
                //Clear Text Boxes
                txt_ProductSearch.Text = "";
                txt_ProductName.Text = "";
                txt_Inventory.Text = "0.00";
                txt_Rate.Text = "0.00";
                txt_Quantity.Text = "0.00";
            }
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            string value = txt_Discount.Text;

            if (value == "")
            {
                MessageBox.Show("Please Add Discount First!");
            }
            else
            {
                decimal discount = decimal.Parse(txt_Discount.Text);
                decimal sutbTotal = decimal.Parse(txt_SubTotal.Text);

                decimal grandTotal = ((100 - discount) / 100) * sutbTotal;

                txt_GrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txt_Vat_TextChanged(object sender, EventArgs e)
        {
            string check = txt_GrandTotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calculate the discount and set the Grand total first");
            }
            else
            {
                decimal previousGT = decimal.Parse(txt_GrandTotal.Text);
                decimal vat = decimal.Parse(txt_Vat.Text);
                decimal grandTotalWithVat = ((100 + vat) / 100) * previousGT;

                txt_GrandTotal.Text = grandTotalWithVat.ToString();

            }
        }

        private void txt_PaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txt_GrandTotal.Text);
            decimal paidAmount = decimal.Parse(txt_PaidAmount.Text);
            decimal returnAmount = paidAmount - grandTotal;

            txt_ReturnAmount.Text = returnAmount.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Get the values from Purchases and Sales Form First

            //transactionsBLL transaction = new transactionsBLL();
            TblTransaction transaction = new TblTransaction();
            transaction.Type = lbl_top.Text;

            //Get the ID of the Dealer or Customer
            //Let's get name of the dealer or customer first
            string deaCustName = txt_Name.Text;
            //deaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);
            transaction.DeaCustId = 1;
            transaction.GrandTotal = Math.Round(decimal.Parse(txt_GrandTotal.Text), 2);
            transaction.TransactionDate = DateTime.Now;
            transaction.Tax = decimal.Parse(txt_Vat.Text);
            transaction.Discount = decimal.Parse(txt_Discount.Text);

            //Get the username of logged in user
           transaction.AddedBy = businessLogicLayer.GetUserID(frmLogin.loggedIn);

            bool isSuccessful = false;

           
                //Use for loop to insert Transaction Details
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    TblTransactionDetail transactionDetails = new TblTransactionDetail();
                    //Get the product name and convert it to id
                    string productName = transactionDT.Rows[i][0].ToString();
                   
                    
                    transactionDetails.ProductId = 1;
                    transactionDetails.Rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetails.Qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetails.Total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetails.DeaCustId = 1;
                    transactionDetails.AddedDate = DateTime.Now;
                    transactionDetails.AddedBy = 1;

                    //Increase of Decrease Product Quantity based on Purchase of sales
                    string transactionType = lbl_top.Text;
                    bool x = true;
                    if (transactionType == "PURCHASE MANAGEMENT")
                    {
                       // x = pDAL.IncreaseProduct(transationDetails.product_id, transationDetails.qty);
                    }
                    else
                    {
                       // x = pDAL.DecreaseProduct(transationDetails.product_id, transationDetails.qty);
                    }


                //Insert Transaction Details inside the database
                bool y = businessLogicLayer.Insert<TblTransactionDetail>(transactionDetails); ;
                    isSuccessful = y && x;

                }
                if (isSuccessful == true)
                {
                    
                    //Code to print Bill

                    var printer = new DGVPrinter();
                    printer.Title = "\r\n\r\nBILL AND STOCK ";
                    printer.SubTitle = "Bamenda, Cameroon \r\n\r\n Phone: 680162416\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Center;
                    printer.Footer = "Discount: " + txt_Discount.Text + "% \r\n" + "VAT: " + txt_Vat.Text + "% \r\n" + "Grand Total: " + txt_GrandTotal.Text + "\r\n\r\n" + "Thank you for doing buisness.";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgv_Added_Products);

                    MessageBox.Show("Transaction is completed successfully");
                    //Clear the Data Grid View and Clear all the Text Boxes
                    dgv_Added_Products.DataSource = null;
                    dgv_Added_Products.Rows.Clear();
                    txt_ProductSearch.Text = "";
                    txt_ProductName.Text = "";
                    txt_PaidAmount.Text = "0";
                    txt_GrandTotal.Text = "0";
                    txt_Name.Text = "";
                    txt_Email.Text = "";
                    txt_Contact.Text = "";
                    txt_Discount.Text = "0";
                    txt_ProductSearch.Text = "";
                    txt_Quantity.Text = "0";
                    txt_ReturnAmount.Text = "0";
                    txt_SubTotal.Text = "0";
                    txt_GrandTotal.Text = "0";
                    txt_Vat.Text = "0";
                    txt_Rate.Text = "0";
                    txt_Inventory.Text = "0";
                    txt_Address.Text = "";




                }
                else
                {
                    MessageBox.Show("Transaction failed");
                }
          

        }

        private void pnlDeaCust_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


using BillingApp.BLL;
using BillingApp.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BillingApp.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }
        deaCustDAL dcDAL = new deaCustDAL();
        productsDAL pDAL = new productsDAL();
        userDAL uDAL = new userDAL();   
        transactionDAL tDAL = new transactionDAL();
        transactionDetailDAL tdDAL = new transactionDetailDAL();

        DataTable transactionDT = new DataTable();
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
            if(keyword == "")
            {
                txt_Name.Text = "";
                txt_Contact.Text = "";
                txt_Email.Text = "";
                txt_Address.Text = "";
            }
            else
            {
                //Get details if not null and set values 
                deaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

                txt_Name.Text = dc.name;
                txt_Email.Text = dc.email;
                txt_Address.Text = dc.address;
                txt_Contact.Text = dc.contact;
            }
        }

        private void txt_ProductSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_ProductSearch.Text;

            if(keyword == ""){
                txt_ProductName.Text = "";
                txt_Inventory.Text = "";
                txt_Rate.Text = "";
                txt_Quantity.Text = "";
            }
            else
            {
                productsBLL p = pDAL.GetProductsForTransaction(keyword);
                txt_ProductName.Text = p.name;
                txt_Inventory.Text = p.qty.ToString();
                txt_Rate.Text = p.rate.ToString();
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
            if(productName == "")
            {
                MessageBox.Show("No product has been selected");
            }
            else
            {
                //Create dataTable at top level because if you create datatable at this level for each product a new table will created
                transactionDT.Rows.Add(productName, rate, qty, total);

                dgv_Added_Products.DataSource= transactionDT;
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

            if(value == "")
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
            if(check == "")
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

            transactionsBLL transaction = new transactionsBLL();
            transaction.type = lbl_top.Text;

            //Get the ID of the Dealer or Customer
            //Let's get name of the dealer or customer first
            string deaCustName = txt_Name.Text;
            deaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);
            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txt_GrandTotal.Text),2);      
            transaction.transaction_date= DateTime.Now; 
            transaction.tax = decimal.Parse(txt_Vat.Text);
            transaction.discount = decimal.Parse(txt_Discount.Text);

            //Get the username of logged in user
            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetUserIDByUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            bool isSuccessful = false;

            //Add transactions in references inorder to use TransactionScope
            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //create a boolean value and insert transaction
                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                //Use for loop to insert Transaction Details
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    transationDetailsBLL transationDetails = new transationDetailsBLL();
                    //Get the product name and convert it to id
                    string productName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetProductIDFromName(productName);

                    transationDetails.product_id = p.id;
                    transationDetails.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transationDetails.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transationDetails.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transationDetails.dea_cust_id = dc.id;
                    transationDetails.added_date = DateTime.Now;
                    transationDetails.added_by = u.id;

                    //Increase of Decrease Product Quantity based on Purchase of sales
                    string transactionType = lbl_top.Text;
                    bool x = false;
                    if(transactionType == "PURCHASE MANAGEMENT")
                    {
                         x = pDAL.IncreaseProduct(transationDetails.product_id, transationDetails.qty);
                    }
                    else
                    {
                         x = pDAL.DecreaseProduct(transationDetails.product_id, transationDetails.qty);
                    }


                    //Insert Transaction Details inside the database
                    bool y = tdDAL.InsertTransactionDetail(transationDetails);
                    isSuccessful = w && y && x;

                }
                if (isSuccessful == true)
                {
                    scope.Complete();
                    //Code to print Bill

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "\r\n\r\nBILL AND STOCK ";
                    printer.SubTitle = "Bamenda, Cameroon \r\n\r\n Phone: 680162416\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns= true;
                    printer.HeaderCellAlignment= StringAlignment.Center;
                    printer.Footer = "Discount: "+ txt_Discount.Text + "% \r\n" + "VAT: " + txt_Vat.Text + "% \r\n" + "Grand Total: "+ txt_GrandTotal.Text + "\r\n\r\n" + "Thank you for doing buisness.";
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
                    txt_Quantity.Text= "0";
                    txt_ReturnAmount.Text = "0";
                    txt_SubTotal .Text = "0";   
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

        }
    }
}


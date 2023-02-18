namespace BillingApp.UI
{
    partial class frmPurchaseAndSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.topPanel = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbl_top = new System.Windows.Forms.Label();
            this.pnlDeaCust = new System.Windows.Forms.Panel();
            this.dtbBillDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_BillDate = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_DeacustTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.txt_Inventory = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductSearch = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductSearch = new System.Windows.Forms.Label();
            this.lbl_ProductTitle = new System.Windows.Forms.Label();
            this.pnlDataGridVie = new System.Windows.Forms.Panel();
            this.dgv_Added_Products = new System.Windows.Forms.DataGridView();
            this.lblPnlTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_ReturnAmount = new System.Windows.Forms.TextBox();
            this.txt_PaidAmount = new System.Windows.Forms.TextBox();
            this.txt_GrandTotal = new System.Windows.Forms.TextBox();
            this.txt_Vat = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.lbl_ReturnAmount = new System.Windows.Forms.Label();
            this.lbl_PaidAmount = new System.Windows.Forms.Label();
            this.lbl_GrandTotal = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Vat = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.lblCalculationProperty = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlDeaCust.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDataGridVie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Added_Products)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.topPanel.Controls.Add(this.picClose);
            this.topPanel.Controls.Add(this.lbl_top);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1557, 63);
            this.topPanel.TabIndex = 32;
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1499, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(46, 41);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top.Location = new System.Drawing.Point(571, 22);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(365, 22);
            this.lbl_top.TabIndex = 0;
            this.lbl_top.Text = "PURCHASE AND SALES MANGEMENT";
            // 
            // pnlDeaCust
            // 
            this.pnlDeaCust.Controls.Add(this.dtbBillDate);
            this.pnlDeaCust.Controls.Add(this.txt_Address);
            this.pnlDeaCust.Controls.Add(this.txt_Contact);
            this.pnlDeaCust.Controls.Add(this.txt_Email);
            this.pnlDeaCust.Controls.Add(this.txt_Name);
            this.pnlDeaCust.Controls.Add(this.txt_Search);
            this.pnlDeaCust.Controls.Add(this.lbl_BillDate);
            this.pnlDeaCust.Controls.Add(this.lbl_Address);
            this.pnlDeaCust.Controls.Add(this.lbl_Contact);
            this.pnlDeaCust.Controls.Add(this.lbl_Name);
            this.pnlDeaCust.Controls.Add(this.lbl_Email);
            this.pnlDeaCust.Controls.Add(this.lbl_Search);
            this.pnlDeaCust.Controls.Add(this.lbl_DeacustTitle);
            this.pnlDeaCust.Location = new System.Drawing.Point(12, 69);
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(1545, 143);
            this.pnlDeaCust.TabIndex = 33;
            // 
            // dtbBillDate
            // 
            this.dtbBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBillDate.Location = new System.Drawing.Point(1214, 44);
            this.dtbBillDate.Name = "dtbBillDate";
            this.dtbBillDate.Size = new System.Drawing.Size(341, 27);
            this.dtbBillDate.TabIndex = 13;
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(854, 43);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(252, 58);
            this.txt_Address.TabIndex = 12;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact.Location = new System.Drawing.Point(467, 103);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(262, 27);
            this.txt_Contact.TabIndex = 11;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(467, 50);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(262, 27);
            this.txt_Email.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(96, 99);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(262, 27);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(96, 46);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(262, 27);
            this.txt_Search.TabIndex = 8;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_BillDate
            // 
            this.lbl_BillDate.AutoSize = true;
            this.lbl_BillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillDate.Location = new System.Drawing.Point(1121, 48);
            this.lbl_BillDate.Name = "lbl_BillDate";
            this.lbl_BillDate.Size = new System.Drawing.Size(74, 20);
            this.lbl_BillDate.TabIndex = 7;
            this.lbl_BillDate.Text = "Bill Date";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(777, 46);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(71, 20);
            this.lbl_Address.TabIndex = 5;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(394, 106);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(67, 20);
            this.lbl_Contact.TabIndex = 4;
            this.lbl_Contact.Text = "Contact";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(4, 102);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 20);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(394, 53);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 20);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(4, 46);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(62, 20);
            this.lbl_Search.TabIndex = 1;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_DeacustTitle
            // 
            this.lbl_DeacustTitle.AutoSize = true;
            this.lbl_DeacustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeacustTitle.Location = new System.Drawing.Point(4, 4);
            this.lbl_DeacustTitle.Name = "lbl_DeacustTitle";
            this.lbl_DeacustTitle.Size = new System.Drawing.Size(254, 20);
            this.lbl_DeacustTitle.TabIndex = 0;
            this.lbl_DeacustTitle.Text = "Dealer and Customer Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txt_Quantity);
            this.panel1.Controls.Add(this.txt_Rate);
            this.panel1.Controls.Add(this.txt_Inventory);
            this.panel1.Controls.Add(this.txt_ProductName);
            this.panel1.Controls.Add(this.txt_ProductSearch);
            this.panel1.Controls.Add(this.lbl_Quantity);
            this.panel1.Controls.Add(this.lbl_Rate);
            this.panel1.Controls.Add(this.lbl_Inventory);
            this.panel1.Controls.Add(this.lbl_ProductName);
            this.panel1.Controls.Add(this.lbl_ProductSearch);
            this.panel1.Controls.Add(this.lbl_ProductTitle);
            this.panel1.Location = new System.Drawing.Point(12, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 169);
            this.panel1.TabIndex = 34;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1412, 57);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 33);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(1265, 59);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(116, 27);
            this.txt_Quantity.TabIndex = 10;
            this.txt_Quantity.Text = "0";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rate.Location = new System.Drawing.Point(1034, 59);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(113, 27);
            this.txt_Rate.TabIndex = 9;
            // 
            // txt_Inventory
            // 
            this.txt_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inventory.Location = new System.Drawing.Point(787, 59);
            this.txt_Inventory.Name = "txt_Inventory";
            this.txt_Inventory.Size = new System.Drawing.Size(149, 27);
            this.txt_Inventory.TabIndex = 8;
            this.txt_Inventory.Text = "0";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(467, 55);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(181, 27);
            this.txt_ProductName.TabIndex = 7;
            // 
            // txt_ProductSearch
            // 
            this.txt_ProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductSearch.Location = new System.Drawing.Point(96, 58);
            this.txt_ProductSearch.Name = "txt_ProductSearch";
            this.txt_ProductSearch.Size = new System.Drawing.Size(232, 27);
            this.txt_ProductSearch.TabIndex = 6;
            this.txt_ProductSearch.TextChanged += new System.EventHandler(this.txt_ProductSearch_TextChanged);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(1188, 61);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(71, 20);
            this.lbl_Quantity.TabIndex = 5;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rate.Location = new System.Drawing.Point(972, 62);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(44, 20);
            this.lbl_Rate.TabIndex = 4;
            this.lbl_Rate.Text = "Rate";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(705, 61);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(76, 20);
            this.lbl_Inventory.TabIndex = 3;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(392, 58);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(53, 20);
            this.lbl_ProductName.TabIndex = 2;
            this.lbl_ProductName.Text = "Name";
            // 
            // lbl_ProductSearch
            // 
            this.lbl_ProductSearch.AutoSize = true;
            this.lbl_ProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductSearch.Location = new System.Drawing.Point(4, 58);
            this.lbl_ProductSearch.Name = "lbl_ProductSearch";
            this.lbl_ProductSearch.Size = new System.Drawing.Size(62, 20);
            this.lbl_ProductSearch.TabIndex = 1;
            this.lbl_ProductSearch.Text = "Search";
            // 
            // lbl_ProductTitle
            // 
            this.lbl_ProductTitle.AutoSize = true;
            this.lbl_ProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductTitle.Location = new System.Drawing.Point(8, 14);
            this.lbl_ProductTitle.Name = "lbl_ProductTitle";
            this.lbl_ProductTitle.Size = new System.Drawing.Size(140, 20);
            this.lbl_ProductTitle.TabIndex = 0;
            this.lbl_ProductTitle.Text = "Product Details";
            // 
            // pnlDataGridVie
            // 
            this.pnlDataGridVie.Controls.Add(this.dgv_Added_Products);
            this.pnlDataGridVie.Controls.Add(this.lblPnlTitle);
            this.pnlDataGridVie.Location = new System.Drawing.Point(12, 404);
            this.pnlDataGridVie.Name = "pnlDataGridVie";
            this.pnlDataGridVie.Size = new System.Drawing.Size(729, 388);
            this.pnlDataGridVie.TabIndex = 35;
            // 
            // dgv_Added_Products
            // 
            this.dgv_Added_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Added_Products.Location = new System.Drawing.Point(3, 34);
            this.dgv_Added_Products.Name = "dgv_Added_Products";
            this.dgv_Added_Products.RowHeadersWidth = 51;
            this.dgv_Added_Products.RowTemplate.Height = 24;
            this.dgv_Added_Products.Size = new System.Drawing.Size(723, 351);
            this.dgv_Added_Products.TabIndex = 1;
            // 
            // lblPnlTitle
            // 
            this.lblPnlTitle.AutoSize = true;
            this.lblPnlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnlTitle.Location = new System.Drawing.Point(5, 11);
            this.lblPnlTitle.Name = "lblPnlTitle";
            this.lblPnlTitle.Size = new System.Drawing.Size(142, 20);
            this.lblPnlTitle.TabIndex = 0;
            this.lblPnlTitle.Text = "Added Products";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.txt_ReturnAmount);
            this.panel2.Controls.Add(this.txt_PaidAmount);
            this.panel2.Controls.Add(this.txt_GrandTotal);
            this.panel2.Controls.Add(this.txt_Vat);
            this.panel2.Controls.Add(this.txt_Discount);
            this.panel2.Controls.Add(this.txt_SubTotal);
            this.panel2.Controls.Add(this.lbl_ReturnAmount);
            this.panel2.Controls.Add(this.lbl_PaidAmount);
            this.panel2.Controls.Add(this.lbl_GrandTotal);
            this.panel2.Controls.Add(this.lbl_Discount);
            this.panel2.Controls.Add(this.lbl_Vat);
            this.panel2.Controls.Add(this.lbl_SubTotal);
            this.panel2.Controls.Add(this.lblCalculationProperty);
            this.panel2.Location = new System.Drawing.Point(799, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 398);
            this.panel2.TabIndex = 36;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(237, 325);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(171, 45);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_ReturnAmount
            // 
            this.txt_ReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReturnAmount.ForeColor = System.Drawing.Color.Red;
            this.txt_ReturnAmount.Location = new System.Drawing.Point(149, 266);
            this.txt_ReturnAmount.Name = "txt_ReturnAmount";
            this.txt_ReturnAmount.ReadOnly = true;
            this.txt_ReturnAmount.Size = new System.Drawing.Size(324, 30);
            this.txt_ReturnAmount.TabIndex = 12;
            // 
            // txt_PaidAmount
            // 
            this.txt_PaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PaidAmount.Location = new System.Drawing.Point(149, 215);
            this.txt_PaidAmount.Name = "txt_PaidAmount";
            this.txt_PaidAmount.Size = new System.Drawing.Size(324, 27);
            this.txt_PaidAmount.TabIndex = 11;
            this.txt_PaidAmount.TextChanged += new System.EventHandler(this.txt_PaidAmount_TextChanged);
            // 
            // txt_GrandTotal
            // 
            this.txt_GrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GrandTotal.Location = new System.Drawing.Point(149, 169);
            this.txt_GrandTotal.Name = "txt_GrandTotal";
            this.txt_GrandTotal.ReadOnly = true;
            this.txt_GrandTotal.Size = new System.Drawing.Size(324, 27);
            this.txt_GrandTotal.TabIndex = 10;
            // 
            // txt_Vat
            // 
            this.txt_Vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Vat.Location = new System.Drawing.Point(149, 129);
            this.txt_Vat.Name = "txt_Vat";
            this.txt_Vat.Size = new System.Drawing.Size(324, 27);
            this.txt_Vat.TabIndex = 9;
            this.txt_Vat.TextChanged += new System.EventHandler(this.txt_Vat_TextChanged);
            // 
            // txt_Discount
            // 
            this.txt_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(149, 78);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(324, 27);
            this.txt_Discount.TabIndex = 8;
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.Location = new System.Drawing.Point(149, 41);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(324, 27);
            this.txt_SubTotal.TabIndex = 7;
            this.txt_SubTotal.Text = "0";
            // 
            // lbl_ReturnAmount
            // 
            this.lbl_ReturnAmount.AutoSize = true;
            this.lbl_ReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnAmount.Location = new System.Drawing.Point(7, 266);
            this.lbl_ReturnAmount.Name = "lbl_ReturnAmount";
            this.lbl_ReturnAmount.Size = new System.Drawing.Size(121, 20);
            this.lbl_ReturnAmount.TabIndex = 6;
            this.lbl_ReturnAmount.Text = "Return Amount";
            // 
            // lbl_PaidAmount
            // 
            this.lbl_PaidAmount.AutoSize = true;
            this.lbl_PaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaidAmount.Location = new System.Drawing.Point(7, 215);
            this.lbl_PaidAmount.Name = "lbl_PaidAmount";
            this.lbl_PaidAmount.Size = new System.Drawing.Size(104, 20);
            this.lbl_PaidAmount.TabIndex = 5;
            this.lbl_PaidAmount.Text = "Paid Amount";
            // 
            // lbl_GrandTotal
            // 
            this.lbl_GrandTotal.AutoSize = true;
            this.lbl_GrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GrandTotal.Location = new System.Drawing.Point(7, 169);
            this.lbl_GrandTotal.Name = "lbl_GrandTotal";
            this.lbl_GrandTotal.Size = new System.Drawing.Size(97, 20);
            this.lbl_GrandTotal.TabIndex = 4;
            this.lbl_GrandTotal.Text = "Grand Total";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(7, 85);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(108, 20);
            this.lbl_Discount.TabIndex = 3;
            this.lbl_Discount.Text = "Discount (%)";
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vat.Location = new System.Drawing.Point(7, 129);
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(73, 20);
            this.lbl_Vat.TabIndex = 2;
            this.lbl_Vat.Text = "VAT (%)";
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.Location = new System.Drawing.Point(7, 44);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(80, 20);
            this.lbl_SubTotal.TabIndex = 1;
            this.lbl_SubTotal.Text = "Sub Total";
            // 
            // lblCalculationProperty
            // 
            this.lblCalculationProperty.AutoSize = true;
            this.lblCalculationProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculationProperty.Location = new System.Drawing.Point(4, 10);
            this.lblCalculationProperty.Name = "lblCalculationProperty";
            this.lblCalculationProperty.Size = new System.Drawing.Size(169, 20);
            this.lblCalculationProperty.TabIndex = 0;
            this.lblCalculationProperty.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1557, 825);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDataGridVie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDeaCust);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase and Sales";
            this.Load += new System.EventHandler(this.frmPurchaseAndSales_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlDeaCust.ResumeLayout(false);
            this.pnlDeaCust.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDataGridVie.ResumeLayout(false);
            this.pnlDataGridVie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Added_Products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Panel pnlDeaCust;
        private System.Windows.Forms.Label lbl_BillDate;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_DeacustTitle;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DateTimePicker dtbBillDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ProductSearch;
        private System.Windows.Forms.Label lbl_ProductTitle;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.TextBox txt_Inventory;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductSearch;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnlDataGridVie;
        private System.Windows.Forms.DataGridView dgv_Added_Products;
        private System.Windows.Forms.Label lblPnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_PaidAmount;
        private System.Windows.Forms.Label lbl_GrandTotal;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Vat;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.Label lblCalculationProperty;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_ReturnAmount;
        private System.Windows.Forms.TextBox txt_PaidAmount;
        private System.Windows.Forms.TextBox txt_GrandTotal;
        private System.Windows.Forms.TextBox txt_Vat;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label lbl_ReturnAmount;
    }
}
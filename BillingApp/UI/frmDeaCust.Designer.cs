namespace BillingApp.UI
{
    partial class frmDeaCust
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
            topPanel = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_top = new System.Windows.Forms.Label();
            lbl_Type = new System.Windows.Forms.Label();
            txt_DeaCustID = new System.Windows.Forms.TextBox();
            lbl_DeaCustID = new System.Windows.Forms.Label();
            cmb_Type = new System.Windows.Forms.ComboBox();
            txt_Name = new System.Windows.Forms.TextBox();
            lbl_Name = new System.Windows.Forms.Label();
            txt_Email = new System.Windows.Forms.TextBox();
            lbl_Email = new System.Windows.Forms.Label();
            txt_Contact = new System.Windows.Forms.TextBox();
            lbl_Contact = new System.Windows.Forms.Label();
            txt_Address = new System.Windows.Forms.TextBox();
            lbl_Address = new System.Windows.Forms.Label();
            btn_Add = new System.Windows.Forms.Button();
            btn_Update = new System.Windows.Forms.Button();
            btn_Delete = new System.Windows.Forms.Button();
            dgv_DeaCust = new System.Windows.Forms.DataGridView();
            txt_Search = new System.Windows.Forms.TextBox();
            lbl_Search = new System.Windows.Forms.Label();
            tblDeaCustBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DeaCust).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblDeaCustBindingSource).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            topPanel.Controls.Add(picClose);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(lbl_top);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1252, 79);
            topPanel.TabIndex = 31;
            // 
            // picClose
            // 
            picClose.Image = (System.Drawing.Image)resources.GetObject("picClose.Image");
            picClose.Location = new System.Drawing.Point(1194, 15);
            picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(46, 51);
            picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picClose.TabIndex = 2;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1351, 11);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(40, 51);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbl_top
            // 
            lbl_top.AutoSize = true;
            lbl_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_top.Location = new System.Drawing.Point(415, 26);
            lbl_top.Name = "lbl_top";
            lbl_top.Size = new System.Drawing.Size(396, 22);
            lbl_top.TabIndex = 0;
            lbl_top.Text = "DEALER AND CUSTOMER MANAGEMENT";
            // 
            // lbl_Type
            // 
            lbl_Type.AutoSize = true;
            lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Type.Location = new System.Drawing.Point(37, 185);
            lbl_Type.Name = "lbl_Type";
            lbl_Type.Size = new System.Drawing.Size(45, 20);
            lbl_Type.TabIndex = 32;
            lbl_Type.Text = "Type";
            // 
            // txt_DeaCustID
            // 
            txt_DeaCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_DeaCustID.Location = new System.Drawing.Point(159, 115);
            txt_DeaCustID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_DeaCustID.Name = "txt_DeaCustID";
            txt_DeaCustID.ReadOnly = true;
            txt_DeaCustID.Size = new System.Drawing.Size(267, 27);
            txt_DeaCustID.TabIndex = 35;
            // 
            // lbl_DeaCustID
            // 
            lbl_DeaCustID.AutoSize = true;
            lbl_DeaCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_DeaCustID.Location = new System.Drawing.Point(27, 119);
            lbl_DeaCustID.Name = "lbl_DeaCustID";
            lbl_DeaCustID.Size = new System.Drawing.Size(116, 20);
            lbl_DeaCustID.TabIndex = 34;
            lbl_DeaCustID.Text = "Dealer/Cus ID";
            // 
            // cmb_Type
            // 
            cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_Type.FormattingEnabled = true;
            cmb_Type.Items.AddRange(new object[] { "Dealer", "Customer" });
            cmb_Type.Location = new System.Drawing.Point(159, 181);
            cmb_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_Type.Name = "cmb_Type";
            cmb_Type.Size = new System.Drawing.Size(267, 28);
            cmb_Type.TabIndex = 36;
            // 
            // txt_Name
            // 
            txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Name.Location = new System.Drawing.Point(159, 251);
            txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new System.Drawing.Size(267, 27);
            txt_Name.TabIndex = 38;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Name.Location = new System.Drawing.Point(37, 260);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new System.Drawing.Size(53, 20);
            lbl_Name.TabIndex = 37;
            lbl_Name.Text = "Name";
            // 
            // txt_Email
            // 
            txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Email.Location = new System.Drawing.Point(159, 322);
            txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new System.Drawing.Size(267, 27);
            txt_Email.TabIndex = 40;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Email.Location = new System.Drawing.Point(39, 331);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new System.Drawing.Size(51, 20);
            lbl_Email.TabIndex = 39;
            lbl_Email.Text = "Email";
            // 
            // txt_Contact
            // 
            txt_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Contact.Location = new System.Drawing.Point(159, 395);
            txt_Contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Contact.Name = "txt_Contact";
            txt_Contact.Size = new System.Drawing.Size(267, 27);
            txt_Contact.TabIndex = 42;
            // 
            // lbl_Contact
            // 
            lbl_Contact.AutoSize = true;
            lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Contact.Location = new System.Drawing.Point(27, 399);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new System.Drawing.Size(67, 20);
            lbl_Contact.TabIndex = 41;
            lbl_Contact.Text = "Contact";
            // 
            // txt_Address
            // 
            txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Address.Location = new System.Drawing.Point(159, 462);
            txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new System.Drawing.Size(267, 138);
            txt_Address.TabIndex = 44;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Address.Location = new System.Drawing.Point(27, 466);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new System.Drawing.Size(71, 20);
            lbl_Address.TabIndex = 43;
            lbl_Address.Text = "Address";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Add.Location = new System.Drawing.Point(21, 689);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(137, 46);
            btn_Add.TabIndex = 45;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = System.Drawing.Color.Orange;
            btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Update.Location = new System.Drawing.Point(175, 689);
            btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new System.Drawing.Size(137, 46);
            btn_Update.TabIndex = 46;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = System.Drawing.Color.Red;
            btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Delete.Location = new System.Drawing.Point(315, 689);
            btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(137, 46);
            btn_Delete.TabIndex = 47;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // dgv_DeaCust
            // 
            dgv_DeaCust.AutoGenerateColumns = false;
            dgv_DeaCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DeaCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, contactDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, addedDateDataGridViewTextBoxColumn, addedByDataGridViewTextBoxColumn });
            dgv_DeaCust.DataSource = tblDeaCustBindingSource;
            dgv_DeaCust.Location = new System.Drawing.Point(478, 151);
            dgv_DeaCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_DeaCust.Name = "dgv_DeaCust";
            dgv_DeaCust.RowHeadersWidth = 51;
            dgv_DeaCust.RowTemplate.Height = 24;
            dgv_DeaCust.Size = new System.Drawing.Size(744, 584);
            dgv_DeaCust.TabIndex = 48;
            dgv_DeaCust.RowHeaderMouseClick += dgv_DeaCust_RowHeaderMouseClick;
            // 
            // txt_Search
            // 
            txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Search.Location = new System.Drawing.Point(674, 102);
            txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new System.Drawing.Size(463, 27);
            txt_Search.TabIndex = 50;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // lbl_Search
            // 
            lbl_Search.AutoSize = true;
            lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Search.Location = new System.Drawing.Point(551, 106);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new System.Drawing.Size(62, 20);
            lbl_Search.TabIndex = 49;
            lbl_Search.Text = "Search";
            // 
            // tblDeaCustBindingSource
            // 
            tblDeaCustBindingSource.DataSource = typeof(DataAccessLayer.Model.TblDeaCust);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            addedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            addedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            addedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            addedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmDeaCust
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ScrollBar;
            ClientSize = new System.Drawing.Size(1252, 851);
            Controls.Add(txt_Search);
            Controls.Add(lbl_Search);
            Controls.Add(dgv_DeaCust);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(txt_Address);
            Controls.Add(lbl_Address);
            Controls.Add(txt_Contact);
            Controls.Add(lbl_Contact);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Name);
            Controls.Add(lbl_Name);
            Controls.Add(cmb_Type);
            Controls.Add(txt_DeaCustID);
            Controls.Add(lbl_DeaCustID);
            Controls.Add(lbl_Type);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmDeaCust";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmDeaCust";
            Load += frmDeaCust_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DeaCust).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblDeaCustBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txt_DeaCustID;
        private System.Windows.Forms.Label lbl_DeaCustID;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_DeaCust;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblDeaCustBindingSource;
    }
}
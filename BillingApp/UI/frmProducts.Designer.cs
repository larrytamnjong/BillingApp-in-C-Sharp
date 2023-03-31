namespace BillingApp.UI
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            topPanel = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_top = new System.Windows.Forms.Label();
            lbl_ProductID = new System.Windows.Forms.Label();
            txt_ProductID = new System.Windows.Forms.TextBox();
            txt_Name = new System.Windows.Forms.TextBox();
            lbl_Name = new System.Windows.Forms.Label();
            lbl_Category = new System.Windows.Forms.Label();
            txt_Description = new System.Windows.Forms.TextBox();
            lbl_Description = new System.Windows.Forms.Label();
            txt_Rate = new System.Windows.Forms.TextBox();
            lbl_Rate = new System.Windows.Forms.Label();
            cmb_Category = new System.Windows.Forms.ComboBox();
            dgv_products = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tblProductBindingSource1 = new System.Windows.Forms.BindingSource(components);
            tblProductBindingSource = new System.Windows.Forms.BindingSource(components);
            txt_Search = new System.Windows.Forms.TextBox();
            lbl_Search = new System.Windows.Forms.Label();
            btn_Add = new System.Windows.Forms.Button();
            btn_Delete = new System.Windows.Forms.Button();
            btn_Update = new System.Windows.Forms.Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).BeginInit();
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
            topPanel.Size = new System.Drawing.Size(1234, 79);
            topPanel.TabIndex = 30;
            // 
            // picClose
            // 
            picClose.Image = (System.Drawing.Image)resources.GetObject("picClose.Image");
            picClose.Location = new System.Drawing.Point(1176, 15);
            picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(46, 51);
            picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picClose.TabIndex = 2;
            picClose.TabStop = false;
            picClose.Click += pictureBox2_Click;
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
            lbl_top.Location = new System.Drawing.Point(483, 15);
            lbl_top.Name = "lbl_top";
            lbl_top.Size = new System.Drawing.Size(251, 22);
            lbl_top.TabIndex = 0;
            lbl_top.Text = "PRODUCT MANAGEMENT";
            // 
            // lbl_ProductID
            // 
            lbl_ProductID.AutoSize = true;
            lbl_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ProductID.Location = new System.Drawing.Point(56, 161);
            lbl_ProductID.Name = "lbl_ProductID";
            lbl_ProductID.Size = new System.Drawing.Size(89, 20);
            lbl_ProductID.TabIndex = 31;
            lbl_ProductID.Text = "Product ID";
            // 
            // txt_ProductID
            // 
            txt_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_ProductID.Location = new System.Drawing.Point(179, 161);
            txt_ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_ProductID.Name = "txt_ProductID";
            txt_ProductID.ReadOnly = true;
            txt_ProductID.Size = new System.Drawing.Size(261, 27);
            txt_ProductID.TabIndex = 32;
            // 
            // txt_Name
            // 
            txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Name.Location = new System.Drawing.Point(179, 230);
            txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new System.Drawing.Size(261, 27);
            txt_Name.TabIndex = 34;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Name.Location = new System.Drawing.Point(56, 230);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new System.Drawing.Size(53, 20);
            lbl_Name.TabIndex = 33;
            lbl_Name.Text = "Name";
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Category.Location = new System.Drawing.Point(56, 308);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new System.Drawing.Size(76, 20);
            lbl_Category.TabIndex = 35;
            lbl_Category.Text = "Category";
            // 
            // txt_Description
            // 
            txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Description.Location = new System.Drawing.Point(179, 378);
            txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new System.Drawing.Size(261, 214);
            txt_Description.TabIndex = 38;
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Description.Location = new System.Drawing.Point(56, 378);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new System.Drawing.Size(95, 20);
            lbl_Description.TabIndex = 37;
            lbl_Description.Text = "Description";
            // 
            // txt_Rate
            // 
            txt_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Rate.Location = new System.Drawing.Point(179, 638);
            txt_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Rate.Name = "txt_Rate";
            txt_Rate.Size = new System.Drawing.Size(261, 27);
            txt_Rate.TabIndex = 40;
            // 
            // lbl_Rate
            // 
            lbl_Rate.AutoSize = true;
            lbl_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Rate.Location = new System.Drawing.Point(56, 638);
            lbl_Rate.Name = "lbl_Rate";
            lbl_Rate.Size = new System.Drawing.Size(44, 20);
            lbl_Rate.TabIndex = 39;
            lbl_Rate.Text = "Rate";
            // 
            // cmb_Category
            // 
            cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new System.Drawing.Point(179, 308);
            cmb_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new System.Drawing.Size(261, 28);
            cmb_Category.TabIndex = 41;
            cmb_Category.SelectedIndexChanged += cmb_Category_SelectedIndexChanged;
            // 
            // dgv_products
            // 
            dgv_products.AutoGenerateColumns = false;
            dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgv_products.DataSource = tblProductBindingSource1;
            dgv_products.Location = new System.Drawing.Point(487, 161);
            dgv_products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.RowTemplate.Height = 24;
            dgv_products.Size = new System.Drawing.Size(721, 515);
            dgv_products.TabIndex = 42;
            dgv_products.RowHeaderMouseClick += dgv_products_RowHeaderMouseClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            dataGridViewTextBoxColumn4.HeaderText = "Description";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Rate";
            dataGridViewTextBoxColumn5.HeaderText = "Rate";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Qty";
            dataGridViewTextBoxColumn6.HeaderText = "Qty";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "AddedDate";
            dataGridViewTextBoxColumn7.HeaderText = "AddedDate";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "AddedBy";
            dataGridViewTextBoxColumn8.HeaderText = "AddedBy";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // tblProductBindingSource1
            // 
            tblProductBindingSource1.DataSource = typeof(DataAccessLayer.Model.TblProduct);
            // 
            // txt_Search
            // 
            txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Search.Location = new System.Drawing.Point(626, 119);
            txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new System.Drawing.Size(587, 27);
            txt_Search.TabIndex = 0;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // lbl_Search
            // 
            lbl_Search.AutoSize = true;
            lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Search.Location = new System.Drawing.Point(511, 122);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new System.Drawing.Size(62, 20);
            lbl_Search.TabIndex = 43;
            lbl_Search.Text = "Search";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Add.Location = new System.Drawing.Point(60, 741);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(120, 52);
            btn_Add.TabIndex = 44;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = System.Drawing.Color.Red;
            btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Delete.Location = new System.Drawing.Point(403, 741);
            btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(120, 52);
            btn_Delete.TabIndex = 45;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = System.Drawing.Color.Gold;
            btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Update.Location = new System.Drawing.Point(240, 741);
            btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new System.Drawing.Size(120, 52);
            btn_Update.TabIndex = 46;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1234, 854);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(txt_Search);
            Controls.Add(lbl_Search);
            Controls.Add(dgv_products);
            Controls.Add(cmb_Category);
            Controls.Add(txt_Rate);
            Controls.Add(lbl_Rate);
            Controls.Add(txt_Description);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Category);
            Controls.Add(txt_Name);
            Controls.Add(lbl_Name);
            Controls.Add(txt_ProductID);
            Controls.Add(lbl_ProductID);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmProducts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmProducts_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource tblProductBindingSource1;
    }
}
namespace BillingApp.UI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            topPanel = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_top = new System.Windows.Forms.Label();
            dgv_Products = new System.Windows.Forms.DataGridView();
            lbl_Category = new System.Windows.Forms.Label();
            cmb_Category = new System.Windows.Forms.ComboBox();
            btn_ShowAll = new System.Windows.Forms.Button();
            tblCategoryBindingSource = new System.Windows.Forms.BindingSource(components);
            tblProductBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblCategoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            topPanel.Controls.Add(picClose);
            topPanel.Controls.Add(pictureBox2);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(lbl_top);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1215, 58);
            topPanel.TabIndex = 31;
            // 
            // picClose
            // 
            picClose.Image = (System.Drawing.Image)resources.GetObject("picClose.Image");
            picClose.Location = new System.Drawing.Point(1143, 2);
            picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(40, 51);
            picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picClose.TabIndex = 3;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1229, 15);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(40, 51);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            lbl_top.Size = new System.Drawing.Size(124, 22);
            lbl_top.TabIndex = 0;
            lbl_top.Text = "INVENTORY";
            // 
            // dgv_Products
            // 
            dgv_Products.AutoGenerateColumns = false;
            dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, addedDateDataGridViewTextBoxColumn, addedByDataGridViewTextBoxColumn });
            dgv_Products.DataSource = tblProductBindingSource;
            dgv_Products.Location = new System.Drawing.Point(12, 178);
            dgv_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_Products.Name = "dgv_Products";
            dgv_Products.RowHeadersWidth = 51;
            dgv_Products.RowTemplate.Height = 24;
            dgv_Products.Size = new System.Drawing.Size(1154, 575);
            dgv_Products.TabIndex = 32;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Category.Location = new System.Drawing.Point(68, 105);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new System.Drawing.Size(84, 23);
            lbl_Category.TabIndex = 33;
            lbl_Category.Text = "Category";
            // 
            // cmb_Category
            // 
            cmb_Category.DataSource = tblCategoryBindingSource;
            cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new System.Drawing.Point(224, 108);
            cmb_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new System.Drawing.Size(383, 28);
            cmb_Category.TabIndex = 34;
            cmb_Category.SelectedIndexChanged += cmb_Category_SelectedIndexChanged;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new System.Drawing.Point(785, 105);
            btn_ShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new System.Drawing.Size(162, 49);
            btn_ShowAll.TabIndex = 35;
            btn_ShowAll.Text = "Show All";
            btn_ShowAll.UseVisualStyleBackColor = true;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // tblCategoryBindingSource
            // 
            tblCategoryBindingSource.DataSource = typeof(DataAccessLayer.Model.TblCategory);
            // 
            // tblProductBindingSource
            // 
            tblProductBindingSource.DataSource = typeof(DataAccessLayer.Model.TblProduct);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            rateDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            qtyDataGridViewTextBoxColumn.Width = 125;
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
            // frmInventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ScrollBar;
            ClientSize = new System.Drawing.Size(1215, 788);
            Controls.Add(btn_ShowAll);
            Controls.Add(cmb_Category);
            Controls.Add(lbl_Category);
            Controls.Add(dgv_Products);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmInventory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmInventory";
            Load += frmInventory_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblCategoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
    }
}
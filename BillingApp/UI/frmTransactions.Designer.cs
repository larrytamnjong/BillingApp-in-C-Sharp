namespace BillingApp.UI
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            topPanel = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_top = new System.Windows.Forms.Label();
            dgv_transaction = new System.Windows.Forms.DataGridView();
            lbl_TransactionType = new System.Windows.Forms.Label();
            cmb_TransactionType = new System.Windows.Forms.ComboBox();
            btn_ShowAll = new System.Windows.Forms.Button();
            tblTransactionBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            deaCustIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grandTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_transaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblTransactionBindingSource).BeginInit();
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
            topPanel.Size = new System.Drawing.Size(1210, 58);
            topPanel.TabIndex = 30;
            // 
            // picClose
            // 
            picClose.Image = (System.Drawing.Image)resources.GetObject("picClose.Image");
            picClose.Location = new System.Drawing.Point(1144, 4);
            picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(40, 51);
            picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picClose.TabIndex = 3;
            picClose.TabStop = false;
            picClose.Click += pictureBox3_Click;
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
            lbl_top.Size = new System.Drawing.Size(164, 22);
            lbl_top.TabIndex = 0;
            lbl_top.Text = "TRANSACTIONS";
            // 
            // dgv_transaction
            // 
            dgv_transaction.AutoGenerateColumns = false;
            dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, deaCustIdDataGridViewTextBoxColumn, grandTotalDataGridViewTextBoxColumn, transactionDateDataGridViewTextBoxColumn, taxDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, addedByDataGridViewTextBoxColumn });
            dgv_transaction.DataSource = tblTransactionBindingSource;
            dgv_transaction.Location = new System.Drawing.Point(24, 155);
            dgv_transaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_transaction.Name = "dgv_transaction";
            dgv_transaction.RowHeadersWidth = 51;
            dgv_transaction.RowTemplate.Height = 24;
            dgv_transaction.Size = new System.Drawing.Size(1174, 579);
            dgv_transaction.TabIndex = 31;
            // 
            // lbl_TransactionType
            // 
            lbl_TransactionType.AutoSize = true;
            lbl_TransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TransactionType.Location = new System.Drawing.Point(44, 92);
            lbl_TransactionType.Name = "lbl_TransactionType";
            lbl_TransactionType.Size = new System.Drawing.Size(181, 25);
            lbl_TransactionType.TabIndex = 32;
            lbl_TransactionType.Text = "Transaction Type";
            // 
            // cmb_TransactionType
            // 
            cmb_TransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_TransactionType.FormattingEnabled = true;
            cmb_TransactionType.Items.AddRange(new object[] { "PURCHASE MANAGEMENT", "SALES MANAGEMENT" });
            cmb_TransactionType.Location = new System.Drawing.Point(326, 92);
            cmb_TransactionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_TransactionType.Name = "cmb_TransactionType";
            cmb_TransactionType.Size = new System.Drawing.Size(301, 33);
            cmb_TransactionType.TabIndex = 33;
            cmb_TransactionType.SelectedIndexChanged += cmb_TransactionType_SelectedIndexChanged;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.BackColor = System.Drawing.SystemColors.Highlight;
            btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_ShowAll.Location = new System.Drawing.Point(741, 82);
            btn_ShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new System.Drawing.Size(238, 62);
            btn_ShowAll.TabIndex = 34;
            btn_ShowAll.Text = "Show All";
            btn_ShowAll.UseVisualStyleBackColor = false;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // tblTransactionBindingSource
            // 
            tblTransactionBindingSource.DataSource = typeof(DataAccessLayer.Model.TblTransaction);
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
            // deaCustIdDataGridViewTextBoxColumn
            // 
            deaCustIdDataGridViewTextBoxColumn.DataPropertyName = "DeaCustId";
            deaCustIdDataGridViewTextBoxColumn.HeaderText = "DeaCustId";
            deaCustIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            deaCustIdDataGridViewTextBoxColumn.Name = "deaCustIdDataGridViewTextBoxColumn";
            deaCustIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // grandTotalDataGridViewTextBoxColumn
            // 
            grandTotalDataGridViewTextBoxColumn.DataPropertyName = "GrandTotal";
            grandTotalDataGridViewTextBoxColumn.HeaderText = "GrandTotal";
            grandTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            grandTotalDataGridViewTextBoxColumn.Name = "grandTotalDataGridViewTextBoxColumn";
            grandTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            transactionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            taxDataGridViewTextBoxColumn.MinimumWidth = 6;
            taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            taxDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            addedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            addedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1210, 771);
            Controls.Add(btn_ShowAll);
            Controls.Add(cmb_TransactionType);
            Controls.Add(lbl_TransactionType);
            Controls.Add(dgv_transaction);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmTransactions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Transaction";
            Load += frmTransactions_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_transaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblTransactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.Label lbl_TransactionType;
        private System.Windows.Forms.ComboBox cmb_TransactionType;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deaCustIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource;
    }
}
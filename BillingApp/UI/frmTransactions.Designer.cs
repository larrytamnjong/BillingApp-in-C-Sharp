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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.topPanel = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_top = new System.Windows.Forms.Label();
            this.dgv_transaction = new System.Windows.Forms.DataGridView();
            this.lbl_TransactionType = new System.Windows.Forms.Label();
            this.cmb_TransactionType = new System.Windows.Forms.ComboBox();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.topPanel.Controls.Add(this.picClose);
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.lbl_top);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1210, 46);
            this.topPanel.TabIndex = 30;
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1144, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 41);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1229, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1351, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top.Location = new System.Drawing.Point(483, 12);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(164, 22);
            this.lbl_top.TabIndex = 0;
            this.lbl_top.Text = "TRANSACTIONS";
            // 
            // dgv_transaction
            // 
            this.dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction.Location = new System.Drawing.Point(24, 124);
            this.dgv_transaction.Name = "dgv_transaction";
            this.dgv_transaction.RowHeadersWidth = 51;
            this.dgv_transaction.RowTemplate.Height = 24;
            this.dgv_transaction.Size = new System.Drawing.Size(1174, 463);
            this.dgv_transaction.TabIndex = 31;
            // 
            // lbl_TransactionType
            // 
            this.lbl_TransactionType.AutoSize = true;
            this.lbl_TransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransactionType.Location = new System.Drawing.Point(44, 74);
            this.lbl_TransactionType.Name = "lbl_TransactionType";
            this.lbl_TransactionType.Size = new System.Drawing.Size(181, 25);
            this.lbl_TransactionType.TabIndex = 32;
            this.lbl_TransactionType.Text = "Transaction Type";
            // 
            // cmb_TransactionType
            // 
            this.cmb_TransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TransactionType.FormattingEnabled = true;
            this.cmb_TransactionType.Items.AddRange(new object[] {
            "PURCHASE MANAGEMENT",
            "SALES MANAGEMENT"});
            this.cmb_TransactionType.Location = new System.Drawing.Point(326, 74);
            this.cmb_TransactionType.Name = "cmb_TransactionType";
            this.cmb_TransactionType.Size = new System.Drawing.Size(301, 33);
            this.cmb_TransactionType.TabIndex = 33;
            this.cmb_TransactionType.SelectedIndexChanged += new System.EventHandler(this.cmb_TransactionType_SelectedIndexChanged);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ShowAll.Location = new System.Drawing.Point(741, 66);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(238, 50);
            this.btn_ShowAll.TabIndex = 34;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1210, 617);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.cmb_TransactionType);
            this.Controls.Add(this.lbl_TransactionType);
            this.Controls.Add(this.dgv_transaction);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
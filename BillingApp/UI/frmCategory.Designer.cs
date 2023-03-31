namespace BillingApp.UI
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            topPanel = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_top = new System.Windows.Forms.Label();
            lbl_CategoryID = new System.Windows.Forms.Label();
            lbl_Title = new System.Windows.Forms.Label();
            lbl_Description = new System.Windows.Forms.Label();
            txt_CategoryID = new System.Windows.Forms.TextBox();
            txt_Description = new System.Windows.Forms.TextBox();
            txt_Title = new System.Windows.Forms.TextBox();
            btn_Add = new System.Windows.Forms.Button();
            btn_Delete = new System.Windows.Forms.Button();
            btn_Update = new System.Windows.Forms.Button();
            dgv_Categories = new System.Windows.Forms.DataGridView();
            txt_Search = new System.Windows.Forms.TextBox();
            lbl_Search = new System.Windows.Forms.Label();
            tblCategoryBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            topPanel.Controls.Add(pictureBox2);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(lbl_top);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1285, 79);
            topPanel.TabIndex = 29;
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
            pictureBox2.Click += pictureBox2_Click;
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
            lbl_top.Size = new System.Drawing.Size(264, 22);
            lbl_top.TabIndex = 0;
            lbl_top.Text = "CATEGORY MANAGEMENT";
            // 
            // lbl_CategoryID
            // 
            lbl_CategoryID.AutoSize = true;
            lbl_CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_CategoryID.Location = new System.Drawing.Point(41, 152);
            lbl_CategoryID.Name = "lbl_CategoryID";
            lbl_CategoryID.Size = new System.Drawing.Size(86, 18);
            lbl_CategoryID.TabIndex = 30;
            lbl_CategoryID.Text = "Category ID";
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Title.Location = new System.Drawing.Point(41, 219);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new System.Drawing.Size(35, 18);
            lbl_Title.TabIndex = 31;
            lbl_Title.Text = "Title";
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Description.Location = new System.Drawing.Point(41, 281);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new System.Drawing.Size(83, 18);
            lbl_Description.TabIndex = 32;
            lbl_Description.Text = "Description";
            // 
            // txt_CategoryID
            // 
            txt_CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_CategoryID.Location = new System.Drawing.Point(171, 152);
            txt_CategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_CategoryID.Name = "txt_CategoryID";
            txt_CategoryID.ReadOnly = true;
            txt_CategoryID.Size = new System.Drawing.Size(252, 24);
            txt_CategoryID.TabIndex = 33;
            // 
            // txt_Description
            // 
            txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Description.Location = new System.Drawing.Point(171, 281);
            txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new System.Drawing.Size(252, 99);
            txt_Description.TabIndex = 34;
            // 
            // txt_Title
            // 
            txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Title.Location = new System.Drawing.Point(171, 219);
            txt_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new System.Drawing.Size(252, 24);
            txt_Title.TabIndex = 35;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Add.Location = new System.Drawing.Point(29, 588);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(115, 51);
            btn_Add.TabIndex = 36;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = System.Drawing.Color.Red;
            btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            btn_Delete.Location = new System.Drawing.Point(337, 588);
            btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(110, 51);
            btn_Delete.TabIndex = 37;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = System.Drawing.Color.Orange;
            btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Update.Location = new System.Drawing.Point(189, 588);
            btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new System.Drawing.Size(116, 51);
            btn_Update.TabIndex = 38;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // dgv_Categories
            // 
            dgv_Categories.AutoGenerateColumns = false;
            dgv_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, addedDateDataGridViewTextBoxColumn, addedByDataGridViewTextBoxColumn });
            dgv_Categories.DataSource = tblCategoryBindingSource;
            dgv_Categories.Location = new System.Drawing.Point(487, 176);
            dgv_Categories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgv_Categories.Name = "dgv_Categories";
            dgv_Categories.RowHeadersWidth = 51;
            dgv_Categories.RowTemplate.Height = 24;
            dgv_Categories.Size = new System.Drawing.Size(786, 550);
            dgv_Categories.TabIndex = 39;
            dgv_Categories.RowHeaderMouseClick += dgv_Categories_RowHeaderMouseClick;
            // 
            // txt_Search
            // 
            txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Search.Location = new System.Drawing.Point(717, 122);
            txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new System.Drawing.Size(454, 24);
            txt_Search.TabIndex = 41;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // lbl_Search
            // 
            lbl_Search.AutoSize = true;
            lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Search.Location = new System.Drawing.Point(638, 126);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new System.Drawing.Size(55, 18);
            lbl_Search.TabIndex = 40;
            lbl_Search.Text = "Search";
            // 
            // tblCategoryBindingSource
            // 
            tblCategoryBindingSource.DataSource = typeof(DataAccessLayer.Model.TblCategory);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
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
            // frmCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ScrollBar;
            ClientSize = new System.Drawing.Size(1285, 842);
            Controls.Add(txt_Search);
            Controls.Add(lbl_Search);
            Controls.Add(dgv_Categories);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(txt_Title);
            Controls.Add(txt_Description);
            Controls.Add(txt_CategoryID);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_CategoryID);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCategory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCategory";
            Load += frmCategory_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_CategoryID;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_CategoryID;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dgv_Categories;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
    }
}
namespace BillingApp.UI
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            btn_Update = new System.Windows.Forms.Button();
            btn_Delete = new System.Windows.Forms.Button();
            btn_Add = new System.Windows.Forms.Button();
            txt_Search = new System.Windows.Forms.TextBox();
            lbl_Search = new System.Windows.Forms.Label();
            dgvUsers = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tblUserBindingSource1 = new System.Windows.Forms.BindingSource(components);
            tblUserBindingSource = new System.Windows.Forms.BindingSource(components);
            txt_UserId = new System.Windows.Forms.TextBox();
            lbl_UserId = new System.Windows.Forms.Label();
            cmb_UserType = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cmb_Gender = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            txt_Address = new System.Windows.Forms.TextBox();
            lbl_Address = new System.Windows.Forms.Label();
            txt_Contact = new System.Windows.Forms.TextBox();
            lbl_Contact = new System.Windows.Forms.Label();
            txt_Password = new System.Windows.Forms.TextBox();
            lbl_Password = new System.Windows.Forms.Label();
            txt_Username = new System.Windows.Forms.TextBox();
            lbl_Username = new System.Windows.Forms.Label();
            txt_Email = new System.Windows.Forms.TextBox();
            lbl_Email = new System.Windows.Forms.Label();
            txt_LastName = new System.Windows.Forms.TextBox();
            lbl_LastName = new System.Windows.Forms.Label();
            txt_FirstName = new System.Windows.Forms.TextBox();
            lbl_FirstName = new System.Windows.Forms.Label();
            topPanel = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_top = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblUserBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblUserBindingSource).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.BackColor = System.Drawing.Color.Gold;
            btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Update.Location = new System.Drawing.Point(490, 825);
            btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new System.Drawing.Size(165, 65);
            btn_Update.TabIndex = 54;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = System.Drawing.Color.Red;
            btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Delete.ForeColor = System.Drawing.SystemColors.Info;
            btn_Delete.Location = new System.Drawing.Point(745, 825);
            btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(165, 65);
            btn_Delete.TabIndex = 53;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.ForestGreen;
            btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Add.Location = new System.Drawing.Point(251, 825);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(165, 65);
            btn_Add.TabIndex = 52;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_Search
            // 
            txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Search.Location = new System.Drawing.Point(795, 102);
            txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new System.Drawing.Size(567, 28);
            txt_Search.TabIndex = 51;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // lbl_Search
            // 
            lbl_Search.AutoSize = true;
            lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Search.Location = new System.Drawing.Point(695, 106);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new System.Drawing.Size(73, 22);
            lbl_Search.TabIndex = 50;
            lbl_Search.Text = "Search";
            // 
            // dgvUsers
            // 
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dgvUsers.DataSource = tblUserBindingSource1;
            dgvUsers.Location = new System.Drawing.Point(480, 160);
            dgvUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 24;
            dgvUsers.Size = new System.Drawing.Size(893, 610);
            dgvUsers.TabIndex = 49;
            dgvUsers.RowHeaderMouseClick += dgvUsers_RowHeaderMouseClick;
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
            dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn3.HeaderText = "LastName";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            dataGridViewTextBoxColumn5.HeaderText = "Username";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            dataGridViewTextBoxColumn6.HeaderText = "Password";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Contact";
            dataGridViewTextBoxColumn7.HeaderText = "Contact";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            dataGridViewTextBoxColumn8.HeaderText = "Address";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Gender";
            dataGridViewTextBoxColumn9.HeaderText = "Gender";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "UserType";
            dataGridViewTextBoxColumn10.HeaderText = "UserType";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "AddedDate";
            dataGridViewTextBoxColumn11.HeaderText = "AddedDate";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "AddedBy";
            dataGridViewTextBoxColumn12.HeaderText = "AddedBy";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // tblUserBindingSource1
            // 
            tblUserBindingSource1.DataSource = typeof(DataAccessLayer.Model.TblUser);
            // 
            // txt_UserId
            // 
            txt_UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_UserId.Location = new System.Drawing.Point(164, 101);
            txt_UserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_UserId.Name = "txt_UserId";
            txt_UserId.ReadOnly = true;
            txt_UserId.Size = new System.Drawing.Size(280, 28);
            txt_UserId.TabIndex = 48;
            // 
            // lbl_UserId
            // 
            lbl_UserId.AutoSize = true;
            lbl_UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_UserId.Location = new System.Drawing.Point(25, 102);
            lbl_UserId.Name = "lbl_UserId";
            lbl_UserId.Size = new System.Drawing.Size(77, 22);
            lbl_UserId.TabIndex = 47;
            lbl_UserId.Text = "User ID";
            // 
            // cmb_UserType
            // 
            cmb_UserType.FormattingEnabled = true;
            cmb_UserType.Items.AddRange(new object[] { "User", "Admin" });
            cmb_UserType.Location = new System.Drawing.Point(164, 735);
            cmb_UserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_UserType.Name = "cmb_UserType";
            cmb_UserType.Size = new System.Drawing.Size(280, 28);
            cmb_UserType.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(25, 739);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 22);
            label2.TabIndex = 45;
            label2.Text = "User Type";
            // 
            // cmb_Gender
            // 
            cmb_Gender.FormattingEnabled = true;
            cmb_Gender.Items.AddRange(new object[] { "Male", "Female", "Not Specified" });
            cmb_Gender.Location = new System.Drawing.Point(164, 674);
            cmb_Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Size = new System.Drawing.Size(280, 28);
            cmb_Gender.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(25, 671);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 22);
            label1.TabIndex = 43;
            label1.Text = "Gender";
            // 
            // txt_Address
            // 
            txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Address.Location = new System.Drawing.Point(164, 570);
            txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new System.Drawing.Size(280, 72);
            txt_Address.TabIndex = 42;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Address.Location = new System.Drawing.Point(25, 571);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new System.Drawing.Size(83, 22);
            lbl_Address.TabIndex = 41;
            lbl_Address.Text = "Address";
            // 
            // txt_Contact
            // 
            txt_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Contact.Location = new System.Drawing.Point(164, 502);
            txt_Contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Contact.Name = "txt_Contact";
            txt_Contact.Size = new System.Drawing.Size(280, 28);
            txt_Contact.TabIndex = 40;
            // 
            // lbl_Contact
            // 
            lbl_Contact.AutoSize = true;
            lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Contact.Location = new System.Drawing.Point(25, 504);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new System.Drawing.Size(79, 22);
            lbl_Contact.TabIndex = 39;
            lbl_Contact.Text = "Contact";
            // 
            // txt_Password
            // 
            txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Password.Location = new System.Drawing.Point(164, 436);
            txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new System.Drawing.Size(280, 28);
            txt_Password.TabIndex = 38;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Password.Location = new System.Drawing.Point(25, 438);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new System.Drawing.Size(97, 22);
            lbl_Password.TabIndex = 37;
            lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Username.Location = new System.Drawing.Point(164, 372);
            txt_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new System.Drawing.Size(280, 28);
            txt_Username.TabIndex = 36;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Username.Location = new System.Drawing.Point(25, 374);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new System.Drawing.Size(100, 22);
            lbl_Username.TabIndex = 35;
            lbl_Username.Text = "Username";
            // 
            // txt_Email
            // 
            txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Email.Location = new System.Drawing.Point(164, 306);
            txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new System.Drawing.Size(280, 28);
            txt_Email.TabIndex = 34;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Email.Location = new System.Drawing.Point(25, 306);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new System.Drawing.Size(59, 22);
            lbl_Email.TabIndex = 33;
            lbl_Email.Text = "Email";
            // 
            // txt_LastName
            // 
            txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_LastName.Location = new System.Drawing.Point(164, 241);
            txt_LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new System.Drawing.Size(280, 28);
            txt_LastName.TabIndex = 32;
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_LastName.Location = new System.Drawing.Point(25, 242);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new System.Drawing.Size(105, 22);
            lbl_LastName.TabIndex = 31;
            lbl_LastName.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            txt_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_FirstName.Location = new System.Drawing.Point(164, 185);
            txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new System.Drawing.Size(280, 28);
            txt_FirstName.TabIndex = 30;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_FirstName.Location = new System.Drawing.Point(25, 186);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new System.Drawing.Size(107, 22);
            lbl_FirstName.TabIndex = 29;
            lbl_FirstName.Text = "First Name";
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(lbl_top);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1406, 79);
            topPanel.TabIndex = 28;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_top
            // 
            lbl_top.AutoSize = true;
            lbl_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_top.Location = new System.Drawing.Point(490, 15);
            lbl_top.Name = "lbl_top";
            lbl_top.Size = new System.Drawing.Size(221, 22);
            lbl_top.TabIndex = 0;
            lbl_top.Text = "USERS MANAGEMENT";
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            ClientSize = new System.Drawing.Size(1406, 945);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(txt_Search);
            Controls.Add(lbl_Search);
            Controls.Add(dgvUsers);
            Controls.Add(txt_UserId);
            Controls.Add(lbl_UserId);
            Controls.Add(cmb_UserType);
            Controls.Add(label2);
            Controls.Add(cmb_Gender);
            Controls.Add(label1);
            Controls.Add(txt_Address);
            Controls.Add(lbl_Address);
            Controls.Add(txt_Contact);
            Controls.Add(lbl_Contact);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Username);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Email);
            Controls.Add(txt_LastName);
            Controls.Add(lbl_LastName);
            Controls.Add(txt_FirstName);
            Controls.Add(lbl_FirstName);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmUsers";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmUsers";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblUserBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblUserBindingSource).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
    }
}
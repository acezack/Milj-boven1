namespace Miljöboven1.View
{
    partial class AdminForm
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbxAddUserUserName = new System.Windows.Forms.TextBox();
            this.tbxAddUserPassword = new System.Windows.Forms.TextBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblAddUserUserName = new System.Windows.Forms.Label();
            this.lblAddUserPassword = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.cbxRemoveUser = new System.Windows.Forms.ComboBox();
            this.lblAddUserType = new System.Windows.Forms.Label();
            this.cbxAddUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(15, 141);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(198, 30);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Lägg till användare";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbxAddUserUserName
            // 
            this.tbxAddUserUserName.Location = new System.Drawing.Point(113, 51);
            this.tbxAddUserUserName.Name = "tbxAddUserUserName";
            this.tbxAddUserUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUserUserName.TabIndex = 1;
            // 
            // tbxAddUserPassword
            // 
            this.tbxAddUserPassword.Location = new System.Drawing.Point(113, 77);
            this.tbxAddUserPassword.Name = "tbxAddUserPassword";
            this.tbxAddUserPassword.PasswordChar = '*';
            this.tbxAddUserPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUserPassword.TabIndex = 2;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(10, 9);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(201, 26);
            this.lblAddUser.TabIndex = 4;
            this.lblAddUser.Text = "Lägg till användare:";
            // 
            // lblAddUserUserName
            // 
            this.lblAddUserUserName.AutoSize = true;
            this.lblAddUserUserName.Location = new System.Drawing.Point(12, 54);
            this.lblAddUserUserName.Name = "lblAddUserUserName";
            this.lblAddUserUserName.Size = new System.Drawing.Size(82, 13);
            this.lblAddUserUserName.TabIndex = 5;
            this.lblAddUserUserName.Text = "Användarnamn:";
            // 
            // lblAddUserPassword
            // 
            this.lblAddUserPassword.AutoSize = true;
            this.lblAddUserPassword.Location = new System.Drawing.Point(12, 80);
            this.lblAddUserPassword.Name = "lblAddUserPassword";
            this.lblAddUserPassword.Size = new System.Drawing.Size(54, 13);
            this.lblAddUserPassword.TabIndex = 6;
            this.lblAddUserPassword.Text = "Lösenord:";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(15, 381);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(198, 30);
            this.btnRemoveUser.TabIndex = 8;
            this.btnRemoveUser.Text = "Ta bort användare";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // cbxRemoveUser
            // 
            this.cbxRemoveUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemoveUser.FormattingEnabled = true;
            this.cbxRemoveUser.Location = new System.Drawing.Point(15, 354);
            this.cbxRemoveUser.Name = "cbxRemoveUser";
            this.cbxRemoveUser.Size = new System.Drawing.Size(198, 21);
            this.cbxRemoveUser.TabIndex = 9;
            // 
            // lblAddUserType
            // 
            this.lblAddUserType.AutoSize = true;
            this.lblAddUserType.Location = new System.Drawing.Point(12, 106);
            this.lblAddUserType.Name = "lblAddUserType";
            this.lblAddUserType.Size = new System.Drawing.Size(70, 13);
            this.lblAddUserType.TabIndex = 7;
            this.lblAddUserType.Text = "Användartyp:";
            // 
            // cbxAddUserType
            // 
            this.cbxAddUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddUserType.FormattingEnabled = true;
            this.cbxAddUserType.Location = new System.Drawing.Point(111, 103);
            this.cbxAddUserType.Name = "cbxAddUserType";
            this.cbxAddUserType.Size = new System.Drawing.Size(100, 21);
            this.cbxAddUserType.TabIndex = 10;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 445);
            this.Controls.Add(this.cbxAddUserType);
            this.Controls.Add(this.cbxRemoveUser);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.lblAddUserType);
            this.Controls.Add(this.lblAddUserPassword);
            this.Controls.Add(this.lblAddUserUserName);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.tbxAddUserPassword);
            this.Controls.Add(this.tbxAddUserUserName);
            this.Controls.Add(this.btnAddUser);
            this.Name = "AdminForm";
            this.Text = "Bara för admins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox tbxAddUserUserName;
        private System.Windows.Forms.TextBox tbxAddUserPassword;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblAddUserUserName;
        private System.Windows.Forms.Label lblAddUserPassword;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.ComboBox cbxRemoveUser;
        private System.Windows.Forms.Label lblAddUserType;
        private System.Windows.Forms.ComboBox cbxAddUserType;
    }
}
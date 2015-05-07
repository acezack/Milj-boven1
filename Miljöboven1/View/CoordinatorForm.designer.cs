namespace Miljöboven1.View
{
    partial class CoordinatorForm
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
            this.btnAddCrime = new System.Windows.Forms.Button();
            this.tbxCrimeLocation = new System.Windows.Forms.TextBox();
            this.tbxCrimeInformation = new System.Windows.Forms.TextBox();
            this.lblCrimeLocation = new System.Windows.Forms.Label();
            this.lblCrimeInformation = new System.Windows.Forms.Label();
            this.tbxCallerName = new System.Windows.Forms.TextBox();
            this.tbxCallerAddress = new System.Windows.Forms.TextBox();
            this.tbxCallerNumber = new System.Windows.Forms.TextBox();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.lblCallerAddress = new System.Windows.Forms.Label();
            this.lblCallerNumber = new System.Windows.Forms.Label();
            this.tbxClearText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCrime
            // 
            this.btnAddCrime.Location = new System.Drawing.Point(123, 325);
            this.btnAddCrime.Name = "btnAddCrime";
            this.btnAddCrime.Size = new System.Drawing.Size(175, 23);
            this.btnAddCrime.TabIndex = 98;
            this.btnAddCrime.Text = "Lägg till ärende";
            this.btnAddCrime.UseVisualStyleBackColor = true;
            this.btnAddCrime.Click += new System.EventHandler(this.btnAddCrime_Click);
            // 
            // tbxCrimeLocation
            // 
            this.tbxCrimeLocation.Location = new System.Drawing.Point(123, 32);
            this.tbxCrimeLocation.Name = "tbxCrimeLocation";
            this.tbxCrimeLocation.Size = new System.Drawing.Size(175, 20);
            this.tbxCrimeLocation.TabIndex = 0;
            // 
            // tbxCrimeInformation
            // 
            this.tbxCrimeInformation.Location = new System.Drawing.Point(123, 58);
            this.tbxCrimeInformation.Multiline = true;
            this.tbxCrimeInformation.Name = "tbxCrimeInformation";
            this.tbxCrimeInformation.Size = new System.Drawing.Size(175, 182);
            this.tbxCrimeInformation.TabIndex = 2;
            // 
            // lblCrimeLocation
            // 
            this.lblCrimeLocation.AutoSize = true;
            this.lblCrimeLocation.Location = new System.Drawing.Point(12, 35);
            this.lblCrimeLocation.Name = "lblCrimeLocation";
            this.lblCrimeLocation.Size = new System.Drawing.Size(59, 13);
            this.lblCrimeLocation.TabIndex = 3;
            this.lblCrimeLocation.Text = "Brottsplats:";
            // 
            // lblCrimeInformation
            // 
            this.lblCrimeInformation.AutoSize = true;
            this.lblCrimeInformation.Location = new System.Drawing.Point(12, 61);
            this.lblCrimeInformation.Name = "lblCrimeInformation";
            this.lblCrimeInformation.Size = new System.Drawing.Size(56, 26);
            this.lblCrimeInformation.TabIndex = 4;
            this.lblCrimeInformation.Text = "Brottsinfo:\r\n(eventuell)";
            // 
            // tbxCallerName
            // 
            this.tbxCallerName.Location = new System.Drawing.Point(123, 246);
            this.tbxCallerName.Name = "tbxCallerName";
            this.tbxCallerName.Size = new System.Drawing.Size(175, 20);
            this.tbxCallerName.TabIndex = 5;
            // 
            // tbxCallerAddress
            // 
            this.tbxCallerAddress.Location = new System.Drawing.Point(123, 273);
            this.tbxCallerAddress.Name = "tbxCallerAddress";
            this.tbxCallerAddress.Size = new System.Drawing.Size(175, 20);
            this.tbxCallerAddress.TabIndex = 6;
            // 
            // tbxCallerNumber
            // 
            this.tbxCallerNumber.Location = new System.Drawing.Point(123, 299);
            this.tbxCallerNumber.Name = "tbxCallerNumber";
            this.tbxCallerNumber.Size = new System.Drawing.Size(175, 20);
            this.tbxCallerNumber.TabIndex = 7;
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Location = new System.Drawing.Point(12, 249);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(94, 13);
            this.lblCallerName.TabIndex = 8;
            this.lblCallerName.Text = "Anmälarens namn:";
            // 
            // lblCallerAddress
            // 
            this.lblCallerAddress.AutoSize = true;
            this.lblCallerAddress.Location = new System.Drawing.Point(12, 276);
            this.lblCallerAddress.Name = "lblCallerAddress";
            this.lblCallerAddress.Size = new System.Drawing.Size(99, 13);
            this.lblCallerAddress.TabIndex = 9;
            this.lblCallerAddress.Text = "Anmälarens adress:";
            // 
            // lblCallerNumber
            // 
            this.lblCallerNumber.AutoSize = true;
            this.lblCallerNumber.Location = new System.Drawing.Point(12, 302);
            this.lblCallerNumber.Name = "lblCallerNumber";
            this.lblCallerNumber.Size = new System.Drawing.Size(105, 13);
            this.lblCallerNumber.TabIndex = 10;
            this.lblCallerNumber.Text = "Anmälarens nummer:";
            // 
            // tbxClearText
            // 
            this.tbxClearText.Location = new System.Drawing.Point(304, 297);
            this.tbxClearText.Name = "tbxClearText";
            this.tbxClearText.Size = new System.Drawing.Size(46, 23);
            this.tbxClearText.TabIndex = 99;
            this.tbxClearText.Text = "Rensa";
            this.tbxClearText.UseVisualStyleBackColor = true;
            this.tbxClearText.Click += new System.EventHandler(this.tbxClearText_Click);
            // 
            // MiljösamordnareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 475);
            this.Controls.Add(this.tbxClearText);
            this.Controls.Add(this.lblCallerNumber);
            this.Controls.Add(this.lblCallerAddress);
            this.Controls.Add(this.lblCallerName);
            this.Controls.Add(this.tbxCallerNumber);
            this.Controls.Add(this.tbxCallerAddress);
            this.Controls.Add(this.tbxCallerName);
            this.Controls.Add(this.lblCrimeInformation);
            this.Controls.Add(this.lblCrimeLocation);
            this.Controls.Add(this.tbxCrimeInformation);
            this.Controls.Add(this.tbxCrimeLocation);
            this.Controls.Add(this.btnAddCrime);
            this.Name = "MiljösamordnareForm";
            this.Text = "Miljösamordnareform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiljösamordnareForm_FormClosed);
            this.Load += new System.EventHandler(this.MiljösamordnareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCrime;
        private System.Windows.Forms.TextBox tbxCrimeLocation;
        private System.Windows.Forms.TextBox tbxCrimeInformation;
        private System.Windows.Forms.Label lblCrimeLocation;
        private System.Windows.Forms.Label lblCrimeInformation;
        private System.Windows.Forms.TextBox tbxCallerName;
        private System.Windows.Forms.TextBox tbxCallerAddress;
        private System.Windows.Forms.TextBox tbxCallerNumber;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.Label lblCallerAddress;
        private System.Windows.Forms.Label lblCallerNumber;
        private System.Windows.Forms.Button tbxClearText;
    }
}
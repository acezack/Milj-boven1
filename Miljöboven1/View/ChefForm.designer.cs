namespace Miljöboven1.View
{
    partial class ChefForm
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
            this.lblÄrende = new System.Windows.Forms.Label();
            this.cbxCrimeStatus = new System.Windows.Forms.ComboBox();
            this.lbxÄrenden = new System.Windows.Forms.ListBox();
            this.lblÄrendesinformation = new System.Windows.Forms.Label();
            this.rtbCrimeInformation = new System.Windows.Forms.RichTextBox();
            this.lblHändelseförlopp = new System.Windows.Forms.Label();
            this.lbxEvent = new System.Windows.Forms.ListBox();
            this.lblHandläggare = new System.Windows.Forms.Label();
            this.cbxHandläggare = new System.Windows.Forms.ComboBox();
            this.lblCrimeDate = new System.Windows.Forms.Label();
            this.lblCrimeLocation = new System.Windows.Forms.Label();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.lblCallerAddress = new System.Windows.Forms.Label();
            this.lblCallerNumber = new System.Windows.Forms.Label();
            this.tbxCallerName = new System.Windows.Forms.TextBox();
            this.tbxCallerNumber = new System.Windows.Forms.TextBox();
            this.tbxCrimeDate = new System.Windows.Forms.TextBox();
            this.tbxCrimeLocation = new System.Windows.Forms.TextBox();
            this.tbxCallerAddress = new System.Windows.Forms.TextBox();
            this.btnAssignCrime = new System.Windows.Forms.Button();
            this.labelHandläggare = new System.Windows.Forms.Label();
            this.tbxHandläggare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblÄrende
            // 
            this.lblÄrende.AutoSize = true;
            this.lblÄrende.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÄrende.Location = new System.Drawing.Point(12, 9);
            this.lblÄrende.Name = "lblÄrende";
            this.lblÄrende.Size = new System.Drawing.Size(93, 25);
            this.lblÄrende.TabIndex = 0;
            this.lblÄrende.Text = "Ärenden:";
            // 
            // cbxCrimeStatus
            // 
            this.cbxCrimeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCrimeStatus.FormattingEnabled = true;
            this.cbxCrimeStatus.Location = new System.Drawing.Point(111, 12);
            this.cbxCrimeStatus.Name = "cbxCrimeStatus";
            this.cbxCrimeStatus.Size = new System.Drawing.Size(82, 21);
            this.cbxCrimeStatus.TabIndex = 1;
            this.cbxCrimeStatus.SelectedIndexChanged += new System.EventHandler(this.cbxÄrendeStatus_SelectedIndexChanged);
            // 
            // lbxÄrenden
            // 
            this.lbxÄrenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxÄrenden.FormattingEnabled = true;
            this.lbxÄrenden.ItemHeight = 24;
            this.lbxÄrenden.Location = new System.Drawing.Point(17, 63);
            this.lbxÄrenden.Name = "lbxÄrenden";
            this.lbxÄrenden.Size = new System.Drawing.Size(176, 340);
            this.lbxÄrenden.TabIndex = 2;
            this.lbxÄrenden.SelectedIndexChanged += new System.EventHandler(this.lbxÄrenden_SelectedIndexChanged);
            // 
            // lblÄrendesinformation
            // 
            this.lblÄrendesinformation.AutoSize = true;
            this.lblÄrendesinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÄrendesinformation.Location = new System.Drawing.Point(199, 39);
            this.lblÄrendesinformation.Name = "lblÄrendesinformation";
            this.lblÄrendesinformation.Size = new System.Drawing.Size(170, 22);
            this.lblÄrendesinformation.TabIndex = 3;
            this.lblÄrendesinformation.Text = "Ärendesinformation:";
            // 
            // rtbCrimeInformation
            // 
            this.rtbCrimeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCrimeInformation.Location = new System.Drawing.Point(203, 64);
            this.rtbCrimeInformation.Name = "rtbCrimeInformation";
            this.rtbCrimeInformation.Size = new System.Drawing.Size(553, 118);
            this.rtbCrimeInformation.TabIndex = 4;
            this.rtbCrimeInformation.Text = "";
            // 
            // lblHändelseförlopp
            // 
            this.lblHändelseförlopp.AutoSize = true;
            this.lblHändelseförlopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHändelseförlopp.Location = new System.Drawing.Point(199, 262);
            this.lblHändelseförlopp.Name = "lblHändelseförlopp";
            this.lblHändelseförlopp.Size = new System.Drawing.Size(141, 22);
            this.lblHändelseförlopp.TabIndex = 5;
            this.lblHändelseförlopp.Text = "Händesleförlopp";
            // 
            // lbxEvent
            // 
            this.lbxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEvent.FormattingEnabled = true;
            this.lbxEvent.ItemHeight = 16;
            this.lbxEvent.Location = new System.Drawing.Point(203, 287);
            this.lbxEvent.Name = "lbxEvent";
            this.lbxEvent.Size = new System.Drawing.Size(553, 116);
            this.lbxEvent.TabIndex = 6;
            // 
            // lblHandläggare
            // 
            this.lblHandläggare.AutoSize = true;
            this.lblHandläggare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandläggare.Location = new System.Drawing.Point(14, 39);
            this.lblHandläggare.Name = "lblHandläggare";
            this.lblHandläggare.Size = new System.Drawing.Size(82, 15);
            this.lblHandläggare.TabIndex = 7;
            this.lblHandläggare.Text = "Handläggare:";
            // 
            // cbxHandläggare
            // 
            this.cbxHandläggare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHandläggare.FormattingEnabled = true;
            this.cbxHandläggare.Location = new System.Drawing.Point(111, 36);
            this.cbxHandläggare.Name = "cbxHandläggare";
            this.cbxHandläggare.Size = new System.Drawing.Size(82, 21);
            this.cbxHandläggare.TabIndex = 8;
            this.cbxHandläggare.SelectedIndexChanged += new System.EventHandler(this.cbxHandläggare_SelectedIndexChanged);
            // 
            // lblCrimeDate
            // 
            this.lblCrimeDate.AutoSize = true;
            this.lblCrimeDate.Location = new System.Drawing.Point(200, 191);
            this.lblCrimeDate.Name = "lblCrimeDate";
            this.lblCrimeDate.Size = new System.Drawing.Size(66, 13);
            this.lblCrimeDate.TabIndex = 9;
            this.lblCrimeDate.Text = "Brottsdatum:";
            // 
            // lblCrimeLocation
            // 
            this.lblCrimeLocation.AutoSize = true;
            this.lblCrimeLocation.Location = new System.Drawing.Point(200, 217);
            this.lblCrimeLocation.Name = "lblCrimeLocation";
            this.lblCrimeLocation.Size = new System.Drawing.Size(59, 13);
            this.lblCrimeLocation.TabIndex = 11;
            this.lblCrimeLocation.Text = "Brottsplats:";
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Location = new System.Drawing.Point(470, 191);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(94, 13);
            this.lblCallerName.TabIndex = 13;
            this.lblCallerName.Text = "Anmälarens namn:";
            // 
            // lblCallerAddress
            // 
            this.lblCallerAddress.AutoSize = true;
            this.lblCallerAddress.Location = new System.Drawing.Point(470, 217);
            this.lblCallerAddress.Name = "lblCallerAddress";
            this.lblCallerAddress.Size = new System.Drawing.Size(99, 13);
            this.lblCallerAddress.TabIndex = 15;
            this.lblCallerAddress.Text = "Anmälarens adress:";
            // 
            // lblCallerNumber
            // 
            this.lblCallerNumber.AutoSize = true;
            this.lblCallerNumber.Location = new System.Drawing.Point(470, 243);
            this.lblCallerNumber.Name = "lblCallerNumber";
            this.lblCallerNumber.Size = new System.Drawing.Size(105, 13);
            this.lblCallerNumber.TabIndex = 17;
            this.lblCallerNumber.Text = "Anmälarens nummer:";
            // 
            // tbxCallerName
            // 
            this.tbxCallerName.Location = new System.Drawing.Point(581, 188);
            this.tbxCallerName.Name = "tbxCallerName";
            this.tbxCallerName.ReadOnly = true;
            this.tbxCallerName.Size = new System.Drawing.Size(175, 20);
            this.tbxCallerName.TabIndex = 18;
            // 
            // tbxCallerNumber
            // 
            this.tbxCallerNumber.Location = new System.Drawing.Point(581, 240);
            this.tbxCallerNumber.Name = "tbxCallerNumber";
            this.tbxCallerNumber.ReadOnly = true;
            this.tbxCallerNumber.Size = new System.Drawing.Size(175, 20);
            this.tbxCallerNumber.TabIndex = 18;
            // 
            // tbxCrimeDate
            // 
            this.tbxCrimeDate.Location = new System.Drawing.Point(277, 188);
            this.tbxCrimeDate.Name = "tbxCrimeDate";
            this.tbxCrimeDate.ReadOnly = true;
            this.tbxCrimeDate.Size = new System.Drawing.Size(175, 20);
            this.tbxCrimeDate.TabIndex = 18;
            // 
            // tbxCrimeLocation
            // 
            this.tbxCrimeLocation.Location = new System.Drawing.Point(277, 214);
            this.tbxCrimeLocation.Name = "tbxCrimeLocation";
            this.tbxCrimeLocation.ReadOnly = true;
            this.tbxCrimeLocation.Size = new System.Drawing.Size(175, 20);
            this.tbxCrimeLocation.TabIndex = 18;
            // 
            // tbxCallerAddress
            // 
            this.tbxCallerAddress.Location = new System.Drawing.Point(581, 214);
            this.tbxCallerAddress.Name = "tbxCallerAddress";
            this.tbxCallerAddress.ReadOnly = true;
            this.tbxCallerAddress.Size = new System.Drawing.Size(175, 20);
            this.tbxCallerAddress.TabIndex = 18;
            // 
            // btnAssignCrime
            // 
            this.btnAssignCrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignCrime.Location = new System.Drawing.Point(606, 9);
            this.btnAssignCrime.Name = "btnAssignCrime";
            this.btnAssignCrime.Size = new System.Drawing.Size(150, 45);
            this.btnAssignCrime.TabIndex = 19;
            this.btnAssignCrime.Text = "Tilldela ärende";
            this.btnAssignCrime.UseVisualStyleBackColor = true;
            this.btnAssignCrime.Click += new System.EventHandler(this.btnAssignCrime_Click);
            // 
            // labelHandläggare
            // 
            this.labelHandläggare.AutoSize = true;
            this.labelHandläggare.Location = new System.Drawing.Point(200, 243);
            this.labelHandläggare.Name = "labelHandläggare";
            this.labelHandläggare.Size = new System.Drawing.Size(71, 13);
            this.labelHandläggare.TabIndex = 11;
            this.labelHandläggare.Text = "Handläggare:";
            // 
            // tbxHandläggare
            // 
            this.tbxHandläggare.Location = new System.Drawing.Point(277, 240);
            this.tbxHandläggare.Name = "tbxHandläggare";
            this.tbxHandläggare.ReadOnly = true;
            this.tbxHandläggare.Size = new System.Drawing.Size(175, 20);
            this.tbxHandläggare.TabIndex = 18;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 421);
            this.Controls.Add(this.btnAssignCrime);
            this.Controls.Add(this.tbxHandläggare);
            this.Controls.Add(this.tbxCrimeLocation);
            this.Controls.Add(this.tbxCrimeDate);
            this.Controls.Add(this.tbxCallerAddress);
            this.Controls.Add(this.tbxCallerNumber);
            this.Controls.Add(this.tbxCallerName);
            this.Controls.Add(this.lblCallerNumber);
            this.Controls.Add(this.lblCallerAddress);
            this.Controls.Add(this.lblCallerName);
            this.Controls.Add(this.labelHandläggare);
            this.Controls.Add(this.lblCrimeLocation);
            this.Controls.Add(this.lblCrimeDate);
            this.Controls.Add(this.cbxHandläggare);
            this.Controls.Add(this.lblHandläggare);
            this.Controls.Add(this.lbxEvent);
            this.Controls.Add(this.lblHändelseförlopp);
            this.Controls.Add(this.rtbCrimeInformation);
            this.Controls.Add(this.lblÄrendesinformation);
            this.Controls.Add(this.lbxÄrenden);
            this.Controls.Add(this.cbxCrimeStatus);
            this.Controls.Add(this.lblÄrende);
            this.DoubleBuffered = true;
            this.Name = "ChefForm";
            this.Text = "Chefform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChefForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblÄrende;
        private System.Windows.Forms.ComboBox cbxCrimeStatus;
        private System.Windows.Forms.ListBox lbxÄrenden;
        private System.Windows.Forms.Label lblÄrendesinformation;
        private System.Windows.Forms.RichTextBox rtbCrimeInformation;
        private System.Windows.Forms.Label lblHändelseförlopp;
        private System.Windows.Forms.ListBox lbxEvent;
        private System.Windows.Forms.Label lblHandläggare;
        private System.Windows.Forms.ComboBox cbxHandläggare;
        private System.Windows.Forms.Label lblCrimeDate;
        private System.Windows.Forms.Label lblCrimeLocation;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.Label lblCallerAddress;
        private System.Windows.Forms.Label lblCallerNumber;
        private System.Windows.Forms.TextBox tbxCallerName;
        private System.Windows.Forms.TextBox tbxCallerNumber;
        private System.Windows.Forms.TextBox tbxCrimeDate;
        private System.Windows.Forms.TextBox tbxCrimeLocation;
        private System.Windows.Forms.TextBox tbxCallerAddress;
        private System.Windows.Forms.Button btnAssignCrime;
        private System.Windows.Forms.Label labelHandläggare;
        private System.Windows.Forms.TextBox tbxHandläggare;
    }
}
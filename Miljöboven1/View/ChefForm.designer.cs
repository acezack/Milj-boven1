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
            this.rtbÄrendeinformation = new System.Windows.Forms.RichTextBox();
            this.lblHändelseförlopp = new System.Windows.Forms.Label();
            this.lbxEvent = new System.Windows.Forms.ListBox();
            this.lblHandläggare = new System.Windows.Forms.Label();
            this.cbxHandläggare = new System.Windows.Forms.ComboBox();
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
            // rtbÄrendeinformation
            // 
            this.rtbÄrendeinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbÄrendeinformation.Location = new System.Drawing.Point(203, 64);
            this.rtbÄrendeinformation.Name = "rtbÄrendeinformation";
            this.rtbÄrendeinformation.Size = new System.Drawing.Size(553, 66);
            this.rtbÄrendeinformation.TabIndex = 4;
            this.rtbÄrendeinformation.Text = "";
            // 
            // lblHändelseförlopp
            // 
            this.lblHändelseförlopp.AutoSize = true;
            this.lblHändelseförlopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHändelseförlopp.Location = new System.Drawing.Point(199, 150);
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
            this.lbxEvent.Location = new System.Drawing.Point(203, 175);
            this.lbxEvent.Name = "lbxEvent";
            this.lbxEvent.Size = new System.Drawing.Size(553, 228);
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
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 421);
            this.Controls.Add(this.cbxHandläggare);
            this.Controls.Add(this.lblHandläggare);
            this.Controls.Add(this.lbxEvent);
            this.Controls.Add(this.lblHändelseförlopp);
            this.Controls.Add(this.rtbÄrendeinformation);
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
        private System.Windows.Forms.RichTextBox rtbÄrendeinformation;
        private System.Windows.Forms.Label lblHändelseförlopp;
        private System.Windows.Forms.ListBox lbxEvent;
        private System.Windows.Forms.Label lblHandläggare;
        private System.Windows.Forms.ComboBox cbxHandläggare;
    }
}
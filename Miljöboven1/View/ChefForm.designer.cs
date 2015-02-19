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
            this.cbxÄrendeStatus = new System.Windows.Forms.ComboBox();
            this.lbxÄrenden = new System.Windows.Forms.ListBox();
            this.lblÄrendeinformation = new System.Windows.Forms.Label();
            this.rtbÄrendeinformation = new System.Windows.Forms.RichTextBox();
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
            // cbxÄrendeStatus
            // 
            this.cbxÄrendeStatus.FormattingEnabled = true;
            this.cbxÄrendeStatus.Location = new System.Drawing.Point(111, 12);
            this.cbxÄrendeStatus.Name = "cbxÄrendeStatus";
            this.cbxÄrendeStatus.Size = new System.Drawing.Size(82, 21);
            this.cbxÄrendeStatus.TabIndex = 1;
            this.cbxÄrendeStatus.SelectedIndexChanged += new System.EventHandler(this.cbxÄrendeStatus_SelectedIndexChanged);
            // 
            // lbxÄrenden
            // 
            this.lbxÄrenden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxÄrenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxÄrenden.FormattingEnabled = true;
            this.lbxÄrenden.ItemHeight = 20;
            this.lbxÄrenden.Location = new System.Drawing.Point(17, 39);
            this.lbxÄrenden.Name = "lbxÄrenden";
            this.lbxÄrenden.Size = new System.Drawing.Size(176, 404);
            this.lbxÄrenden.TabIndex = 2;
            // 
            // lblÄrendeinformation
            // 
            this.lblÄrendeinformation.AutoSize = true;
            this.lblÄrendeinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÄrendeinformation.Location = new System.Drawing.Point(199, 39);
            this.lblÄrendeinformation.Name = "lblÄrendeinformation";
            this.lblÄrendeinformation.Size = new System.Drawing.Size(161, 22);
            this.lblÄrendeinformation.TabIndex = 3;
            this.lblÄrendeinformation.Text = "Ärendeinformation:";
            // 
            // rtbÄrendeinformation
            // 
            this.rtbÄrendeinformation.Location = new System.Drawing.Point(203, 64);
            this.rtbÄrendeinformation.Name = "rtbÄrendeinformation";
            this.rtbÄrendeinformation.Size = new System.Drawing.Size(386, 66);
            this.rtbÄrendeinformation.TabIndex = 4;
            this.rtbÄrendeinformation.Text = "";
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 463);
            this.Controls.Add(this.rtbÄrendeinformation);
            this.Controls.Add(this.lblÄrendeinformation);
            this.Controls.Add(this.lbxÄrenden);
            this.Controls.Add(this.cbxÄrendeStatus);
            this.Controls.Add(this.lblÄrende);
            this.Name = "ChefForm";
            this.Text = "Chefform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChefForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblÄrende;
        private System.Windows.Forms.ComboBox cbxÄrendeStatus;
        private System.Windows.Forms.ListBox lbxÄrenden;
        private System.Windows.Forms.Label lblÄrendeinformation;
        private System.Windows.Forms.RichTextBox rtbÄrendeinformation;
    }
}
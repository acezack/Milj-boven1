namespace Miljöboven1.View
{
    partial class ChefAssignCrime
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
            this.lbxUnassignedCrimes = new System.Windows.Forms.ListBox();
            this.lblUnassignedCrimes = new System.Windows.Forms.Label();
            this.lbxInvestigator = new System.Windows.Forms.ListBox();
            this.lblHandläggare = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxUnassignedCrimes
            // 
            this.lbxUnassignedCrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUnassignedCrimes.FormattingEnabled = true;
            this.lbxUnassignedCrimes.ItemHeight = 24;
            this.lbxUnassignedCrimes.Location = new System.Drawing.Point(12, 57);
            this.lbxUnassignedCrimes.Name = "lbxUnassignedCrimes";
            this.lbxUnassignedCrimes.Size = new System.Drawing.Size(240, 364);
            this.lbxUnassignedCrimes.TabIndex = 0;
            // 
            // lblUnassignedCrimes
            // 
            this.lblUnassignedCrimes.AutoSize = true;
            this.lblUnassignedCrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassignedCrimes.Location = new System.Drawing.Point(37, 20);
            this.lblUnassignedCrimes.Name = "lblUnassignedCrimes";
            this.lblUnassignedCrimes.Size = new System.Drawing.Size(181, 25);
            this.lblUnassignedCrimes.TabIndex = 1;
            this.lblUnassignedCrimes.Text = "Otilldelade ärenden";
            // 
            // lbxHandläggare
            // 
            this.lbxInvestigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInvestigator.FormattingEnabled = true;
            this.lbxInvestigator.ItemHeight = 24;
            this.lbxInvestigator.Location = new System.Drawing.Point(272, 57);
            this.lbxInvestigator.Name = "lbxHandläggare";
            this.lbxInvestigator.Size = new System.Drawing.Size(240, 364);
            this.lbxInvestigator.TabIndex = 0;
            // 
            // lblHandläggare
            // 
            this.lblHandläggare.AutoSize = true;
            this.lblHandläggare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandläggare.Location = new System.Drawing.Point(329, 20);
            this.lblHandläggare.Name = "lblHandläggare";
            this.lblHandläggare.Size = new System.Drawing.Size(124, 25);
            this.lblHandläggare.TabIndex = 1;
            this.lblHandläggare.Text = "Handläggare";
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(182, 436);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(161, 45);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Tilldela valt ärende";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // ChefTilldelaÄrendeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 495);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblHandläggare);
            this.Controls.Add(this.lblUnassignedCrimes);
            this.Controls.Add(this.lbxInvestigator);
            this.Controls.Add(this.lbxUnassignedCrimes);
            this.Name = "ChefTilldelaÄrendeForm";
            this.Text = "Tilldela ärende";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxUnassignedCrimes;
        private System.Windows.Forms.Label lblUnassignedCrimes;
        private System.Windows.Forms.ListBox lbxInvestigator;
        private System.Windows.Forms.Label lblHandläggare;
        private System.Windows.Forms.Button btnAssign;
    }
}
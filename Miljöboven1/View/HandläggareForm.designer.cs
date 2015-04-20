namespace Miljöboven1.View
{
    partial class HandläggareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandläggareForm));
            this.rtbCrimeInfo = new System.Windows.Forms.RichTextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbEvent = new System.Windows.Forms.RichTextBox();
            this.btnFinishCrime = new System.Windows.Forms.Button();
            this.lbxEvent = new System.Windows.Forms.ListBox();
            this.lbCrimes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditEvents = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbCrimeInfo
            // 
            this.rtbCrimeInfo.BackColor = System.Drawing.SystemColors.Window;
            this.rtbCrimeInfo.Location = new System.Drawing.Point(189, 38);
            this.rtbCrimeInfo.Name = "rtbCrimeInfo";
            this.rtbCrimeInfo.ReadOnly = true;
            this.rtbCrimeInfo.Size = new System.Drawing.Size(535, 44);
            this.rtbCrimeInfo.TabIndex = 0;
            this.rtbCrimeInfo.Text = "Info om ärendet\n";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(480, 284);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(119, 37);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Lägg till händelse";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kommentar:";
            // 
            // rtbEvent
            // 
            this.rtbEvent.Location = new System.Drawing.Point(12, 295);
            this.rtbEvent.Name = "rtbEvent";
            this.rtbEvent.Size = new System.Drawing.Size(462, 26);
            this.rtbEvent.TabIndex = 0;
            this.rtbEvent.Text = "Kommentar";
            // 
            // btnFinishCrime
            // 
            this.btnFinishCrime.Location = new System.Drawing.Point(12, 192);
            this.btnFinishCrime.Name = "btnFinishCrime";
            this.btnFinishCrime.Size = new System.Drawing.Size(171, 43);
            this.btnFinishCrime.TabIndex = 0;
            this.btnFinishCrime.Text = "Slutför Miljöbrott";
            this.btnFinishCrime.UseVisualStyleBackColor = true;
            this.btnFinishCrime.Click += new System.EventHandler(this.btnFinishCrime_Click);
            // 
            // lbxEvent
            // 
            this.lbxEvent.FormattingEnabled = true;
            this.lbxEvent.Items.AddRange(new object[] {
            "21 / 1 - 2015   Besökte platsen och fixade så att man kan se ifall det är bra",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lbxEvent.Location = new System.Drawing.Point(189, 114);
            this.lbxEvent.Name = "lbxEvent";
            this.lbxEvent.Size = new System.Drawing.Size(535, 121);
            this.lbxEvent.TabIndex = 0;
            // 
            // lbCrimes
            // 
            this.lbCrimes.FormattingEnabled = true;
            this.lbCrimes.Location = new System.Drawing.Point(12, 12);
            this.lbCrimes.Name = "lbCrimes";
            this.lbCrimes.Size = new System.Drawing.Size(171, 173);
            this.lbCrimes.TabIndex = 0;
            this.lbCrimes.SelectedIndexChanged += new System.EventHandler(this.lbCrimes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ärendesinformation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Händelseförlopp:";
            // 
            // btnEditEvents
            // 
            this.btnEditEvents.Location = new System.Drawing.Point(605, 284);
            this.btnEditEvents.Name = "btnEditEvents";
            this.btnEditEvents.Size = new System.Drawing.Size(119, 37);
            this.btnEditEvents.TabIndex = 6;
            this.btnEditEvents.Text = "Redigera händelse";
            this.btnEditEvents.UseVisualStyleBackColor = true;
            this.btnEditEvents.Click += new System.EventHandler(this.btnEditEvents_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(605, 241);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 37);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Ta bort händelse";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // HandläggareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 334);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEditEvents);
            this.Controls.Add(this.rtbEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCrimes);
            this.Controls.Add(this.lbxEvent);
            this.Controls.Add(this.btnFinishCrime);
            this.Controls.Add(this.rtbCrimeInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HandläggareForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HandläggareForm_FormClosed);
            this.Load += new System.EventHandler(this.HandläggareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinishCrime;
        public System.Windows.Forms.RichTextBox rtbCrimeInfo;
        public System.Windows.Forms.RichTextBox rtbEvent;
        public System.Windows.Forms.ListBox lbxEvent;
        public System.Windows.Forms.ListBox lbCrimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditEvents;
        private System.Windows.Forms.Button btnRemove;
    }
}
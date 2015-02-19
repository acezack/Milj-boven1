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
            this.rtbÄrendeinformation = new System.Windows.Forms.RichTextBox();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKommentar = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbEvent = new System.Windows.Forms.ListBox();
            this.lbCrimes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRedigera = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbÄrendeinformation
            // 
            this.rtbÄrendeinformation.BackColor = System.Drawing.SystemColors.Window;
            this.rtbÄrendeinformation.Location = new System.Drawing.Point(189, 38);
            this.rtbÄrendeinformation.Name = "rtbÄrendeinformation";
            this.rtbÄrendeinformation.ReadOnly = true;
            this.rtbÄrendeinformation.Size = new System.Drawing.Size(535, 44);
            this.rtbÄrendeinformation.TabIndex = 0;
            this.rtbÄrendeinformation.Text = "Info om ärendet\n";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(480, 284);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(119, 37);
            this.btnSkicka.TabIndex = 0;
            this.btnSkicka.Text = "Lägg till händelse";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
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
            // rtbKommentar
            // 
            this.rtbKommentar.Location = new System.Drawing.Point(12, 295);
            this.rtbKommentar.Name = "rtbKommentar";
            this.rtbKommentar.Size = new System.Drawing.Size(462, 26);
            this.rtbKommentar.TabIndex = 0;
            this.rtbKommentar.Text = "Kommentar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Slutför Miljöbrott";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEvent
            // 
            this.lbEvent.FormattingEnabled = true;
            this.lbEvent.Items.AddRange(new object[] {
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
            this.lbEvent.Location = new System.Drawing.Point(189, 114);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(535, 121);
            this.lbEvent.TabIndex = 0;
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
            // btnRedigera
            // 
            this.btnRedigera.Location = new System.Drawing.Point(605, 284);
            this.btnRedigera.Name = "btnRedigera";
            this.btnRedigera.Size = new System.Drawing.Size(119, 37);
            this.btnRedigera.TabIndex = 6;
            this.btnRedigera.Text = "Redigera händelse";
            this.btnRedigera.UseVisualStyleBackColor = true;
            this.btnRedigera.Click += new System.EventHandler(this.btnRedigera_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(605, 241);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(119, 37);
            this.btnTaBort.TabIndex = 7;
            this.btnTaBort.Text = "Ta bort händelse";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // HandläggareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 334);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnRedigera);
            this.Controls.Add(this.rtbKommentar);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCrimes);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbÄrendeinformation);
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

        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox rtbÄrendeinformation;
        public System.Windows.Forms.RichTextBox rtbKommentar;
        public System.Windows.Forms.ListBox lbEvent;
        public System.Windows.Forms.ListBox lbCrimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRedigera;
        private System.Windows.Forms.Button btnTaBort;
    }
}
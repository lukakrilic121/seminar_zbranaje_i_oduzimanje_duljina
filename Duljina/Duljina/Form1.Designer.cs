namespace Duljina
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.IznosDuljine_1 = new System.Windows.Forms.TextBox();
            this.ListaDuljina_1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IznosDuljine_2 = new System.Windows.Forms.TextBox();
            this.ListaDuljine_2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Operacije = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IzracunataVrijednost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Velicina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznos prve duljine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IznosDuljine_1
            // 
            this.IznosDuljine_1.Location = new System.Drawing.Point(93, 34);
            this.IznosDuljine_1.Name = "IznosDuljine_1";
            this.IznosDuljine_1.Size = new System.Drawing.Size(96, 20);
            this.IznosDuljine_1.TabIndex = 1;
            // 
            // ListaDuljina_1
            // 
            this.ListaDuljina_1.FormattingEnabled = true;
            this.ListaDuljina_1.Items.AddRange(new object[] {
            "m",
            "km",
            "cm",
            "mm",
            "in",
            "feet",
            "yard",
            "mile"});
            this.ListaDuljina_1.Location = new System.Drawing.Point(93, 86);
            this.ListaDuljina_1.Name = "ListaDuljina_1";
            this.ListaDuljina_1.Size = new System.Drawing.Size(67, 95);
            this.ListaDuljina_1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veličine prve duljine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iznos druge duljine";
            // 
            // IznosDuljine_2
            // 
            this.IznosDuljine_2.Location = new System.Drawing.Point(339, 34);
            this.IznosDuljine_2.Name = "IznosDuljine_2";
            this.IznosDuljine_2.Size = new System.Drawing.Size(100, 20);
            this.IznosDuljine_2.TabIndex = 5;
            // 
            // ListaDuljine_2
            // 
            this.ListaDuljine_2.FormattingEnabled = true;
            this.ListaDuljine_2.Items.AddRange(new object[] {
            "m",
            "km",
            "cm",
            "mm",
            "in",
            "feet",
            "yard",
            "mile"});
            this.ListaDuljine_2.Location = new System.Drawing.Point(339, 86);
            this.ListaDuljine_2.Name = "ListaDuljine_2";
            this.ListaDuljine_2.Size = new System.Drawing.Size(67, 95);
            this.ListaDuljine_2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Veličine druge duljine";
            // 
            // Operacije
            // 
            this.Operacije.FormattingEnabled = true;
            this.Operacije.Items.AddRange(new object[] {
            "Zbrajanje",
            "Oduzimanje"});
            this.Operacije.Location = new System.Drawing.Point(205, 196);
            this.Operacije.Name = "Operacije";
            this.Operacije.Size = new System.Drawing.Size(89, 30);
            this.Operacije.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operacije";
            // 
            // IzracunataVrijednost
            // 
            this.IzracunataVrijednost.Location = new System.Drawing.Point(193, 247);
            this.IzracunataVrijednost.Name = "IzracunataVrijednost";
            this.IzracunataVrijednost.Size = new System.Drawing.Size(101, 20);
            this.IzracunataVrijednost.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Velicina
            // 
            this.Velicina.AutoSize = true;
            this.Velicina.Location = new System.Drawing.Point(300, 247);
            this.Velicina.Name = "Velicina";
            this.Velicina.Size = new System.Drawing.Size(0, 13);
            this.Velicina.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 350);
            this.Controls.Add(this.Velicina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IzracunataVrijednost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Operacije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaDuljine_2);
            this.Controls.Add(this.IznosDuljine_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaDuljina_1);
            this.Controls.Add(this.IznosDuljine_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IznosDuljine_1;
        private System.Windows.Forms.ListBox ListaDuljina_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IznosDuljine_2;
        private System.Windows.Forms.ListBox ListaDuljine_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Operacije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IzracunataVrijednost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Velicina;
    }
}


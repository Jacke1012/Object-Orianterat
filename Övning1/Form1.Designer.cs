namespace Övning1
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
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAntalDagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBoka = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxResor = new System.Windows.Forms.ListBox();
            this.BtnSök = new System.Windows.Forms.Button();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kund:";
            // 
            // tbxKund
            // 
            this.tbxKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKund.Location = new System.Drawing.Point(125, 44);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(91, 23);
            this.tbxKund.TabIndex = 1;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDestination.Location = new System.Drawing.Point(125, 73);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(91, 23);
            this.tbxDestination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // tbxAntalDagar
            // 
            this.tbxAntalDagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAntalDagar.Location = new System.Drawing.Point(125, 102);
            this.tbxAntalDagar.Name = "tbxAntalDagar";
            this.tbxAntalDagar.Size = new System.Drawing.Size(91, 23);
            this.tbxAntalDagar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Antal dagar";
            // 
            // BtnBoka
            // 
            this.BtnBoka.Location = new System.Drawing.Point(243, 102);
            this.BtnBoka.Name = "BtnBoka";
            this.BtnBoka.Size = new System.Drawing.Size(61, 22);
            this.BtnBoka.TabIndex = 6;
            this.BtnBoka.Text = "Boka";
            this.BtnBoka.UseVisualStyleBackColor = true;
            this.BtnBoka.Click += new System.EventHandler(this.BtnBoka_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxResor);
            this.groupBox1.Controls.Add(this.BtnSök);
            this.groupBox1.Controls.Add(this.tbxNamn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(63, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resor";
            // 
            // lbxResor
            // 
            this.lbxResor.FormattingEnabled = true;
            this.lbxResor.Location = new System.Drawing.Point(24, 56);
            this.lbxResor.Name = "lbxResor";
            this.lbxResor.Size = new System.Drawing.Size(173, 134);
            this.lbxResor.TabIndex = 11;
            // 
            // BtnSök
            // 
            this.BtnSök.Location = new System.Drawing.Point(168, 21);
            this.BtnSök.Name = "BtnSök";
            this.BtnSök.Size = new System.Drawing.Size(62, 20);
            this.BtnSök.TabIndex = 10;
            this.BtnSök.Text = "Sök";
            this.BtnSök.UseVisualStyleBackColor = true;
            this.BtnSök.Click += new System.EventHandler(this.BtnSök_Click);
            // 
            // tbxNamn
            // 
            this.tbxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamn.Location = new System.Drawing.Point(62, 19);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(91, 23);
            this.tbxNamn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Namn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBoka);
            this.Controls.Add(this.tbxAntalDagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKund);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAntalDagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBoka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxResor;
        private System.Windows.Forms.Button BtnSök;
    }
}


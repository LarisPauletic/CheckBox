namespace CheckBox_Vjezba
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
            this.btnDoručak = new System.Windows.Forms.CheckBox();
            this.btnRučak = new System.Windows.Forms.CheckBox();
            this.btnVečera = new System.Windows.Forms.CheckBox();
            this.sakrijNarudzbu = new System.Windows.Forms.CheckBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.btnPošalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoručak
            // 
            this.btnDoručak.AutoSize = true;
            this.btnDoručak.Location = new System.Drawing.Point(187, 48);
            this.btnDoručak.Name = "btnDoručak";
            this.btnDoručak.Size = new System.Drawing.Size(83, 21);
            this.btnDoručak.TabIndex = 0;
            this.btnDoručak.Text = "Doručak";
            this.btnDoručak.UseVisualStyleBackColor = true;
            // 
            // btnRučak
            // 
            this.btnRučak.AutoSize = true;
            this.btnRučak.Location = new System.Drawing.Point(187, 91);
            this.btnRučak.Name = "btnRučak";
            this.btnRučak.Size = new System.Drawing.Size(70, 21);
            this.btnRučak.TabIndex = 1;
            this.btnRučak.Text = "Ručak";
            this.btnRučak.UseVisualStyleBackColor = true;
            // 
            // btnVečera
            // 
            this.btnVečera.AutoSize = true;
            this.btnVečera.Location = new System.Drawing.Point(187, 134);
            this.btnVečera.Name = "btnVečera";
            this.btnVečera.Size = new System.Drawing.Size(75, 21);
            this.btnVečera.TabIndex = 2;
            this.btnVečera.Text = "Večera";
            this.btnVečera.UseVisualStyleBackColor = true;
            // 
            // sakrijNarudzbu
            // 
            this.sakrijNarudzbu.AutoSize = true;
            this.sakrijNarudzbu.Location = new System.Drawing.Point(345, 213);
            this.sakrijNarudzbu.Name = "sakrijNarudzbu";
            this.sakrijNarudzbu.Size = new System.Drawing.Size(129, 21);
            this.sakrijNarudzbu.TabIndex = 3;
            this.sakrijNarudzbu.Text = "Sakrij narudžbu";
            this.sakrijNarudzbu.UseVisualStyleBackColor = true;
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(360, 48);
            this.txtBx.Multiline = true;
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(199, 107);
            this.txtBx.TabIndex = 4;
            // 
            // btnPošalji
            // 
            this.btnPošalji.Location = new System.Drawing.Point(174, 197);
            this.btnPošalji.Name = "btnPošalji";
            this.btnPošalji.Size = new System.Drawing.Size(111, 50);
            this.btnPošalji.TabIndex = 5;
            this.btnPošalji.Text = "Pošalji";
            this.btnPošalji.UseVisualStyleBackColor = true;
            this.btnPošalji.Click += new System.EventHandler(this.btnPošalji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPošalji);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.sakrijNarudzbu);
            this.Controls.Add(this.btnVečera);
            this.Controls.Add(this.btnRučak);
            this.Controls.Add(this.btnDoručak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox btnDoručak;
        private System.Windows.Forms.CheckBox btnRučak;
        private System.Windows.Forms.CheckBox btnVečera;
        private System.Windows.Forms.CheckBox sakrijNarudzbu;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Button btnPošalji;
    }
}


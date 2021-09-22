namespace _20210922
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
            this.txt_sugar = new System.Windows.Forms.TextBox();
            this.lbl_sugar = new System.Windows.Forms.Label();
            this.lbl_kerulet = new System.Windows.Forms.Label();
            this.lbl_terulet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_kor = new System.Windows.Forms.Button();
            this.btn_gomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sugar
            // 
            this.txt_sugar.Location = new System.Drawing.Point(219, 95);
            this.txt_sugar.Name = "txt_sugar";
            this.txt_sugar.Size = new System.Drawing.Size(100, 20);
            this.txt_sugar.TabIndex = 0;
            this.txt_sugar.TextChanged += new System.EventHandler(this.Txt_sugar_TextChanged);
            // 
            // lbl_sugar
            // 
            this.lbl_sugar.AutoSize = true;
            this.lbl_sugar.Location = new System.Drawing.Point(157, 98);
            this.lbl_sugar.Name = "lbl_sugar";
            this.lbl_sugar.Size = new System.Drawing.Size(35, 13);
            this.lbl_sugar.TabIndex = 1;
            this.lbl_sugar.Text = "Sugár";
            // 
            // lbl_kerulet
            // 
            this.lbl_kerulet.AutoSize = true;
            this.lbl_kerulet.Location = new System.Drawing.Point(230, 210);
            this.lbl_kerulet.Name = "lbl_kerulet";
            this.lbl_kerulet.Size = new System.Drawing.Size(64, 13);
            this.lbl_kerulet.TabIndex = 2;
            this.lbl_kerulet.Text = "Kör kerülete";
            // 
            // lbl_terulet
            // 
            this.lbl_terulet.AutoSize = true;
            this.lbl_terulet.Location = new System.Drawing.Point(485, 210);
            this.lbl_terulet.Name = "lbl_terulet";
            this.lbl_terulet.Size = new System.Drawing.Size(61, 13);
            this.lbl_terulet.TabIndex = 3;
            this.lbl_terulet.Text = "Kör területe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btn_kor
            // 
            this.btn_kor.Location = new System.Drawing.Point(219, 296);
            this.btn_kor.Name = "btn_kor";
            this.btn_kor.Size = new System.Drawing.Size(75, 23);
            this.btn_kor.TabIndex = 6;
            this.btn_kor.Text = "Kör";
            this.btn_kor.UseVisualStyleBackColor = true;
            this.btn_kor.Click += new System.EventHandler(this.Btn_kor_Click);
            // 
            // btn_gomb
            // 
            this.btn_gomb.Location = new System.Drawing.Point(488, 296);
            this.btn_gomb.Name = "btn_gomb";
            this.btn_gomb.Size = new System.Drawing.Size(75, 23);
            this.btn_gomb.TabIndex = 7;
            this.btn_gomb.Text = "Gömb";
            this.btn_gomb.UseVisualStyleBackColor = true;
            this.btn_gomb.Click += new System.EventHandler(this.Btn_gomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gomb);
            this.Controls.Add(this.btn_kor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_terulet);
            this.Controls.Add(this.lbl_kerulet);
            this.Controls.Add(this.lbl_sugar);
            this.Controls.Add(this.txt_sugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sugar;
        private System.Windows.Forms.Label lbl_sugar;
        private System.Windows.Forms.Label lbl_kerulet;
        private System.Windows.Forms.Label lbl_terulet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_kor;
        private System.Windows.Forms.Button btn_gomb;
    }
}


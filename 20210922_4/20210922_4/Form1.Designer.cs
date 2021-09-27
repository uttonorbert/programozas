namespace _20210922_4
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
            this.lbl_elso = new System.Windows.Forms.Label();
            this.lbl_szam = new System.Windows.Forms.Label();
            this.lbl_harmadik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_rendez = new System.Windows.Forms.Button();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_elso
            // 
            this.lbl_elso.AutoSize = true;
            this.lbl_elso.Location = new System.Drawing.Point(170, 74);
            this.lbl_elso.Name = "lbl_elso";
            this.lbl_elso.Size = new System.Drawing.Size(54, 13);
            this.lbl_elso.TabIndex = 0;
            this.lbl_elso.Text = "Első szám";
            // 
            // lbl_szam
            // 
            this.lbl_szam.AutoSize = true;
            this.lbl_szam.Location = new System.Drawing.Point(170, 120);
            this.lbl_szam.Name = "lbl_szam";
            this.lbl_szam.Size = new System.Drawing.Size(76, 13);
            this.lbl_szam.TabIndex = 1;
            this.lbl_szam.Text = "Második Szám";
            this.lbl_szam.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lbl_harmadik
            // 
            this.lbl_harmadik.AutoSize = true;
            this.lbl_harmadik.Location = new System.Drawing.Point(170, 172);
            this.lbl_harmadik.Name = "lbl_harmadik";
            this.lbl_harmadik.Size = new System.Drawing.Size(79, 13);
            this.lbl_harmadik.TabIndex = 2;
            this.lbl_harmadik.Text = "Harmadik szám";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_rendez
            // 
            this.btn_rendez.Location = new System.Drawing.Point(197, 303);
            this.btn_rendez.Name = "btn_rendez";
            this.btn_rendez.Size = new System.Drawing.Size(75, 23);
            this.btn_rendez.TabIndex = 6;
            this.btn_rendez.Text = "Rendez";
            this.btn_rendez.UseVisualStyleBackColor = true;
            this.btn_rendez.Click += new System.EventHandler(this.Btn_rendez_Click);
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(384, 303);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 7;
            this.btn_kilepes.Text = "Bezár";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.btn_rendez);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_harmadik);
            this.Controls.Add(this.lbl_szam);
            this.Controls.Add(this.lbl_elso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_elso;
        private System.Windows.Forms.Label lbl_szam;
        private System.Windows.Forms.Label lbl_harmadik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_rendez;
        private System.Windows.Forms.Button btn_kilepes;
    }
}


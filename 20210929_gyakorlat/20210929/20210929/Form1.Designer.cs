namespace _20210929
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
            this.btn_szamitas = new System.Windows.Forms.Button();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.lbl_szam = new System.Windows.Forms.Label();
            this.lbl_Négyzetgyök = new System.Windows.Forms.Label();
            this.txtbox_felso = new System.Windows.Forms.TextBox();
            this.txtbox_also = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_szamitas
            // 
            this.btn_szamitas.Location = new System.Drawing.Point(225, 318);
            this.btn_szamitas.Name = "btn_szamitas";
            this.btn_szamitas.Size = new System.Drawing.Size(75, 23);
            this.btn_szamitas.TabIndex = 0;
            this.btn_szamitas.Text = "Számitás";
            this.btn_szamitas.UseVisualStyleBackColor = true;
            this.btn_szamitas.Click += new System.EventHandler(this.Btn_szamitas_Click);
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(356, 318);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 1;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.Btn_kilepes_Click);
            // 
            // lbl_szam
            // 
            this.lbl_szam.AutoSize = true;
            this.lbl_szam.Location = new System.Drawing.Point(225, 155);
            this.lbl_szam.Name = "lbl_szam";
            this.lbl_szam.Size = new System.Drawing.Size(33, 13);
            this.lbl_szam.TabIndex = 2;
            this.lbl_szam.Text = "Szám";
            // 
            // lbl_Négyzetgyök
            // 
            this.lbl_Négyzetgyök.AutoSize = true;
            this.lbl_Négyzetgyök.Location = new System.Drawing.Point(225, 218);
            this.lbl_Négyzetgyök.Name = "lbl_Négyzetgyök";
            this.lbl_Négyzetgyök.Size = new System.Drawing.Size(69, 13);
            this.lbl_Négyzetgyök.TabIndex = 3;
            this.lbl_Négyzetgyök.Text = "Négyzetgyök";
            // 
            // txtbox_felso
            // 
            this.txtbox_felso.Location = new System.Drawing.Point(371, 155);
            this.txtbox_felso.Name = "txtbox_felso";
            this.txtbox_felso.Size = new System.Drawing.Size(100, 20);
            this.txtbox_felso.TabIndex = 4;
            // 
            // txtbox_also
            // 
            this.txtbox_also.Location = new System.Drawing.Point(371, 211);
            this.txtbox_also.Name = "txtbox_also";
            this.txtbox_also.Size = new System.Drawing.Size(100, 20);
            this.txtbox_also.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_also);
            this.Controls.Add(this.txtbox_felso);
            this.Controls.Add(this.lbl_Négyzetgyök);
            this.Controls.Add(this.lbl_szam);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.btn_szamitas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_szamitas;
        private System.Windows.Forms.Button btn_kilepes;
        private System.Windows.Forms.Label lbl_szam;
        private System.Windows.Forms.Label lbl_Négyzetgyök;
        private System.Windows.Forms.TextBox txtbox_felso;
        private System.Windows.Forms.TextBox txtbox_also;
    }
}


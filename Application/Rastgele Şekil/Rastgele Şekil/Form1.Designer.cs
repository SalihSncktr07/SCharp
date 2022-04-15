namespace Rastgele_Şekil
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCevap1 = new System.Windows.Forms.Button();
            this.btnCevap2 = new System.Windows.Forms.Button();
            this.btnCevap3 = new System.Windows.Forms.Button();
            this.btnCevap4 = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCevap1
            // 
            this.btnCevap1.Location = new System.Drawing.Point(61, 270);
            this.btnCevap1.Name = "btnCevap1";
            this.btnCevap1.Size = new System.Drawing.Size(106, 56);
            this.btnCevap1.TabIndex = 1;
            this.btnCevap1.Text = "button1";
            this.btnCevap1.UseVisualStyleBackColor = true;
            // 
            // btnCevap2
            // 
            this.btnCevap2.Location = new System.Drawing.Point(214, 270);
            this.btnCevap2.Name = "btnCevap2";
            this.btnCevap2.Size = new System.Drawing.Size(106, 56);
            this.btnCevap2.TabIndex = 1;
            this.btnCevap2.Text = "button1";
            this.btnCevap2.UseVisualStyleBackColor = true;
            // 
            // btnCevap3
            // 
            this.btnCevap3.Location = new System.Drawing.Point(61, 367);
            this.btnCevap3.Name = "btnCevap3";
            this.btnCevap3.Size = new System.Drawing.Size(106, 56);
            this.btnCevap3.TabIndex = 1;
            this.btnCevap3.Text = "button1";
            this.btnCevap3.UseVisualStyleBackColor = true;
            // 
            // btnCevap4
            // 
            this.btnCevap4.Location = new System.Drawing.Point(214, 367);
            this.btnCevap4.Name = "btnCevap4";
            this.btnCevap4.Size = new System.Drawing.Size(106, 56);
            this.btnCevap4.TabIndex = 1;
            this.btnCevap4.Text = "button1";
            this.btnCevap4.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(463, 51);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(106, 56);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(484, 242);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(44, 16);
            this.lblDogru.TabIndex = 2;
            this.lblDogru.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puan=";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(527, 173);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(14, 16);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnCevap4);
            this.Controls.Add(this.btnCevap3);
            this.Controls.Add(this.btnCevap2);
            this.Controls.Add(this.btnCevap1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCevap1;
        private System.Windows.Forms.Button btnCevap2;
        private System.Windows.Forms.Button btnCevap3;
        private System.Windows.Forms.Button btnCevap4;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
    }
}


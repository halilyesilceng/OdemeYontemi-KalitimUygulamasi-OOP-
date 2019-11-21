namespace KalitimUygulamasiOdeme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Test = new System.Windows.Forms.Button();
            this.lblProgramTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Test.Location = new System.Drawing.Point(302, 191);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(160, 46);
            this.Test.TabIndex = 0;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // lblProgramTest
            // 
            this.lblProgramTest.AutoSize = true;
            this.lblProgramTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.lblProgramTest.Location = new System.Drawing.Point(213, 124);
            this.lblProgramTest.Name = "lblProgramTest";
            this.lblProgramTest.Size = new System.Drawing.Size(368, 48);
            this.lblProgramTest.TabIndex = 1;
            this.lblProgramTest.Text = "PROGRAM TEST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProgramTest);
            this.Controls.Add(this.Test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Label lblProgramTest;
    }
}


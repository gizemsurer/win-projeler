namespace WinFormsProject02
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yalnizkarakter = new System.Windows.Forms.TextBox();
            this.txt_yalnizsayi = new System.Windows.Forms.TextBox();
            this.txt_CharacterCasingToUpper = new System.Windows.Forms.TextBox();
            this.txt_CharacterCasingToLower = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter Gir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı Gir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karakter Büyütme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Karakter Küçültme";
            // 
            // txt_yalnizkarakter
            // 
            this.txt_yalnizkarakter.Location = new System.Drawing.Point(155, 46);
            this.txt_yalnizkarakter.Name = "txt_yalnizkarakter";
            this.txt_yalnizkarakter.Size = new System.Drawing.Size(100, 20);
            this.txt_yalnizkarakter.TabIndex = 4;
            this.txt_yalnizkarakter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yalnizkarakter_KeyPress);
            this.txt_yalnizkarakter.MouseEnter += new System.EventHandler(this.txt_yalnizkarakter_MouseEnter);
            this.txt_yalnizkarakter.MouseLeave += new System.EventHandler(this.txt_yalnizkarakter_MouseLeave);
            // 
            // txt_yalnizsayi
            // 
            this.txt_yalnizsayi.Location = new System.Drawing.Point(155, 89);
            this.txt_yalnizsayi.Name = "txt_yalnizsayi";
            this.txt_yalnizsayi.Size = new System.Drawing.Size(100, 20);
            this.txt_yalnizsayi.TabIndex = 5;
            this.txt_yalnizsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yalnizsayi_KeyPress);
            // 
            // txt_CharacterCasingToUpper
            // 
            this.txt_CharacterCasingToUpper.Location = new System.Drawing.Point(155, 122);
            this.txt_CharacterCasingToUpper.Name = "txt_CharacterCasingToUpper";
            this.txt_CharacterCasingToUpper.Size = new System.Drawing.Size(100, 20);
            this.txt_CharacterCasingToUpper.TabIndex = 6;
            this.txt_CharacterCasingToUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToUpper_KeyPress);
            // 
            // txt_CharacterCasingToLower
            // 
            this.txt_CharacterCasingToLower.Location = new System.Drawing.Point(155, 174);
            this.txt_CharacterCasingToLower.Name = "txt_CharacterCasingToLower";
            this.txt_CharacterCasingToLower.Size = new System.Drawing.Size(100, 20);
            this.txt_CharacterCasingToLower.TabIndex = 7;
            this.txt_CharacterCasingToLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToLower_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_CharacterCasingToLower);
            this.Controls.Add(this.txt_CharacterCasingToUpper);
            this.Controls.Add(this.txt_yalnizsayi);
            this.Controls.Add(this.txt_yalnizkarakter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yalnizkarakter;
        private System.Windows.Forms.TextBox txt_yalnizsayi;
        private System.Windows.Forms.TextBox txt_CharacterCasingToUpper;
        private System.Windows.Forms.TextBox txt_CharacterCasingToLower;
        private System.Windows.Forms.TextBox textBox1;
    }
}


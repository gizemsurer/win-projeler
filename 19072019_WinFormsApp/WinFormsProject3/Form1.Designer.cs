namespace WinFormsProject3
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
            this.txtbox_olay = new System.Windows.Forms.TextBox();
            this.listBox_olay = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_olay
            // 
            this.txtbox_olay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtbox_olay.Location = new System.Drawing.Point(164, 67);
            this.txtbox_olay.Multiline = true;
            this.txtbox_olay.Name = "txtbox_olay";
            this.txtbox_olay.Size = new System.Drawing.Size(252, 95);
            this.txtbox_olay.TabIndex = 0;
            this.txtbox_olay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_olay_KeyDown);
            this.txtbox_olay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_olay_KeyPress);
            this.txtbox_olay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbox_olay_KeyUp);
            // 
            // listBox_olay
            // 
            this.listBox_olay.FormattingEnabled = true;
            this.listBox_olay.Location = new System.Drawing.Point(164, 182);
            this.listBox_olay.Name = "listBox_olay";
            this.listBox_olay.Size = new System.Drawing.Size(252, 95);
            this.listBox_olay.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(164, 325);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listBox_olay);
            this.Controls.Add(this.txtbox_olay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_olay;
        private System.Windows.Forms.ListBox listBox_olay;
        private System.Windows.Forms.Button btnTemizle;
    }
}


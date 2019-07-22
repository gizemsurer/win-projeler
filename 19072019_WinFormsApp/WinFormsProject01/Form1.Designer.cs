namespace WinFormsProject01
{
    partial class FrmDonguler
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
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.listBoxDowhile = new System.Windows.Forms.ListBox();
            this.listBoxIEnum = new System.Windows.Forms.ListBox();
            this.listBoxForeach = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnIEnum = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar={10, 20, 25, 28, 34} kümesinin içindeki sayıları ve en altına bu sayıları" +
    "n toplamını gösterecek Döngü kodlarını yazınız. \r\n\r\n";
            // 
            // listBoxFor
            // 
            this.listBoxFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.Location = new System.Drawing.Point(12, 56);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(120, 225);
            this.listBoxFor.TabIndex = 1;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.Location = new System.Drawing.Point(160, 56);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(120, 225);
            this.listBoxWhile.TabIndex = 2;
            // 
            // listBoxDowhile
            // 
            this.listBoxDowhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxDowhile.FormattingEnabled = true;
            this.listBoxDowhile.Location = new System.Drawing.Point(296, 56);
            this.listBoxDowhile.Name = "listBoxDowhile";
            this.listBoxDowhile.Size = new System.Drawing.Size(120, 225);
            this.listBoxDowhile.TabIndex = 3;
            // 
            // listBoxIEnum
            // 
            this.listBoxIEnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxIEnum.FormattingEnabled = true;
            this.listBoxIEnum.Location = new System.Drawing.Point(437, 56);
            this.listBoxIEnum.Name = "listBoxIEnum";
            this.listBoxIEnum.Size = new System.Drawing.Size(120, 225);
            this.listBoxIEnum.TabIndex = 4;
            // 
            // listBoxForeach
            // 
            this.listBoxForeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxForeach.FormattingEnabled = true;
            this.listBoxForeach.Location = new System.Drawing.Point(581, 56);
            this.listBoxForeach.Name = "listBoxForeach";
            this.listBoxForeach.Size = new System.Drawing.Size(120, 225);
            this.listBoxForeach.TabIndex = 5;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFor.Location = new System.Drawing.Point(28, 299);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 34);
            this.btnFor.TabIndex = 6;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.Aqua;
            this.btnWhile.Location = new System.Drawing.Point(179, 299);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 34);
            this.btnWhile.TabIndex = 7;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDoWhile.Location = new System.Drawing.Point(313, 299);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 34);
            this.btnDoWhile.TabIndex = 8;
            this.btnDoWhile.Text = "DoWhile";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnIEnum
            // 
            this.btnIEnum.BackColor = System.Drawing.Color.Teal;
            this.btnIEnum.Location = new System.Drawing.Point(464, 299);
            this.btnIEnum.Name = "btnIEnum";
            this.btnIEnum.Size = new System.Drawing.Size(75, 34);
            this.btnIEnum.TabIndex = 9;
            this.btnIEnum.Text = "IEnum";
            this.btnIEnum.UseVisualStyleBackColor = false;
            this.btnIEnum.Click += new System.EventHandler(this.btnIEnum_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.BackColor = System.Drawing.Color.Red;
            this.btnForeach.Location = new System.Drawing.Point(605, 299);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(75, 34);
            this.btnForeach.TabIndex = 10;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = false;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // FrmDonguler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsProject01.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnIEnum);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.listBoxForeach);
            this.Controls.Add(this.listBoxIEnum);
            this.Controls.Add(this.listBoxDowhile);
            this.Controls.Add(this.listBoxWhile);
            this.Controls.Add(this.listBoxFor);
            this.Controls.Add(this.label1);
            this.Name = "FrmDonguler";
            this.Text = "Döngüler ve Listbox Formu";
            this.Load += new System.EventHandler(this.FrmDonguler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.ListBox listBoxDowhile;
        private System.Windows.Forms.ListBox listBoxIEnum;
        private System.Windows.Forms.ListBox listBoxForeach;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnIEnum;
        private System.Windows.Forms.Button btnForeach;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject4
{
    public partial class Form1 : Form
    {//Project: Orders for mause Movement
        //public string strButtonTemizleText;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string s)
        {
            InitializeComponent();
            btnTemizle.Text = s;
        }

        private void pnlOlay_MouseDown(object sender, MouseEventArgs e)
        {
            //mausedown eventi gerçekleştiğinde bu method gerçekleşecek.
            //bu bilgi form1.designer.cs dosyasında belirtiliyor.
            //bu method kendi içerisinde yaz methodunu çağırıyor.
            //yaz methodu tek parametre alıyor  
            //(1 adet string tipinde parametre alıyır)
            Yaz("mousedown");
        }
        private void Yaz(string EventAdi)
        {
            lstBoxOlay.Items.Add(string.Format("{1}{0}", EventAdi, DateTime.Now));
            this.lstBoxOlay.SelectedIndex = this.lstBoxOlay.Items.Count - 1;
        }

        private void pnlOlay_MouseEnter(object sender, EventArgs e)
        {
            Yaz("mause enter");
        }

        private void pnlOlay_MouseHover(object sender, EventArgs e)
        {
            Yaz("mause hover");
        }

        private void pnlOlay_MouseMove(object sender, MouseEventArgs e)
        {
            Yaz("mause move");
        }

        private void pnlOlay_MouseUp(object sender, MouseEventArgs e)
        {
            Yaz("mause up");
        }

        private void pnlOlay_MouseLeave(object sender, EventArgs e)
        {
            Yaz("mause leave");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnTemizle.Text=strButtonTemizleText;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstBoxOlay.Items.Clear();
        }
    }
}

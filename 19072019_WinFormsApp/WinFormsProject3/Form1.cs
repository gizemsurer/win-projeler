using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {//Project:Event Order for Keys
            InitializeComponent();
        }

        private void txtbox_olay_KeyDown(object sender, KeyEventArgs e)
        {
            Yaz("key down oldu");

        }
        private void Yaz(string OlayAdi)
        {    //string concatenation yöntemi
            //string str = DateTime.Now + " " + OlayAdi;
            //listBox_olay.Items.Add(str);
            
            //string classının format methodu yöntemi
            listBox_olay.Items.Add(string.Format("{1}{0}", OlayAdi, DateTime.Now));
            
            //string ınterpolation yöntemi
           //string s2 =$"{ DateTime.Now}{ OlayAdi}";
           // listBox_olay.Items.Add(s2);
        }

        private void txtbox_olay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Yaz("key press oldu");

        }

        private void txtbox_olay_KeyUp(object sender, KeyEventArgs e)
        {
            Yaz("keyup oldu");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox_olay.Items.Clear();
        }
    }
}

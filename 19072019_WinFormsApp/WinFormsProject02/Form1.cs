using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject02
{
    public partial class Form1 : Form
    {
        public Form1()
        {//Project:Textboxa yalnız sayı ya da yalnız karakter girme
            InitializeComponent();
        }

        private void txt_yalnizkarakter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
            if (e.KeyChar == '1')
                txt_yalnizkarakter.Text += "bir";
            if(e.KeyChar=='a')
            {
                txt_yalnizkarakter.Text += "a ya bastınız";
            }
            //eğer giyrdiğim karakter seperator ve harf değilse sistem handled ediyor.eğer bu yazılmasaydı
        }
        private void txt_yalnizsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_CharacterCasingToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToUpper.CharacterCasing = CharacterCasing.Upper;
        }
        private void txt_CharacterCasingToLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToLower.CharacterCasing = CharacterCasing.Lower;
        }

        private void txt_yalnizkarakter_MouseEnter(object sender, EventArgs e)
        { 

            txt_yalnizkarakter.BackColor = Color.LightPink;
        }

        private void txt_yalnizkarakter_MouseLeave(object sender, EventArgs e)
        {
            txt_yalnizkarakter.BackColor = DefaultBackColor;
        }
    }
}

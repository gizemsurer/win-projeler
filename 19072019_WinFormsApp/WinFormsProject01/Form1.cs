using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject01
{
    public partial class FrmDonguler : Form
    {//Project:döngüler
        int[] Dizi = { 10, 20, 25, 28, 34 };
        int Toplam;

        public FrmDonguler()
        {
            InitializeComponent();
        }
        private void btnFor_Click(object sender, EventArgs e)
        {
            Temizle();
            listBoxFor.Items.Clear();

            for (int i = 0; i < Dizi.Length; i++)
            {
                Toplam = Toplam + Dizi[i];
                //Toplam += Dizi[i];
                listBoxFor.Items.Add(Dizi[i]);
            }
            listBoxFor.Items.Add("Toplam Değer = " + Toplam);
        }
        private void btnForeach_Click(object sender, EventArgs e)
        {
            Temizle();
            listBoxForeach.Items.Clear();

            foreach (int d in Dizi)
            {
                Toplam = Toplam + d;
                listBoxForeach.Items.Add(d);
            }
            listBoxForeach.Items.Add("Toplam Değer = " + Toplam);
        }
        public void Temizle()
        {
            Toplam = 0;
        }
        public void WhileDongu()
        {
            int i = 0;
            listBoxDowhile.Items.Clear();
            while (i < Dizi.Length)
            {
                listBoxWhile.Items.Add(Dizi[i]);
                Toplam += Dizi[i];
                i++;
            }
            listBoxWhile.Items.Add("toplam = " + Toplam);
        }
        private void btnWhile_Click(object sender, EventArgs e)
        {
            Temizle();
            WhileDongu();
        }
        public void DoWhileDongu()
        {
            int i = 0;
            listBoxDowhile.Items.Clear();
            do
            {
                listBoxDowhile.Items.Add(Dizi[i]);
                Toplam += Dizi[i];
                i++;               
            }           
            while (i < Dizi.Length);
            listBoxDowhile.Items.Add("toplam = " + Toplam);
        }
        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            Temizle();
            DoWhileDongu();
        }
        private void IEnumDongu()
        {
            listBoxIEnum.Items.Clear();
            IEnumerator IENum = Dizi.GetEnumerator();
            while(IENum.MoveNext())
            {
                listBoxIEnum.Items.Add(IENum.Current);
                Toplam += (int)IENum.Current;
            }
            listBoxIEnum.Items.Add("toplam = " + Toplam);
        }
        private void btnIEnum_Click(object sender, EventArgs e)
        {
            Temizle();
            IEnumDongu();
        }

        private void FrmDonguler_Load(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba, ilk form uygulamama hoş geldiniz !");
        }
    }
    
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonteynerKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            //*************************
            decimal cpuFiyat = 0;
            if (rbCpuI7.Checked)
                cpuFiyat = 300;
            else if (rbCpuI5.Checked)
                cpuFiyat = 200;
            else if (rbCpuI3.Checked)
                cpuFiyat = 100;
            else if (rbCpuR5.Checked)
                cpuFiyat = 250;
            else if (rbCpuR3.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;
            //*************************
            decimal ramFiyat = 0;
            if (rbRam16.Checked)
                ramFiyat = 125;
            else if (rbRam8.Checked)
                ramFiyat = 75;
            else if (rbRam4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            //*************************
            decimal SbtFiyat = 0;
            if (rbHdd1000.Checked)
                SbtFiyat += 170;
            if (rbHdd500.Checked)
                SbtFiyat += 95;
            if (rbHdd320.Checked)
                SbtFiyat += 60;
            tabanFiyat += SbtFiyat;
            //**********************
            decimal ekdonanimfiyat = 0;
            if (cbDvd.Checked)
                ekdonanimfiyat += 90;
            if (cbWebCam.Checked)
                ekdonanimfiyat += 120;
            if (cbWfi.Checked)
                ekdonanimfiyat += 160;
            tabanFiyat += ekdonanimfiyat;
            MessageBox.Show(string.Format("Toplam Fiyat ={0:C}", tabanFiyat));
        }
    }
}

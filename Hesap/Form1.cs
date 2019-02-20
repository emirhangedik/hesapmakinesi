using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0" || optDurum)
                txt_sonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txt_sonuc.Text += btn.Text;

            
        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lbl_sonuc.Text = lbl_sonuc.Text + " " + txt_sonuc.Text + " " + yeniOpt;
            switch(opt)
            {
                case "+":txt_sonuc.Text = (sonuc + double.Parse(txt_sonuc.Text)).ToString(); break;
                case "-": txt_sonuc.Text = (sonuc - double.Parse(txt_sonuc.Text)).ToString(); break;
                case "/": txt_sonuc.Text = (sonuc / double.Parse(txt_sonuc.Text)).ToString(); break;
                case "*": txt_sonuc.Text = (sonuc * double.Parse(txt_sonuc.Text)).ToString(); break;

            }

            sonuc = double.Parse(txt_sonuc.Text);
            txt_sonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txt_sonuc.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_sonuc.Text = "0";
            lbl_sonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txt_sonuc.Text = (sonuc + double.Parse(txt_sonuc.Text)).ToString(); break;
                case "-": txt_sonuc.Text = (sonuc - double.Parse(txt_sonuc.Text)).ToString(); break;
                case "/": txt_sonuc.Text = (sonuc / double.Parse(txt_sonuc.Text)).ToString(); break;
                case "*": txt_sonuc.Text = (sonuc * double.Parse(txt_sonuc.Text)).ToString(); break;

            }

            sonuc = double.Parse(txt_sonuc.Text);
            txt_sonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(txt_sonuc.Text=="0")
            {
                txt_sonuc.Text = "0";
            }
            else if(optDurum)
            {
                txt_sonuc.Text = "0";
            }

            if(!txt_sonuc.Text.Contains(","))
            {
                txt_sonuc.Text += ",";
            }

            optDurum = false;
        }
    }   
}

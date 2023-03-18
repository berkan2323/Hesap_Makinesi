using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text += "";
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void artibutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void carpibutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void bolumbutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}

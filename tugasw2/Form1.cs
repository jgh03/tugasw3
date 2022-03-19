using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasw2
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }
        public void buttonProcess_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.ToLower() == "shown")
            {
                labelEmpty.Show();
            }
            else if (textBoxInput.Text.ToLower() == "hide")
            {
                labelEmpty.Hide();
            }
            else
            {
                string isi = "isi:";
                string warna = "warna:";
                string besar = "besarkan";
                string kecil = "kecilkan";
                string merah = "merah";
                string biru  = "biru";
                string hijau = "hijau";
                string hitam = "default";
                string restart = "[ EMPTY ]";
                if (textBoxInput.Text.ToLower().Contains(isi))
                {
                    labelEmpty.Text = textBoxInput.Text.Remove(textBoxInput.Text.ToLower().IndexOf(isi), isi.Length);
                }
                else if (textBoxInput.Text.ToLower().Contains(warna))
                {
                    string pilihanWarna = textBoxInput.Text.Remove(textBoxInput.Text.ToLower().IndexOf(warna), warna.Length);
                    if (pilihanWarna.ToLower().Contains(merah))
                    {
                        labelEmpty.ForeColor = Color.Red;
                    }
                    if (pilihanWarna.ToLower().Contains(biru))
                    {
                        labelEmpty.ForeColor = Color.Blue;
                    }
                    if (pilihanWarna.ToLower().Contains(hijau))
                    {
                        labelEmpty.ForeColor = Color.Green;
                    }
                    if (pilihanWarna.ToLower().Contains(hitam))
                    {
                        labelEmpty.ForeColor = Color.Black;
                    }
                }
                else if (textBoxInput.Text.ToLower().Contains(besar))
                {
                    labelEmpty.Font = new Font("Microsoft Sans Serif", labelEmpty.Font.Size + 1);
                }
                else if (textBoxInput.Text.ToLower().Contains(kecil))
                {
                    labelEmpty.Font = new Font("Microsoft Sans Serif", labelEmpty.Font.Size - 1);
                }
                else if (textBoxInput.Text.ToLower() == "restart")
                {
                    labelEmpty.Text = restart;
                    labelEmpty.Font = new Font("Microsoft Sans Serif", 16);
                    labelEmpty.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Syntax Tidak Terdaftar!!!");
                }
            }
        }
    }
}

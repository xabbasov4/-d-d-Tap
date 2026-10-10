using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ƏdədTap
{
    public partial class Form1 : Form
    {
        private int num;
        private int cehdSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            cehdSayi = 0;
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 100);

            button1.Enabled = true;
            textBox1.Enabled = true;

            cehdSayi = 0;
            textBox1.Clear();
            listBox1.Items.Clear();
            errorProvider1.Clear();
            labelCehd.Text = "Cəhd sayı: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Axtarılan ədəd xanası boş ola bilməz!");
                return;
            }

            int daxilEdilenAdad;
            bool ededdirmi = int.TryParse(textBox1.Text, out daxilEdilenAdad);

            if (!ededdirmi)
            {
                errorProvider1.SetError(textBox1, "Xahiş olunur düzgün ədəd daxil edin!");
                return;
            }

            cehdSayi++;
            labelCehd.Text = "Cəhd sayı: " + cehdSayi;

            if (daxilEdilenAdad == num)
            {
                listBox1.Items.Add("Oyunu qazandınız");
                listBox1.Items.Add("Cəhd sayı: " + cehdSayi);

                MessageBox.Show($"Təbriklər! Oyunu qazandınız.\nCəhd sayı: {cehdSayi}", "Qələbə!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button1.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                listBox1.Items.Add("Daxil edilən ədəd yanlışdır");

                if (daxilEdilenAdad < num)
                {
                    listBox1.Items.Add("Təsadüfi ədəddən kiçikdir");
                }
                else
                {
                    listBox1.Items.Add("Təsadüfi ədəddən böyükdür");
                }
            }

            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
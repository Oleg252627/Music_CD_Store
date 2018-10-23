using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczam_ADO_Net
{
    public partial class Korzina : Form
    {
        private Form1 form = null;
        private List<Disc> Kor_disc = null;
        public Korzina(Form1 form1, List<Disc> disc)
        {
            InitializeComponent();
            form = form1;
            Kor_disc = disc;
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.listBox1_Korzina.SelectedIndexChanged += ListBox1_Korzina_SelectedIndexChanged;
            this.button1_Delete.Click += Button1_Delete_Click;
            this.button1_Zakaz.Click += Button1_Zakaz_Click;
            Show_Korzin();
        }

        private void Button1_Zakaz_Click(object sender, EventArgs e)
        {
            if (Kor_disc.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста для оформления заказа", "Оповещение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            User user=new User(Kor_disc);
            if (user.ShowDialog() == DialogResult.OK)
            {
                Kor_disc.Clear();
                form.SetList(Kor_disc);
                this.Close();
            }
        }

        private void Button1_Delete_Click(object sender, EventArgs e)
        {
            int index = this.listBox1_Korzina.SelectedIndex;
            Kor_disc.RemoveAt(index);
            Show_Korzin();

        }

        private void Show_Korzin()
        {
            this.button1_Delete.Visible = false;
            decimal sum = 0;
            this.listBox1_Korzina.Items.Clear();
            foreach (var VARIABLE in Kor_disc)
            {
                sum += VARIABLE.Price;
                listBox1_Korzina.Items.Add(
                    $"Название диска: {VARIABLE.DiskName} Исполнитель: {VARIABLE.ColectiveName} Цена: {VARIABLE.Price} грн.");
            }

            this.label3_Summ.Text = sum.ToString();
        }

        private void ListBox1_Korzina_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button1_Delete.Visible = true;
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            form.SetList(Kor_disc);
            this.Close();
        }
    }
}

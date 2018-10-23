using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczam_ADO_Net
{
    public partial class Edit_Disc : Form
    {
        int col = 0;
        DateTime date;
        decimal seb_pr = 0;
        decimal pr = 0;
        private Disc disc_disc;
        public Edit_Disc(Disc disc)
        {
            InitializeComponent();
            disc_disc = disc;
            this.textBox1_ColTrec.TextChanged += new EventHandler(textBox);
            this.textBox1_ColectivName.TextChanged += new EventHandler(textBox);
            this.textBox1_Gener.TextChanged += new EventHandler(textBox);
            this.textBox1_Izdatel.TextChanged += new EventHandler(textBox);
            this.textBox1_NameDisc.TextChanged += new EventHandler(textBox);
            this.textBox1_Prise.TextChanged += new EventHandler(textBox);
            this.textBox1_Seb_Prise.TextChanged += new EventHandler(textBox);
            this.textBox1_date.TextChanged += new EventHandler(textBox);
            this.button1_img.Click += Button1_img_Click;
            this.button1_Edit.Click += Button1_Edit_Click;
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            Show_Disc(disc);
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Edit_Click(object sender, EventArgs e)
        {
            if (textBox1_ColTrec.Text == "" || textBox1_ColectivName.Text == "" || textBox1_Gener.Text == "" ||
                textBox1_Izdatel.Text == "" || textBox1_NameDisc.Text == "" || textBox1_Prise.Text == "" ||
                textBox1_Seb_Prise.Text == "" || textBox1_date.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                col = Convert.ToInt32(this.textBox1_ColTrec.Text);
                date = Convert.ToDateTime(this.textBox1_date.Text);
                seb_pr = Convert.ToDecimal(this.textBox1_Seb_Prise.Text);
                pr = Convert.ToDecimal(this.textBox1_Prise.Text);
                Edit_database();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Некоторые поля введены не верно исправте!", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void Edit_database()
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Disc.FirstOrDefault(z => z.Id == disc_disc.Id);
                disc.ColectiveName = this.textBox1_ColectivName.Text;
                disc.ColTrec = col;
                disc.Cost_price = seb_pr;
                disc.DiskName = this.textBox1_NameDisc.Text;
                disc.Genre = this.textBox1_Gener.Text;
                disc.IzdatelName = this.textBox1_Izdatel.Text;
                disc.Pichuri = this.textBox1_img.Text;
                disc.Price = pr;
                disc.YearPublishing = date;
                db.Disc.AddOrUpdate(disc);
                db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Button1_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG file (*.png)|*.png|JPG file(*.jpg)|*.jpg|JPEG file(*.jpeg)|*.jpeg|All file(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_img.Text = $"..\\..\\imagesMusic\\{Path.GetFileName(openFile.FileName)}";
            }
        }
        private void Show_Disc(Disc disc)
        {
            this.textBox1_ColTrec.Text = disc.ColTrec.ToString();
            this.textBox1_ColectivName.Text = disc.ColectiveName;
            this.textBox1_Gener.Text = disc.Genre;
            this.textBox1_Izdatel.Text = disc.IzdatelName;
            this.textBox1_NameDisc.Text = disc.DiskName;
            this.textBox1_Prise.Text = disc.Price.ToString();
            this.textBox1_Seb_Prise.Text = disc.Cost_price.ToString();
            this.textBox1_date.Text = disc.YearPublishing.ToString("d");
            this.textBox1_img.Text = disc.Pichuri;
        }
        private void textBox(object sender, EventArgs a)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Name == this.textBox1_ColTrec.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_ColTrec.Text))
                {

                }
                else
                {
                    this.textBox1_ColTrec.Text = null;
                }
            }
            else if (textBox.Name == textBox1_ColectivName.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_ColectivName.Text))
                {

                }
                else
                {
                    this.textBox1_ColectivName.Text = null;
                }
            }
            else if (textBox.Name == textBox1_Gener.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_Gener.Text))
                {

                }
                else
                {
                    this.textBox1_Gener.Text = null;
                }
            }
            else if (textBox.Name == textBox1_Izdatel.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_Izdatel.Text))
                {

                }
                else
                {
                    this.textBox1_Izdatel.Text = null;
                }
            }
            else if (textBox.Name == textBox1_NameDisc.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_NameDisc.Text))
                {

                }
                else
                {
                    this.textBox1_NameDisc.Text = null;
                }
            }
            else if (textBox.Name == textBox1_Prise.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_Prise.Text))
                {

                }
                else
                {
                    this.textBox1_Prise.Text = null;
                }
            }
            else if (textBox.Name == textBox1_Seb_Prise.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_Seb_Prise.Text))
                {

                }
                else
                {
                    this.textBox1_Seb_Prise.Text = null;
                }
            }
            else if (textBox.Name == textBox1_date.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_date.Text))
                {

                }
                else
                {
                    this.textBox1_date.Text = null;
                }
            }
        }
    }
}

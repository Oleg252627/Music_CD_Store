using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczam_ADO_Net
{
    public partial class Add_Disc : Form
    {
        int col = 0;
        DateTime date;
        decimal seb_pr = 0;
        decimal pr = 0;
        public Add_Disc()
        {
            InitializeComponent();
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.textBox1_ColTrec.TextChanged+=new EventHandler(textBox);
            this.textBox1_ColectivName.TextChanged += new EventHandler(textBox);
            this.textBox1_Gener.TextChanged += new EventHandler(textBox);
            this.textBox1_Izdatel.TextChanged += new EventHandler(textBox);
            this.textBox1_NameDisc.TextChanged += new EventHandler(textBox);
            this.textBox1_Prise.TextChanged += new EventHandler(textBox);
            this.textBox1_Seb_Prise.TextChanged += new EventHandler(textBox);
            this.textBox1_date.TextChanged += new EventHandler(textBox);
            this.button1_img.Click += Button1_img_Click;
            this.button1_Add.Click += Button1_Add_Click;
        }

        private void Button1_Add_Click(object sender, EventArgs e)
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
                pr= Convert.ToDecimal(this.textBox1_Prise.Text);
                Add_database();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Некоторые поля введены не верно исправте!", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void Add_database()
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                Disc disc = new Disc
                {
                    ColectiveName = this.textBox1_ColectivName.Text,
                    ColTrec = col,
                    Cost_price = seb_pr,
                    DiskName = this.textBox1_NameDisc.Text,
                    Genre = this.textBox1_Gener.Text,
                    IzdatelName = this.textBox1_Izdatel.Text,
                    Pichuri = this.textBox1_img.Text,
                    Price = pr,
                    YearPublishing = date
                };
                db.Disc.Add(disc);
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

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox(object sender, EventArgs a)
        {
            TextBox textBox=sender as TextBox;
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

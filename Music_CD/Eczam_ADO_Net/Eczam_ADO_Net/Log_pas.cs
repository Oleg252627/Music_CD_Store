using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczam_ADO_Net
{
    public partial class Log_pas : Form
    {
        public Log_pas()
        {
            InitializeComponent();
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.textBox1_Login.TextChanged += new EventHandler(TextChanged_Login_Password);
            this.textBox1_Password.TextChanged += new EventHandler(TextChanged_Login_Password);
            this.button1_Edit.Click += Button1_Edit_Click;
            Show_Log();
        }

        private void Show_Log()
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var log = db.LoginPassword.FirstOrDefault(z => z.Id == 1);
                this.textBox1_Login.Text = log.Login;
                this.textBox1_Password.Text = log.Password;
            }
        }

        private void Button1_Edit_Click(object sender, EventArgs e)
        {
            if (this.textBox1_Login.Text == "" || this.textBox1_Password.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MusicEntities2 db = new MusicEntities2())
            {
                var log = db.LoginPassword.FirstOrDefault(z => z.Id == 1);
                log.Login = this.textBox1_Login.Text;
                log.Password = this.textBox1_Password.Text;
                db.LoginPassword.AddOrUpdate(log);
                db.SaveChanges();
            }

            MessageBox.Show("Данные администратора изменены!", "Оповещение", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;

        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TextChanged_Login_Password(object sender, EventArgs a)
        {
            TextBox text = sender as TextBox;
            if (text.Name == textBox1_Login.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_Login.Text))
                {

                }
                else
                {
                    this.textBox1_Login.Text = null;
                }
            }
            else if (text.Name == textBox1_Password.Name)
            {
                if (!String.IsNullOrWhiteSpace(this.textBox1_Password.Text))
                {

                }
                else
                {
                    this.textBox1_Password.Text = null;
                }
            }
        }
    }
}

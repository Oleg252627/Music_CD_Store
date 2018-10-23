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
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.textBox1_Login.TextChanged+= new EventHandler(TextChanged_Login_Password);
            this.textBox1_Password.TextChanged+= new EventHandler(TextChanged_Login_Password);
            this.button1_Vhod.Click += Button1_Vhod_Click;
            this.bunifuImageButton1_Music.Click += BunifuImageButton1_Music_Click;
            this.bunifuImageButton2_User.Click += BunifuImageButton2_User_Click;
            this.bunifuImageButton3_Check.Click += BunifuImageButton3_Check_Click;
            this.button1_Edit_Log_Pass.Click += Button1_Edit_Log_Pass_Click;
        }

        private void Button1_Edit_Log_Pass_Click(object sender, EventArgs e)
        {
            Log_pas logPas=new Log_pas();
            logPas.ShowDialog();
        }

        private void BunifuImageButton3_Check_Click(object sender, EventArgs e)
        {
            Check check=new Check();
            check.ShowDialog();
        }

        private void BunifuImageButton2_User_Click(object sender, EventArgs e)
        {
            Pokupatel pokupatel=new Pokupatel();
            pokupatel.ShowDialog();
        }

        private void BunifuImageButton1_Music_Click(object sender, EventArgs e)
        {
            Produkt_Edit produkt=new Produkt_Edit();
            produkt.ShowDialog();
        }

        private void Button1_Vhod_Click(object sender, EventArgs e)
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var Log_Pas = db.LoginPassword.Where(z =>
                    z.Login == this.textBox1_Login.Text && z.Password == this.textBox1_Password.Text).ToList();
                if (Log_Pas.Count == 0)
                {
                    this.textBox1_Login.Text = null;
                    this.textBox1_Password.Text = null;
                    this.label4_Error.Visible = true; 
                }
                else
                {
                    this.panel2_Zashita.Visible = false;
                }
            }
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextChanged_Login_Password(object sender, EventArgs a)
        {
            TextBox text = sender as TextBox;
            this.label4_Error.Visible = false;
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

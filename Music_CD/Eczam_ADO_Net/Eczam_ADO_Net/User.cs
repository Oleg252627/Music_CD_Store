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
    public partial class User : Form
    {
        private string lastName;
        private string ferstName;
        private List<Disc> list = null;
        public User(List<Disc>discs)
        {
            InitializeComponent();
            list = discs;
            this.bunifuImageButton1.Click += BunifuImageButton1_Click;
            this.textBox1_LastName.TextChanged += TextBox1_LastName_TextChanged;
            this.textBox2_FerstName.TextChanged += TextBox2_FerstName_TextChanged;
            this.button1_Zacaz.Click += Button1_Zacaz_Click;
        }

        private void Button1_Zacaz_Click(object sender, EventArgs e)
        {
            if (this.textBox1_LastName.Text == "" || this.textBox2_FerstName.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Finish F=new Finish(list,lastName,ferstName);
            if (F.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TextBox2_FerstName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox2_FerstName.Text))
            {
                ferstName = this.textBox2_FerstName.Text;
            }
            else
            {
                this.textBox2_FerstName.Text = null;
            }
        }

        private void TextBox1_LastName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_LastName.Text))
            {
                lastName = this.textBox1_LastName.Text;
            }
            else
            {
                this.textBox1_LastName.Text = null;
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

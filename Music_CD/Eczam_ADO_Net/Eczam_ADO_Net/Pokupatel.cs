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
    public partial class Pokupatel : Form
    {
        public Pokupatel()
        {
            InitializeComponent();
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.button1_Ok.Click += Button1_Ok_Click;
            Show_Table();
        }

        private void Show_Table()
        {
            this.listView1_Pocupatel.Items.Clear();
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Buyer.Select(z => z).ToList();
                string[] row = new string[4];
                foreach (var VARIABLE in disc)
                {
                    row[0] = VARIABLE.Id.ToString();
                    row[1] =  VARIABLE.FersName;
                    row[2] = VARIABLE.LastName;
                    row[3] = VARIABLE.Col.ToString();
                    ListViewItem itm = new ListViewItem(row);
                    this.listView1_Pocupatel.Items.Add(itm);
                }
            }
        }

        private void Button1_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

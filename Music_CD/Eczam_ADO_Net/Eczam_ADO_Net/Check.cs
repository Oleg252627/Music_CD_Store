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
    public partial class Check : Form
    {
        private DateTime data=DateTime.Now;
        public Check()
        {
            InitializeComponent();
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.button1_Home.Click += Button1_Home_Click;
            this.button1_Dey.Click += Button1_Dey_Click;
            this.button1_Mounts.Click += Button1_Mounts_Click;
            this.button1_Eary.Click += Button1_Eary_Click;
            Show_Home();
        }

        private void Button1_Eary_Click(object sender, EventArgs e)
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Checkk.Where(z => z.DataSale.Year == data.Year).ToList();
                Show(disc);
            }
        }

        private void Button1_Mounts_Click(object sender, EventArgs e)
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Checkk.Where(z => z.DataSale.Month == data.Month).ToList();
                Show(disc);
            }
        }

        private void Button1_Dey_Click(object sender, EventArgs e)
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Checkk.Where(z => z.DataSale.Day == data.Day).ToList();
                Show(disc);
            }
        }

        private void Button1_Home_Click(object sender, EventArgs e)
        {
            Show_Home();
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Home()
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                var discs = db.Checkk.Select(z => z).ToList();
                Show(discs);
            }
        }

        private void Show(List<Checkk>discs)
        {
            this.listView1_Check.Items.Clear();
            string[] row = new string[7];
            foreach (var VARIABLE in discs)
            {
                row[0] = VARIABLE.Id.ToString();
                row[1] = VARIABLE.DataSale.ToString("d");
                row[2] = VARIABLE.Disc.DiskName;
                row[3] = VARIABLE.Disc.ColectiveName;
                row[4] =   VARIABLE.Buyer.FersName;
                row[5] = VARIABLE.Buyer.LastName;
                row[6] = VARIABLE.Summa.ToString();
                ListViewItem itm = new ListViewItem(row);
                this.listView1_Check.Items.Add(itm);
            }
        }
    }
}

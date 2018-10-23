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
    public partial class Produkt_Edit : Form
    {
        private List<Disc> list=new List<Disc>();
        public Produkt_Edit()
        {
            InitializeComponent();
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.button1_Add.Click += Button1_Add_Click;
            this.button1_Delete.Click += Button1_Delete_Click;
            this.button1_Edit.Click += Button1_Edit_Click;
            this.listView1_Disc.SelectedIndexChanged += ListView1_Disc_SelectedIndexChanged;
            Show_Table();
        }

        private void Button1_Edit_Click(object sender, EventArgs e)
        {
            Disc disc = list[this.listView1_Disc.FocusedItem.Index];
            Edit_Disc edit=new Edit_Disc(disc);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                Show_Table();
            }
        }

        private void ListView1_Disc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button1_Delete.Visible = true;
            this.button1_Edit.Visible = true;
        }

        private void Button1_Delete_Click(object sender, EventArgs e)
        {
            int index = this.listView1_Disc.FocusedItem.Index;
            Disc disc = list[index];
            using (MusicEntities2 db = new MusicEntities2())
            {
                var find = db.Disc.FirstOrDefault(z=>z.Id==disc.Id);
                db.Disc.Remove(find);
                db.SaveChanges();
            }
            Show_Table();
        }

        private void Button1_Add_Click(object sender, EventArgs e)
        {
            Add_Disc disc=new Add_Disc();
            if (disc.ShowDialog() == DialogResult.OK)
            {
                Show_Table();
            }
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Table()
        {
            this.button1_Edit.Visible = false;
            this.button1_Delete.Visible = false;
            this.listView1_Disc.Items.Clear();
            using (MusicEntities2 db=new MusicEntities2())
            {
                var disc = db.Disc.Select(z => z).ToList();
                list = disc;
                string[] row = new string[10];
                foreach (var VARIABLE in list)
                {
                    row[0] = VARIABLE.Id.ToString();
                    row[1] = VARIABLE.Pichuri;
                    row[2] = VARIABLE.DiskName;
                    row[3] = VARIABLE.ColectiveName;
                    row[4] = VARIABLE.IzdatelName;
                    row[5] = VARIABLE.ColTrec.ToString();
                    row[6] = VARIABLE.Genre;
                    row[7] = VARIABLE.YearPublishing.ToString("d");
                    row[8] = VARIABLE.Cost_price.ToString();
                    row[9] = VARIABLE.Price.ToString();
                    ListViewItem itm=new ListViewItem(row);
                    this.listView1_Disc.Items.Add(itm);
                }
            }
        }
    }
}

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
    public partial class Finish : Form
    {
        public Finish(List<Disc> discs, string lastName,string ferstName)
        {
            InitializeComponent();
            button1_Ok.Click += Button1_Ok_Click;
            Oformlenie(discs, lastName,ferstName);
        }

        private void Button1_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Oformlenie(List<Disc> discs, string lastName, string ferstName)
        {
            using (MusicEntities2 db=new MusicEntities2())
            {
                var user = db.Buyer.Where(z => z.LastName == lastName && z.FersName == ferstName).ToList();
                if (user.Count != 0)
                {
                    foreach (Buyer VARIABLE in user)
                    {
                        int col = VARIABLE.Col;
                        col += discs.Count;
                        VARIABLE.Col = col;
                        db.Buyer.AddOrUpdate(VARIABLE);
                        db.SaveChanges();
                    }
                }
                else
                {
                    Buyer buyer = new Buyer {Col = discs.Count, LastName = lastName, FersName = ferstName};
                    db.Buyer.Add(buyer);
                    db.SaveChanges();
                }
            }

            using (MusicEntities2 db=new MusicEntities2())
            {
                var user = db.Buyer.Where(z => z.LastName == lastName && z.FersName == ferstName).ToList();
                foreach (var VARIABLE in user)
                {
                    var sumPrise = db.Checkk.Where(z => z.IdBuyer == VARIABLE.Id).Select(z => z.Summa).ToList();
                    decimal sum = 0;
                    foreach (decimal VAR in sumPrise)
                    {
                        sum += VAR;
                    }

                    if (sum > 2000)
                    {
                        decimal s = 0;
                        decimal nous = 0;
                        this.panel1_Scidka.Visible = true;
                        foreach (var V in discs)
                        {
                            decimal pr = 0;
                            s += V.Price;
                            pr= (V.Price - 15);
                            nous = nous + (V.Price - 15);
                            Checkk checkk = new Checkk
                            {
                                DataSale = DateTime.Now.Date,
                                IdDisc = V.Id,
                                IdBuyer = VARIABLE.Id,
                                Summa = pr
                            };
                            db.Checkk.Add(checkk);
                        }

                        db.SaveChanges();
                        this.label3_summ.Text = s.ToString();
                        this.label4_Scidka.Text = nous.ToString();
                    }
                    else
                    {
                        decimal s = 0;
                        this.panel1_NoScidca.Visible = true;
                        foreach (var V in discs)
                        {
                            s += V.Price;
                            Checkk checkk = new Checkk
                            {
                                DataSale = DateTime.Now.Date,
                                IdDisc = V.Id,
                                IdBuyer = VARIABLE.Id,
                                Summa = V.Price
                            };
                            db.Checkk.Add(checkk);
                        }
                        db.SaveChanges();
                        this.label6_NoScidka.Text = s.ToString();
                    }
                }
            }
        }
    }
}

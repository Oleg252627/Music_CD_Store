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
    public partial class Form1 : Form
    {
        private int panal_col = 4;
        private int pages = 1;
        private int van = 1;
        private int two = 2;
        private int pagesSerch = 1;
        private int vanSefch = 1;
        private int twoSerch = 2;
        private int SerchCount = 0;
        private string start=null;
        private List<Disc> korzina=new List<Disc>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.button1_left.Click+=new EventHandler(Button_List);
            this.button1_Van.Click+= new EventHandler(Button_List);
            this.button1_Two.Click+= new EventHandler(Button_List);
            this.button1_Right.Click+= new EventHandler(Button_List);
            this.button6_Serch_Left.Click += new EventHandler(Button_List);
            this.button8_Serch_wan.Click+= new EventHandler(Button_List);
            this.button9_Serch_twu.Click+= new EventHandler(Button_List);
            this.button7_Serch_Right.Click+= new EventHandler(Button_List);
            this.button1_Add1.Click+= new EventHandler(List_Korzina);
            this.button1_Add2.Click += new EventHandler(List_Korzina);
            this.button1_Add3.Click += new EventHandler(List_Korzina);
            this.button1_Add4.Click += new EventHandler(List_Korzina);
            this.bunifuImageButton1_Korzina.Click += BunifuImageButton1_Korzina_Click;
            this.bunifuImageButton1_Serch.Click += BunifuImageButton1_Serch_Click;
            this.bunifuImageButton1_Serch_Close.Click += BunifuImageButton1_Serch_Close_Click;
            this.textBox1_Serch.TextChanged += TextBox1_Serch_TextChanged;
            this.button1_Serch_NameDisc.Click += Button1_Serch_NameDisc_Click;
            this.button1_Serch_Ispolnitel.Click += Button1_Serch_Ispolnitel_Click;
            this.button1_Serch_Ganr.Click += Button1_Serch_Ganr_Click;
            this.button1_Home.Click += Button1_Home_Click;
            this.bunifuImageButton1_Options.Click += BunifuImageButton1_Options_Click;
            Show_Tovar();
        }

        private void BunifuImageButton1_Options_Click(object sender, EventArgs e)
        {
            AdminPassword admin=new AdminPassword();
            admin.ShowDialog();
        }

        private void Button1_Home_Click(object sender, EventArgs e)
        {
            this.panel6_Serch_List.Visible = false;
            pages = 1;
            van = 1;
            two = 2;
            Show_Tovar();
        }

        private void Button1_Serch_Ganr_Click(object sender, EventArgs e)
        {
            if (this.textBox1_Serch.Text == "")
            {
                MessageBox.Show("Заполните поле для поиска", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.panel5_Serch.Visible = false;
            pagesSerch = 1;
            vanSefch = 1;
            twoSerch = 2;
            SerchCount = 3;
            Serch_Ganr();
        }

        private void Button1_Serch_Ispolnitel_Click(object sender, EventArgs e)
        {
            if (this.textBox1_Serch.Text == "")
            {
                MessageBox.Show("Заполните поле для поиска", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.panel5_Serch.Visible = false;
            pagesSerch = 1;
            vanSefch = 1;
            twoSerch = 2;
            SerchCount = 2;
            Serch_Ispolnitel();
        }

        private void Button1_Serch_NameDisc_Click(object sender, EventArgs e)
        {

            if (this.textBox1_Serch.Text == "")
            {
                MessageBox.Show("Заполните поле для поиска", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.panel5_Serch.Visible = false;
            pagesSerch = 1;
            vanSefch = 1;
            twoSerch = 2;
            SerchCount = 1;
            Serch_DiscName();
            
        }

        private void TextBox1_Serch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_Serch.Text))
            {
                 
            }
            else
            {
                this.textBox1_Serch.Text = null;
            }
        }

        private void BunifuImageButton1_Serch_Close_Click(object sender, EventArgs e)
        {
            this.bunifuTransition1_Open_Serch.HideSync(this.panel5_Serch);
        }

        private void BunifuImageButton1_Serch_Click(object sender, EventArgs e)
        {
            this.bunifuTransition1_Open_Serch.ShowSync(this.panel5_Serch);
        }

        private void BunifuImageButton1_Korzina_Click(object sender, EventArgs e)
        {
            Korzina Kor=new Korzina(this,korzina);
            if (Kor.ShowDialog() == DialogResult.OK)
            {
                Show_Tovar();
            }
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void List_Korzina(object sender, EventArgs e)
        {
            using (MusicEntities2 db = new MusicEntities2())
            {
                Button button = sender as Button;
                if (button.Name == this.button1_Add1.Name)
                {
                    int id = Convert.ToInt32(this.label13_Id1.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        korzina.Add(disc);
                    }
                }
                else if (button.Name == this.button1_Add2.Name)
                {
                    int id = Convert.ToInt32(this.label13_Id2.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        korzina.Add(disc);
                    }
                }
                else if (button.Name == this.button1_Add3.Name)
                {
                    int id = Convert.ToInt32(this.label13_Id3.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        korzina.Add(disc);
                    }
                }
                else if (button.Name == this.button1_Add4.Name)
                {
                    int id = Convert.ToInt32(this.label13_Id4.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        korzina.Add(disc);
                    }
                }
            }

            this.label2_col.Text = korzina.Count.ToString();
        }

        public void SetList( List<Disc> disc)
        {
            korzina = disc;
            this.label2_col.Text = korzina.Count.ToString();
        }
        private void Button_List(object sender, EventArgs e)
        {
            
            Button button=sender as Button;
            if (button.Name == this.button1_left.Name)
            {
                two = van;
                van--;
                pages = van;
                this.button1_Van.Text = van.ToString();
                this.button1_Two.Text = two.ToString();
                Show_Tovar();
            }
            else if (button.Name == this.button1_Van.Name)
            {
                pages = van;
                this.button1_Van.Text = van.ToString();
                this.button1_Two.Text = two.ToString();
                Show_Tovar();
            }
            else if (button.Name == this.button1_Two.Name)
            {
                van = two;
                pages = van;
                this.button1_Van.Text = van.ToString();
                two++;
                this.button1_Two.Text = two.ToString();
                this.button1_left.Visible = true;
                Show_Tovar();
            }
            else if (button.Name == this.button1_Right.Name)
            {
                van = two;
                pages = van;
                this.button1_Van.Text = van.ToString();
                two++;
                this.button1_Two.Text = two.ToString();
                this.button1_left.Visible = true;
                Show_Tovar();
            }
            else if (button.Name == this.button6_Serch_Left.Name)
            {
                twoSerch = vanSefch;
                vanSefch--;
                pagesSerch = vanSefch;
                this.button8_Serch_wan.Text = vanSefch.ToString();
                this.button9_Serch_twu.Text = twoSerch.ToString();
                if (SerchCount == 1)
                {
                    Serch_DiscName();
                }
                else if (SerchCount == 2)
                {
                    Serch_Ispolnitel();
                }
                else if (SerchCount == 3)
                {
                    Serch_Ganr();
                }
            }
            else if (button.Name == this.button8_Serch_wan.Name)
            {
                pagesSerch = vanSefch;
                this.button8_Serch_wan.Text = vanSefch.ToString();
                this.button9_Serch_twu.Text = twoSerch.ToString();
                if (SerchCount == 1)
                {
                    Serch_DiscName();
                }
                else if (SerchCount == 2)
                {
                    Serch_Ispolnitel();
                }
                else if (SerchCount == 3)
                {
                    Serch_Ganr();
                }
            }
            else if (button.Name == this.button9_Serch_twu.Name)
            {
                vanSefch = twoSerch;
                pagesSerch = vanSefch;
                this.button1_Van.Text = van.ToString();
                twoSerch++;
                this.button9_Serch_twu.Text = two.ToString();
                this.button6_Serch_Left.Visible = true;
                if (SerchCount == 1)
                {
                    Serch_DiscName();
                }
                else if (SerchCount == 2)
                {
                    Serch_Ispolnitel();
                }
                else if (SerchCount == 3)
                {
                    Serch_Ganr();
                }
            }
            else if (button.Name == this.button7_Serch_Right.Name)
            {
                vanSefch = twoSerch;
                pagesSerch = vanSefch;
                this.button1_Van.Text = van.ToString();
                twoSerch++;
                this.button9_Serch_twu.Text = two.ToString();
                this.button6_Serch_Left.Visible = true;
                if (SerchCount == 1)
                {
                    Serch_DiscName();
                }
                else if (SerchCount == 2)
                {
                    Serch_Ispolnitel();
                }
                else if (SerchCount == 3)
                {
                    Serch_Ganr();
                }
            }


            if (van == 1)
            {
                this.button1_left.Visible = false;
            }

            if (vanSefch == 1)
            {
                this.button6_Serch_Left.Visible = false;
            }

            
        }

        private void Serch_Ganr()
        {
            if (this.textBox1_Serch.Text != "")
            {
                start = this.textBox1_Serch.Text;
                this.textBox1_Serch.Text = "";
            }
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Disc.Where(z => z.Genre.StartsWith(start)).OrderBy(z => z.Id).Skip((pagesSerch - 1) * panal_col).Take(panal_col).ToList();
                Show_Serch(disc);
            }
        }

        private void Serch_Ispolnitel()
        {
            if (this.textBox1_Serch.Text != "")
            {
                start = this.textBox1_Serch.Text;
                this.textBox1_Serch.Text = "";
            }
            using (MusicEntities2 db = new MusicEntities2())
            {
                var disc = db.Disc.Where(z => z.ColectiveName.StartsWith(start)).OrderBy(z => z.Id).Skip((pagesSerch - 1) * panal_col).Take(panal_col).ToList();
                Show_Serch(disc);
            }
        }

        private void Serch_DiscName()
        {
            if (this.textBox1_Serch.Text != "")
            {
                start = this.textBox1_Serch.Text;
                this.textBox1_Serch.Text = "";
            }
            using (MusicEntities2 db=new MusicEntities2())
            {
                var disc=db.Disc.Where(z=>z.DiskName.StartsWith(start)).OrderBy(z=>z.Id).Skip((pagesSerch - 1) * panal_col).Take(panal_col).ToList();
                Show_Serch(disc);
            }
        }

        private void Show_Serch(List<Disc> disc)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5_Hit1.Visible = false;
            panel5_Hit2.Visible = false;
            panel6_Hit3.Visible = false;
            panel7_Hit4.Visible = false;
            panel6_Serch_List.Visible = true;
            int col_poz = 0;
            if (disc.Count < 4)
            {
                this.button9_Serch_twu.Visible = false;
                this.button7_Serch_Right.Visible = false;
            }
            else
            {
                this.button9_Serch_twu.Visible = true;
                this.button7_Serch_Right.Visible = true;
            }

            using (MusicEntities2 db = new MusicEntities2())
            {
                foreach (var disc1 in disc)
                {
                    if (col_poz == 0)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel5_Hit1.Visible = true;
                        }
                        panel1.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox2_1.Image = bitmap;
                        }
                        catch (Exception e)
                        {
                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox2_1.Image = bitmap;
                        }
                        this.pictureBox2_1.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author1.Text = disc1.ColectiveName;
                        this.label12_DiscName1.Text = disc1.DiskName;
                        this.label12_Izdatel1.Text = disc1.IzdatelName;
                        this.label12_Col_Trec1.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr1.Text = disc1.Genre;
                        this.label12_God1.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise1.Text = disc1.Price.ToString();
                        this.label13_Id1.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 1)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel5_Hit2.Visible = true;
                        }
                        panel2.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox3_2.Image = bitmap;
                        }
                        catch (Exception e)
                        {
                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox3_2.Image = bitmap;
                        }
                        this.pictureBox3_2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author2.Text = disc1.ColectiveName;
                        this.label12_DiscName2.Text = disc1.DiskName;
                        this.label12_Izdatel2.Text = disc1.IzdatelName;
                        this.label12_Col_Trec2.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr2.Text = disc1.Genre;
                        this.label12_God2.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise2.Text = disc1.Price.ToString();
                        this.label13_Id2.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 2)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel6_Hit3.Visible = true;
                        }
                        panel3.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox4_3.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox4_3.Image = bitmap;
                        }
                        this.pictureBox4_3.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author3.Text = disc1.ColectiveName;
                        this.label12_DiscName3.Text = disc1.DiskName;
                        this.label12_Izdatel3.Text = disc1.IzdatelName;
                        this.label12_Col_Trec3.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr3.Text = disc1.Genre;
                        this.label12_God3.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise3.Text = disc1.Price.ToString();
                        this.label13_Id3.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 3)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel7_Hit4.Visible = true;
                        }
                        panel4.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox5_4.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox5_4.Image = bitmap;
                        }
                        this.pictureBox5_4.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author4.Text = disc1.ColectiveName;
                        this.label12_DiscName4.Text = disc1.DiskName;
                        this.label12_Izdatel4.Text = disc1.IzdatelName;
                        this.label12_Col_Trec4.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr4.Text = disc1.Genre;
                        this.label12_God4.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise4.Text = disc1.Price.ToString();
                        this.label13_Id4.Text = disc1.Id.ToString();
                    }

                    col_poz++;
                }
            }
        }
        private void Show_Tovar()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5_Hit1.Visible = false;
            panel5_Hit2.Visible = false;
            panel6_Hit3.Visible = false;
            panel7_Hit4.Visible = false;
            using (MusicEntities2 db=new MusicEntities2())
            {
                int col_poz = 0;
                var disc = db.Disc.OrderBy(z => z.Id).Skip((pages - 1) * panal_col).Take(panal_col).ToList();
                if (disc.Count < 4)
                {
                    this.button1_Two.Visible = false;
                    this.button1_Right.Visible = false;
                }
                else
                {
                    this.button1_Two.Visible = true;
                    this.button1_Right.Visible = true;
                }
                foreach (var disc1 in disc)
                {
                    if (col_poz == 0)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel5_Hit1.Visible = true;
                        }
                        panel1.Visible = true;
                        try
                        {
                            Bitmap bitmap=new Bitmap(disc1.Pichuri);
                            this.pictureBox2_1.Image = bitmap;
                        }
                        catch (Exception e)
                        {
                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox2_1.Image = bitmap;

                        }
                        this.pictureBox2_1.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author1.Text = disc1.ColectiveName;
                        this.label12_DiscName1.Text = disc1.DiskName;
                        this.label12_Izdatel1.Text = disc1.IzdatelName;
                        this.label12_Col_Trec1.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr1.Text = disc1.Genre;
                        this.label12_God1.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise1.Text = disc1.Price.ToString();
                        this.label13_Id1.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 1)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel5_Hit2.Visible = true;
                        }
                        panel2.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox3_2.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox3_2.Image = bitmap;
                        }
                        this.pictureBox3_2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author2.Text = disc1.ColectiveName;
                        this.label12_DiscName2.Text = disc1.DiskName;
                        this.label12_Izdatel2.Text = disc1.IzdatelName;
                        this.label12_Col_Trec2.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr2.Text = disc1.Genre;
                        this.label12_God2.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise2.Text = disc1.Price.ToString();
                        this.label13_Id2.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 2)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel6_Hit3.Visible = true;
                        }
                        panel3.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox4_3.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox4_3.Image = bitmap;
                        }
                        this.pictureBox4_3.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author3.Text = disc1.ColectiveName;
                        this.label12_DiscName3.Text = disc1.DiskName;
                        this.label12_Izdatel3.Text = disc1.IzdatelName;
                        this.label12_Col_Trec3.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr3.Text = disc1.Genre;
                        this.label12_God3.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise3.Text = disc1.Price.ToString();
                        this.label13_Id3.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 3)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            panel7_Hit4.Visible = true;
                        }
                        panel4.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Pichuri);
                            this.pictureBox5_4.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\imagesMusic\ErrorImg.png");
                            this.pictureBox5_4.Image = bitmap;
                        }
                        this.pictureBox5_4.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.label12_Author4.Text = disc1.ColectiveName;
                        this.label12_DiscName4.Text = disc1.DiskName;
                        this.label12_Izdatel4.Text = disc1.IzdatelName;
                        this.label12_Col_Trec4.Text = disc1.ColTrec.ToString();
                        this.label12_Ganr4.Text = disc1.Genre;
                        this.label12_God4.Text = disc1.YearPublishing.ToString("d");
                        this.label13_Prise4.Text = disc1.Price.ToString();
                        this.label13_Id4.Text = disc1.Id.ToString();
                    }

                    col_poz++;
                }
            }
        }
    }
}

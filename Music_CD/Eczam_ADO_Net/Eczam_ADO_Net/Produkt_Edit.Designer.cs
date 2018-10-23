namespace Eczam_ADO_Net
{
    partial class Produkt_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1_Disc = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Izdat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltrec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_Add = new System.Windows.Forms.Button();
            this.button1_Delete = new System.Windows.Forms.Button();
            this.button1_Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_Top
            // 
            this.panel1_Top.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1_Top.Controls.Add(this.label1);
            this.panel1_Top.Controls.Add(this.bunifuImageButton1_Close);
            this.panel1_Top.Controls.Add(this.pictureBox1);
            this.panel1_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_Top.Location = new System.Drawing.Point(0, 0);
            this.panel1_Top.Name = "panel1_Top";
            this.panel1_Top.Size = new System.Drawing.Size(1024, 41);
            this.panel1_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produkt";
            // 
            // bunifuImageButton1_Close
            // 
            this.bunifuImageButton1_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_Close.Image = global::Eczam_ADO_Net.Properties.Resources.Close_Korzina;
            this.bunifuImageButton1_Close.ImageActive = null;
            this.bunifuImageButton1_Close.Location = new System.Drawing.Point(988, 9);
            this.bunifuImageButton1_Close.Name = "bunifuImageButton1_Close";
            this.bunifuImageButton1_Close.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Close.TabIndex = 1;
            this.bunifuImageButton1_Close.TabStop = false;
            this.bunifuImageButton1_Close.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eczam_ADO_Net.Properties.Resources.Music2;
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 10);
            this.panel1.TabIndex = 1;
            // 
            // listView1_Disc
            // 
            this.listView1_Disc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Pic,
            this.disc,
            this.colect,
            this.Izdat,
            this.coltrec,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1_Disc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1_Disc.FullRowSelect = true;
            this.listView1_Disc.GridLines = true;
            this.listView1_Disc.Location = new System.Drawing.Point(12, 65);
            this.listView1_Disc.MultiSelect = false;
            this.listView1_Disc.Name = "listView1_Disc";
            this.listView1_Disc.Size = new System.Drawing.Size(1000, 318);
            this.listView1_Disc.TabIndex = 2;
            this.listView1_Disc.UseCompatibleStateImageBehavior = false;
            this.listView1_Disc.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 31;
            // 
            // Pic
            // 
            this.Pic.Text = "Pichuri ";
            this.Pic.Width = 130;
            // 
            // disc
            // 
            this.disc.Text = "DiskName ";
            this.disc.Width = 129;
            // 
            // colect
            // 
            this.colect.Text = "ColectiveName ";
            this.colect.Width = 144;
            // 
            // Izdat
            // 
            this.Izdat.Text = "IzdatelName ";
            this.Izdat.Width = 103;
            // 
            // coltrec
            // 
            this.coltrec.Text = "ColTrec ";
            this.coltrec.Width = 55;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Genre ";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YearPublishing ";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost_price ";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price ";
            this.columnHeader4.Width = 89;
            // 
            // button1_Add
            // 
            this.button1_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.button1_Add.FlatAppearance.BorderSize = 0;
            this.button1_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Add.ForeColor = System.Drawing.Color.White;
            this.button1_Add.Location = new System.Drawing.Point(867, 393);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(119, 34);
            this.button1_Add.TabIndex = 3;
            this.button1_Add.Text = "Добавить диск";
            this.button1_Add.UseVisualStyleBackColor = false;
            // 
            // button1_Delete
            // 
            this.button1_Delete.BackColor = System.Drawing.Color.SeaGreen;
            this.button1_Delete.FlatAppearance.BorderSize = 0;
            this.button1_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Delete.ForeColor = System.Drawing.Color.White;
            this.button1_Delete.Location = new System.Drawing.Point(742, 393);
            this.button1_Delete.Name = "button1_Delete";
            this.button1_Delete.Size = new System.Drawing.Size(119, 34);
            this.button1_Delete.TabIndex = 4;
            this.button1_Delete.Text = "Удалить диск";
            this.button1_Delete.UseVisualStyleBackColor = false;
            this.button1_Delete.Visible = false;
            // 
            // button1_Edit
            // 
            this.button1_Edit.BackColor = System.Drawing.Color.SeaGreen;
            this.button1_Edit.FlatAppearance.BorderSize = 0;
            this.button1_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Edit.ForeColor = System.Drawing.Color.White;
            this.button1_Edit.Location = new System.Drawing.Point(617, 393);
            this.button1_Edit.Name = "button1_Edit";
            this.button1_Edit.Size = new System.Drawing.Size(119, 34);
            this.button1_Edit.TabIndex = 5;
            this.button1_Edit.Text = "Изменить диск";
            this.button1_Edit.UseVisualStyleBackColor = false;
            this.button1_Edit.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Выделите товар для действия!";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1_Top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Produkt_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_Edit);
            this.Controls.Add(this.button1_Delete);
            this.Controls.Add(this.button1_Add);
            this.Controls.Add(this.listView1_Disc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_Top);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produkt_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt_Edit";
            this.panel1_Top.ResumeLayout(false);
            this.panel1_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1_Top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1_Disc;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Pic;
        private System.Windows.Forms.ColumnHeader disc;
        private System.Windows.Forms.ColumnHeader colect;
        private System.Windows.Forms.ColumnHeader Izdat;
        private System.Windows.Forms.ColumnHeader coltrec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1_Add;
        private System.Windows.Forms.Button button1_Delete;
        private System.Windows.Forms.Button button1_Edit;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
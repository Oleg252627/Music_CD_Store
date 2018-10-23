namespace Eczam_ADO_Net
{
    partial class Pokupatel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1_Pocupatel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_Ok = new System.Windows.Forms.Button();
            this.bunifuImageButton1_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1_Top.Size = new System.Drawing.Size(786, 41);
            this.panel1_Top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buyer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 10);
            this.panel1.TabIndex = 2;
            // 
            // listView1_Pocupatel
            // 
            this.listView1_Pocupatel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1_Pocupatel.FullRowSelect = true;
            this.listView1_Pocupatel.GridLines = true;
            this.listView1_Pocupatel.Location = new System.Drawing.Point(12, 45);
            this.listView1_Pocupatel.MultiSelect = false;
            this.listView1_Pocupatel.Name = "listView1_Pocupatel";
            this.listView1_Pocupatel.Size = new System.Drawing.Size(762, 330);
            this.listView1_Pocupatel.TabIndex = 3;
            this.listView1_Pocupatel.UseCompatibleStateImageBehavior = false;
            this.listView1_Pocupatel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FerstName";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 229;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Col_Pokupka";
            this.columnHeader4.Width = 162;
            // 
            // button1_Ok
            // 
            this.button1_Ok.BackColor = System.Drawing.Color.SeaGreen;
            this.button1_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Ok.FlatAppearance.BorderSize = 0;
            this.button1_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Ok.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Ok.ForeColor = System.Drawing.Color.White;
            this.button1_Ok.Location = new System.Drawing.Point(304, 388);
            this.button1_Ok.Name = "button1_Ok";
            this.button1_Ok.Size = new System.Drawing.Size(150, 35);
            this.button1_Ok.TabIndex = 47;
            this.button1_Ok.Text = "OK";
            this.button1_Ok.UseVisualStyleBackColor = false;
            // 
            // bunifuImageButton1_Close
            // 
            this.bunifuImageButton1_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_Close.Image = global::Eczam_ADO_Net.Properties.Resources.Close_Korzina;
            this.bunifuImageButton1_Close.ImageActive = null;
            this.bunifuImageButton1_Close.Location = new System.Drawing.Point(750, 8);
            this.bunifuImageButton1_Close.Name = "bunifuImageButton1_Close";
            this.bunifuImageButton1_Close.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Close.TabIndex = 1;
            this.bunifuImageButton1_Close.TabStop = false;
            this.bunifuImageButton1_Close.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eczam_ADO_Net.Properties.Resources.User2;
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1_Top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Pokupatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.button1_Ok);
            this.Controls.Add(this.listView1_Pocupatel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pokupatel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokupatel";
            this.panel1_Top.ResumeLayout(false);
            this.panel1_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_Top;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1_Pocupatel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1_Ok;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
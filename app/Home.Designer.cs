namespace app
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn0 = new System.Windows.Forms.ToolStripMenuItem();
            this.odjse = new System.Windows.Forms.ToolStripMenuItem();
            this.излезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.otvori2menu = new System.Windows.Forms.ToolStripMenuItem();
            this.telma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.prikaziKom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajTextbtn = new System.Windows.Forms.Button();
            this.dodavanjeKom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("GeForce", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(346, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(189, 21);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "ГЛЕДАЈ ТВ ВО ЖИВО";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(114, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(114, 169);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(94, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(480, 137);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Постави потсетник";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(546, 111);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.Value = new System.DateTime(2020, 5, 19, 19, 42, 0, 0);
            // 
            // btn0
            // 
            this.btn0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjse,
            this.излезToolStripMenuItem});
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(71, 20);
            this.btn0.Text = "Поставки";
            // 
            // odjse
            // 
            this.odjse.Name = "odjse";
            this.odjse.Size = new System.Drawing.Size(126, 22);
            this.odjse.Text = "Одјави се";
            this.odjse.Click += new System.EventHandler(this.odjse_Click);
            // 
            // излезToolStripMenuItem
            // 
            this.излезToolStripMenuItem.Name = "излезToolStripMenuItem";
            this.излезToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.излезToolStripMenuItem.Text = "Излез";
            this.излезToolStripMenuItem.Click += new System.EventHandler(this.излезToolStripMenuItem_Click);
            // 
            // btn1
            // 
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 20);
            this.btn1.Text = "Сител";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 20);
            this.btn2.Text = "Канал 5";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // otvori2menu
            // 
            this.otvori2menu.Name = "otvori2menu";
            this.otvori2menu.Size = new System.Drawing.Size(52, 20);
            this.otvori2menu.Text = "МРТ 1";
            this.otvori2menu.Click += new System.EventHandler(this.otvori2menu_Click);
            // 
            // telma
            // 
            this.telma.Name = "telma";
            this.telma.Size = new System.Drawing.Size(53, 20);
            this.telma.Text = "Телма";
            this.telma.Click += new System.EventHandler(this.telma_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn0,
            this.btn1,
            this.btn2,
            this.otvori2menu,
            this.telma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(624, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(534, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Статус за потсетникот";
            // 
            // prikaziKom
            // 
            this.prikaziKom.Enabled = false;
            this.prikaziKom.Location = new System.Drawing.Point(21, 301);
            this.prikaziKom.Multiline = true;
            this.prikaziKom.Name = "prikaziKom";
            this.prikaziKom.Size = new System.Drawing.Size(737, 123);
            this.prikaziKom.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ваши пораки:";
            // 
            // dodajTextbtn
            // 
            this.dodajTextbtn.Location = new System.Drawing.Point(635, 272);
            this.dodajTextbtn.Name = "dodajTextbtn";
            this.dodajTextbtn.Size = new System.Drawing.Size(123, 23);
            this.dodajTextbtn.TabIndex = 30;
            this.dodajTextbtn.Text = "Прикажи коментар";
            this.dodajTextbtn.UseVisualStyleBackColor = true;
            this.dodajTextbtn.Click += new System.EventHandler(this.dodajTextbtn_Click);
            // 
            // dodavanjeKom
            // 
            this.dodavanjeKom.Location = new System.Drawing.Point(382, 274);
            this.dodavanjeKom.Name = "dodavanjeKom";
            this.dodavanjeKom.Size = new System.Drawing.Size(247, 20);
            this.dodavanjeKom.TabIndex = 31;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodavanjeKom);
            this.Controls.Add(this.dodajTextbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikaziKom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem btn0;
        private System.Windows.Forms.ToolStripMenuItem odjse;
        private System.Windows.Forms.ToolStripMenuItem излезToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn1;
        private System.Windows.Forms.ToolStripMenuItem btn2;
        private System.Windows.Forms.ToolStripMenuItem otvori2menu;
        private System.Windows.Forms.ToolStripMenuItem telma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox prikaziKom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajTextbtn;
        private System.Windows.Forms.TextBox dodavanjeKom;
    }
}
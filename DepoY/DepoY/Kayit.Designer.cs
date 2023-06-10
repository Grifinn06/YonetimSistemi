namespace DepoY
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.deletedx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_arac = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_atik = new System.Windows.Forms.TextBox();
            this.txt_btur = new System.Windows.Forms.TextBox();
            this.checkx = new System.Windows.Forms.Button();
            this.editx = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.txt_tadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletedx
            // 
            this.deletedx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletedx.ImageKey = "delete.png";
            this.deletedx.ImageList = this.ımageList2;
            this.deletedx.Location = new System.Drawing.Point(659, 284);
            this.deletedx.Name = "deletedx";
            this.deletedx.Size = new System.Drawing.Size(47, 23);
            this.deletedx.TabIndex = 43;
            this.deletedx.Text = "Sil";
            this.deletedx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletedx.UseVisualStyleBackColor = true;
            this.deletedx.Click += new System.EventHandler(this.deletedx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(303, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 182);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Teslim Alınan Araç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Atık Yağ Kilogram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Atık Yağ Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Bidon Türü";
            // 
            // txt_arac
            // 
            this.txt_arac.Location = new System.Drawing.Point(201, 191);
            this.txt_arac.Name = "txt_arac";
            this.txt_arac.Size = new System.Drawing.Size(83, 20);
            this.txt_arac.TabIndex = 37;
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(202, 152);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(83, 20);
            this.txt_kilo.TabIndex = 36;
            // 
            // txt_atik
            // 
            this.txt_atik.Location = new System.Drawing.Point(202, 114);
            this.txt_atik.Name = "txt_atik";
            this.txt_atik.Size = new System.Drawing.Size(83, 20);
            this.txt_atik.TabIndex = 35;
            // 
            // txt_btur
            // 
            this.txt_btur.Location = new System.Drawing.Point(202, 73);
            this.txt_btur.Name = "txt_btur";
            this.txt_btur.Size = new System.Drawing.Size(83, 20);
            this.txt_btur.TabIndex = 34;
            // 
            // checkx
            // 
            this.checkx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkx.ImageKey = "search.png";
            this.checkx.ImageList = this.ımageList2;
            this.checkx.Location = new System.Drawing.Point(423, 284);
            this.checkx.Name = "checkx";
            this.checkx.Size = new System.Drawing.Size(65, 23);
            this.checkx.TabIndex = 33;
            this.checkx.Text = "Sorgu";
            this.checkx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkx.UseVisualStyleBackColor = true;
            this.checkx.Click += new System.EventHandler(this.checkx_Click);
            // 
            // editx
            // 
            this.editx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editx.ImageKey = "editing.png";
            this.editx.ImageList = this.ımageList2;
            this.editx.Location = new System.Drawing.Point(539, 284);
            this.editx.Name = "editx";
            this.editx.Size = new System.Drawing.Size(75, 23);
            this.editx.TabIndex = 32;
            this.editx.Text = "Düzenle";
            this.editx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editx.UseVisualStyleBackColor = true;
            this.editx.Click += new System.EventHandler(this.editx_Click);
            // 
            // kaydet
            // 
            this.kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydet.ImageKey = "save.png";
            this.kaydet.ImageList = this.ımageList2;
            this.kaydet.Location = new System.Drawing.Point(303, 284);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(66, 23);
            this.kaydet.TabIndex = 31;
            this.kaydet.Text = "Kaydet";
            this.kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // txt_tadres
            // 
            this.txt_tadres.Location = new System.Drawing.Point(201, 235);
            this.txt_tadres.Name = "txt_tadres";
            this.txt_tadres.Size = new System.Drawing.Size(83, 20);
            this.txt_tadres.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Teslim Alınan Adres";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.ImageKey = "turn-back.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(666, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 46;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 23);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 47);
            this.panel2.TabIndex = 48;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button5.ImageKey = "power.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(723, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 34);
            this.button5.TabIndex = 47;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "power.png");
            this.ımageList1.Images.SetKeyName(1, "turn-back.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(235, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Atık Yağ Depo Yönetim Sistemi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(324, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Atık Yağ Kayıt";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "delete.png");
            this.ımageList2.Images.SetKeyName(1, "editing.png");
            this.ımageList2.Images.SetKeyName(2, "search.png");
            this.ımageList2.Images.SetKeyName(3, "save.png");
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DepoY.Properties.Resources.ssss_800x445;
            this.ClientSize = new System.Drawing.Size(775, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tadres);
            this.Controls.Add(this.deletedx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_arac);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.txt_atik);
            this.Controls.Add(this.txt_btur);
            this.Controls.Add(this.checkx);
            this.Controls.Add(this.editx);
            this.Controls.Add(this.kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletedx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_arac;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_atik;
        private System.Windows.Forms.TextBox txt_btur;
        private System.Windows.Forms.Button checkx;
        private System.Windows.Forms.Button editx;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox txt_tadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ımageList2;
    }
}
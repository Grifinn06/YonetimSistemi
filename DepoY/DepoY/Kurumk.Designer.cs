namespace DepoY
{
    partial class Kurumk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kurumk));
            this.deletedx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kadres = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_kyetkili = new System.Windows.Forms.TextBox();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.checkx = new System.Windows.Forms.Button();
            this.editx = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletedx
            // 
            this.deletedx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletedx.ImageKey = "delete.png";
            this.deletedx.ImageList = this.ımageList1;
            this.deletedx.Location = new System.Drawing.Point(647, 283);
            this.deletedx.Name = "deletedx";
            this.deletedx.Size = new System.Drawing.Size(47, 23);
            this.deletedx.TabIndex = 30;
            this.deletedx.Text = "Sil";
            this.deletedx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletedx.UseVisualStyleBackColor = true;
            this.deletedx.Click += new System.EventHandler(this.deletedx_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 183);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kurum Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Kurumun Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kurumun Yetkilisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kurum Adı";
            // 
            // txt_kadres
            // 
            this.txt_kadres.Location = new System.Drawing.Point(176, 218);
            this.txt_kadres.Name = "txt_kadres";
            this.txt_kadres.Size = new System.Drawing.Size(100, 20);
            this.txt_kadres.TabIndex = 22;
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(176, 178);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 20);
            this.txt_no.TabIndex = 21;
            // 
            // txt_kyetkili
            // 
            this.txt_kyetkili.Location = new System.Drawing.Point(176, 140);
            this.txt_kyetkili.Name = "txt_kyetkili";
            this.txt_kyetkili.Size = new System.Drawing.Size(100, 20);
            this.txt_kyetkili.TabIndex = 20;
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(176, 99);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kadi.TabIndex = 19;
            // 
            // checkx
            // 
            this.checkx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkx.ImageKey = "search.png";
            this.checkx.ImageList = this.ımageList1;
            this.checkx.Location = new System.Drawing.Point(442, 283);
            this.checkx.Name = "checkx";
            this.checkx.Size = new System.Drawing.Size(65, 23);
            this.checkx.TabIndex = 18;
            this.checkx.Text = "Sorgu";
            this.checkx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkx.UseVisualStyleBackColor = true;
            this.checkx.Click += new System.EventHandler(this.checkx_Click_1);
            // 
            // editx
            // 
            this.editx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editx.ImageKey = "editing.png";
            this.editx.ImageList = this.ımageList1;
            this.editx.Location = new System.Drawing.Point(542, 283);
            this.editx.Name = "editx";
            this.editx.Size = new System.Drawing.Size(76, 23);
            this.editx.TabIndex = 17;
            this.editx.Text = "Düzenle";
            this.editx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editx.UseVisualStyleBackColor = true;
            this.editx.Click += new System.EventHandler(this.editx_Click_1);
            // 
            // kaydet
            // 
            this.kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydet.ImageKey = "save.png";
            this.kaydet.ImageList = this.ımageList1;
            this.kaydet.Location = new System.Drawing.Point(343, 283);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(68, 23);
            this.kaydet.TabIndex = 16;
            this.kaydet.Text = "Kaydet";
            this.kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.back);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 47);
            this.panel2.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(340, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Kurum Kayıt";
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
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.close.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.close.ImageKey = "power.png";
            this.close.ImageList = this.ımageList2;
            this.close.Location = new System.Drawing.Point(723, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 34);
            this.close.TabIndex = 47;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.back.ImageKey = "turn-back.png";
            this.back.ImageList = this.ımageList2;
            this.back.Location = new System.Drawing.Point(666, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 34);
            this.back.TabIndex = 46;
            this.back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 23);
            this.panel1.TabIndex = 50;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "editing.png");
            this.ımageList1.Images.SetKeyName(2, "search.png");
            this.ımageList1.Images.SetKeyName(3, "save.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "power.png");
            this.ımageList2.Images.SetKeyName(1, "turn-back.png");
            // 
            // Kurumk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DepoY.Properties.Resources.ssss_800x445;
            this.ClientSize = new System.Drawing.Size(775, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deletedx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kadres);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.txt_kyetkili);
            this.Controls.Add(this.txt_kadi);
            this.Controls.Add(this.checkx);
            this.Controls.Add(this.editx);
            this.Controls.Add(this.kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kurumk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurumk";
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
        private System.Windows.Forms.TextBox txt_kadres;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_kyetkili;
        private System.Windows.Forms.TextBox txt_kadi;
        private System.Windows.Forms.Button checkx;
        private System.Windows.Forms.Button editx;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}
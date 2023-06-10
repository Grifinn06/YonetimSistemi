namespace DepoY
{
    partial class bidon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bidon));
            this.kaydet = new System.Windows.Forms.Button();
            this.editx = new System.Windows.Forms.Button();
            this.checkx = new System.Windows.Forms.Button();
            this.txt_toplam = new System.Windows.Forms.TextBox();
            this.txt_deform = new System.Windows.Forms.TextBox();
            this.txt_bos = new System.Windows.Forms.TextBox();
            this.txt_dolu = new System.Windows.Forms.TextBox();
            this.txt_teneke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletedx = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kapat = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.back = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaydet
            // 
            this.kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydet.ImageKey = "save.png";
            this.kaydet.ImageList = this.ımageList1;
            this.kaydet.Location = new System.Drawing.Point(314, 280);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(65, 23);
            this.kaydet.TabIndex = 0;
            this.kaydet.Text = "Kaydet";
            this.kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // editx
            // 
            this.editx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editx.ImageKey = "editing.png";
            this.editx.ImageList = this.ımageList1;
            this.editx.Location = new System.Drawing.Point(549, 280);
            this.editx.Name = "editx";
            this.editx.Size = new System.Drawing.Size(74, 23);
            this.editx.TabIndex = 2;
            this.editx.Text = "Düzenle";
            this.editx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editx.UseVisualStyleBackColor = true;
            this.editx.Click += new System.EventHandler(this.editx_Click);
            // 
            // checkx
            // 
            this.checkx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkx.ImageKey = "search.png";
            this.checkx.ImageList = this.ımageList1;
            this.checkx.Location = new System.Drawing.Point(439, 280);
            this.checkx.Name = "checkx";
            this.checkx.Size = new System.Drawing.Size(64, 23);
            this.checkx.TabIndex = 3;
            this.checkx.Text = "Sorgu";
            this.checkx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkx.UseVisualStyleBackColor = true;
            this.checkx.Click += new System.EventHandler(this.checkx_Click);
            // 
            // txt_toplam
            // 
            this.txt_toplam.Location = new System.Drawing.Point(183, 77);
            this.txt_toplam.Name = "txt_toplam";
            this.txt_toplam.Size = new System.Drawing.Size(83, 20);
            this.txt_toplam.TabIndex = 4;
            // 
            // txt_deform
            // 
            this.txt_deform.Location = new System.Drawing.Point(183, 118);
            this.txt_deform.Name = "txt_deform";
            this.txt_deform.Size = new System.Drawing.Size(83, 20);
            this.txt_deform.TabIndex = 5;
            // 
            // txt_bos
            // 
            this.txt_bos.Location = new System.Drawing.Point(183, 156);
            this.txt_bos.Name = "txt_bos";
            this.txt_bos.Size = new System.Drawing.Size(83, 20);
            this.txt_bos.TabIndex = 6;
            // 
            // txt_dolu
            // 
            this.txt_dolu.Location = new System.Drawing.Point(183, 196);
            this.txt_dolu.Name = "txt_dolu";
            this.txt_dolu.Size = new System.Drawing.Size(83, 20);
            this.txt_dolu.TabIndex = 7;
            // 
            // txt_teneke
            // 
            this.txt_teneke.Location = new System.Drawing.Point(183, 228);
            this.txt_teneke.Name = "txt_teneke";
            this.txt_teneke.Size = new System.Drawing.Size(83, 20);
            this.txt_teneke.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Toplam Bidon Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deforme Bidon Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Boş Bidon Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dolu Bidon Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teneke Sayısı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(314, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 182);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // deletedx
            // 
            this.deletedx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletedx.ImageKey = "delete.png";
            this.deletedx.ImageList = this.ımageList1;
            this.deletedx.Location = new System.Drawing.Point(669, 280);
            this.deletedx.Name = "deletedx";
            this.deletedx.Size = new System.Drawing.Size(48, 23);
            this.deletedx.TabIndex = 15;
            this.deletedx.Text = "Sil";
            this.deletedx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletedx.UseVisualStyleBackColor = true;
            this.deletedx.Click += new System.EventHandler(this.deletedx_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.kapat);
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
            this.label7.Location = new System.Drawing.Point(349, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Bidon Kayıt";
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
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.kapat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.kapat.ImageKey = "power.png";
            this.kapat.ImageList = this.ımageList2;
            this.kapat.Location = new System.Drawing.Point(723, 8);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(40, 34);
            this.kapat.TabIndex = 47;
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "turn-back.png");
            this.ımageList2.Images.SetKeyName(1, "power.png");
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.back.ImageKey = "turn-back.png";
            this.back.ImageList = this.ımageList2;
            this.back.Location = new System.Drawing.Point(664, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 34);
            this.back.TabIndex = 46;
            this.back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 23);
            this.panel1.TabIndex = 50;
            // 
            // bidon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DepoY.Properties.Resources.ssss_800x445;
            this.ClientSize = new System.Drawing.Size(775, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deletedx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teneke);
            this.Controls.Add(this.txt_dolu);
            this.Controls.Add(this.txt_bos);
            this.Controls.Add(this.txt_deform);
            this.Controls.Add(this.txt_toplam);
            this.Controls.Add(this.checkx);
            this.Controls.Add(this.editx);
            this.Controls.Add(this.kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bidon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bidon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button editx;
        private System.Windows.Forms.Button checkx;
        private System.Windows.Forms.TextBox txt_toplam;
        private System.Windows.Forms.TextBox txt_deform;
        private System.Windows.Forms.TextBox txt_bos;
        private System.Windows.Forms.TextBox txt_dolu;
        private System.Windows.Forms.TextBox txt_teneke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deletedx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Panel panel1;
    }
}
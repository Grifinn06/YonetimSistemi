namespace DepoY
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.kurumk = new System.Windows.Forms.Button();
            this.bidonk = new System.Windows.Forms.Button();
            this.atik = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // kurumk
            // 
            this.kurumk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurumk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kurumk.ImageKey = "store.png";
            this.kurumk.ImageList = this.ımageList1;
            this.kurumk.Location = new System.Drawing.Point(94, 63);
            this.kurumk.Name = "kurumk";
            this.kurumk.Size = new System.Drawing.Size(134, 68);
            this.kurumk.TabIndex = 0;
            this.kurumk.Text = "Kurum Bilgileri";
            this.kurumk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kurumk.UseVisualStyleBackColor = true;
            this.kurumk.Click += new System.EventHandler(this.kurumk_Click);
            // 
            // bidonk
            // 
            this.bidonk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bidonk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bidonk.ImageKey = "oil-barrel.png";
            this.bidonk.ImageList = this.ımageList1;
            this.bidonk.Location = new System.Drawing.Point(546, 63);
            this.bidonk.Name = "bidonk";
            this.bidonk.Size = new System.Drawing.Size(138, 68);
            this.bidonk.TabIndex = 1;
            this.bidonk.Text = "Bidon Bilgileri";
            this.bidonk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bidonk.UseVisualStyleBackColor = true;
            this.bidonk.Click += new System.EventHandler(this.bidonk_Click);
            // 
            // atik
            // 
            this.atik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.atik.ImageKey = "analyst.png";
            this.atik.ImageList = this.ımageList1;
            this.atik.Location = new System.Drawing.Point(320, 63);
            this.atik.Name = "atik";
            this.atik.Size = new System.Drawing.Size(140, 68);
            this.atik.TabIndex = 2;
            this.atik.Text = "Atık Bilgileri";
            this.atik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.atik.UseVisualStyleBackColor = true;
            this.atik.Click += new System.EventHandler(this.atik_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 150);
            this.dataGridView1.TabIndex = 4;
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
            this.panel2.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(340, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Kayıt İnceleme";
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
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 23);
            this.panel1.TabIndex = 51;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "editing.png");
            this.ımageList1.Images.SetKeyName(2, "search.png");
            this.ımageList1.Images.SetKeyName(3, "save.png");
            this.ımageList1.Images.SetKeyName(4, "analyst.png");
            this.ımageList1.Images.SetKeyName(5, "oil-barrel.png");
            this.ımageList1.Images.SetKeyName(6, "process.png");
            this.ımageList1.Images.SetKeyName(7, "store.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "turn-back.png");
            this.ımageList2.Images.SetKeyName(1, "power.png");
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DepoY.Properties.Resources.ssss_800x445;
            this.ClientSize = new System.Drawing.Size(775, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.atik);
            this.Controls.Add(this.bidonk);
            this.Controls.Add(this.kurumk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kurumk;
        private System.Windows.Forms.Button bidonk;
        private System.Windows.Forms.Button atik;
        private System.Windows.Forms.DataGridView dataGridView1;
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
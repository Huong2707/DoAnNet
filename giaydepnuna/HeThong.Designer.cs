namespace giaydepnuna
{
    partial class HeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncaidat = new System.Windows.Forms.Button();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.btnsp = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnncc = new System.Windows.Forms.Button();
            this.btnnv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trangchu = new System.Windows.Forms.Label();
            this.panelbody = new System.Windows.Forms.Panel();
            this.btnluong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnluong);
            this.panel1.Controls.Add(this.btncaidat);
            this.panel1.Controls.Add(this.btnhoadon);
            this.panel1.Controls.Add(this.btnsp);
            this.panel1.Controls.Add(this.btnnhap);
            this.panel1.Controls.Add(this.btnncc);
            this.panel1.Controls.Add(this.btnnv);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 685);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncaidat
            // 
            this.btncaidat.Location = new System.Drawing.Point(42, 620);
            this.btncaidat.Name = "btncaidat";
            this.btncaidat.Size = new System.Drawing.Size(148, 53);
            this.btncaidat.TabIndex = 10;
            this.btncaidat.Text = "Cài Đặt";
            this.btncaidat.UseVisualStyleBackColor = true;
            this.btncaidat.Click += new System.EventHandler(this.btncaidat_Click);
            // 
            // btnhoadon
            // 
            this.btnhoadon.Location = new System.Drawing.Point(42, 476);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(148, 53);
            this.btnhoadon.TabIndex = 8;
            this.btnhoadon.Text = "Hóa Đơn";
            this.btnhoadon.UseVisualStyleBackColor = true;
            this.btnhoadon.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsp
            // 
            this.btnsp.Location = new System.Drawing.Point(42, 397);
            this.btnsp.Name = "btnsp";
            this.btnsp.Size = new System.Drawing.Size(148, 53);
            this.btnsp.TabIndex = 7;
            this.btnsp.Text = "Sản Phẩm";
            this.btnsp.UseVisualStyleBackColor = true;
            this.btnsp.Click += new System.EventHandler(this.btnsp_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(42, 317);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(148, 53);
            this.btnnhap.TabIndex = 6;
            this.btnnhap.Text = "Phiếu Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnncc
            // 
            this.btnncc.Location = new System.Drawing.Point(42, 229);
            this.btnncc.Name = "btnncc";
            this.btnncc.Size = new System.Drawing.Size(148, 53);
            this.btnncc.TabIndex = 5;
            this.btnncc.Text = "Nhà Cung Cấp";
            this.btnncc.UseVisualStyleBackColor = true;
            this.btnncc.Click += new System.EventHandler(this.btnncc_Click);
            // 
            // btnnv
            // 
            this.btnnv.Location = new System.Drawing.Point(42, 140);
            this.btnnv.Name = "btnnv";
            this.btnnv.Size = new System.Drawing.Size(148, 53);
            this.btnnv.TabIndex = 4;
            this.btnnv.Text = "Nhân Viên";
            this.btnnv.UseVisualStyleBackColor = true;
            this.btnnv.Click += new System.EventHandler(this.btnnv_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trangchu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 120);
            this.panel2.TabIndex = 2;
            // 
            // trangchu
            // 
            this.trangchu.AutoSize = true;
            this.trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangchu.Location = new System.Drawing.Point(23, 44);
            this.trangchu.Name = "trangchu";
            this.trangchu.Size = new System.Drawing.Size(147, 32);
            this.trangchu.TabIndex = 0;
            this.trangchu.Text = "Trang Chủ";
            // 
            // panelbody
            // 
            this.panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbody.Location = new System.Drawing.Point(270, 120);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(819, 565);
            this.panelbody.TabIndex = 3;
            // 
            // btnluong
            // 
            this.btnluong.Location = new System.Drawing.Point(42, 553);
            this.btnluong.Name = "btnluong";
            this.btnluong.Size = new System.Drawing.Size(148, 49);
            this.btnluong.TabIndex = 11;
            this.btnluong.Text = "Lương";
            this.btnluong.UseVisualStyleBackColor = true;
            this.btnluong.Click += new System.EventHandler(this.btnluong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::giaydepnuna.Properties.Resources.thiet_ke_logo_shop_giay_19_1584095087_removebg_preview;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 685);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HeThong";
            this.Text = "HeThong";
            this.Load += new System.EventHandler(this.HeThong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnhoadon;
        private System.Windows.Forms.Button btnsp;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnncc;
        private System.Windows.Forms.Button btnnv;
        private System.Windows.Forms.Button btncaidat;
        private System.Windows.Forms.Label trangchu;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.Button btnluong;
    }
}
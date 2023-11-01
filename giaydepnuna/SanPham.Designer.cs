namespace giaydepnuna
{
    partial class SanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtloai = new System.Windows.Forms.TextBox();
            this.txtkichco = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.idncc = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDSP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TênSP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(935, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID NCC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kích cỡ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(964, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giá:";
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(135, 46);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(266, 26);
            this.txtsp.TabIndex = 8;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(135, 94);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(266, 26);
            this.txttensp.TabIndex = 9;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(135, 145);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(266, 26);
            this.txtsl.TabIndex = 10;
            this.txtsl.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtloai
            // 
            this.txtloai.Location = new System.Drawing.Point(574, 43);
            this.txtloai.Name = "txtloai";
            this.txtloai.Size = new System.Drawing.Size(300, 26);
            this.txtloai.TabIndex = 11;
            this.txtloai.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtkichco
            // 
            this.txtkichco.Location = new System.Drawing.Point(574, 91);
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(300, 26);
            this.txtkichco.TabIndex = 12;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(574, 142);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(300, 26);
            this.txtghichu.TabIndex = 13;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(1022, 40);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(308, 26);
            this.txtgia.TabIndex = 14;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(135, 232);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(462, 26);
            this.txttk.TabIndex = 16;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(624, 213);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(111, 45);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgvsp
            // 
            this.dgvsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Location = new System.Drawing.Point(31, 327);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvsp.RowTemplate.Height = 28;
            this.dgvsp.ShowEditingIcon = false;
            this.dgvsp.Size = new System.Drawing.Size(1099, 327);
            this.dgvsp.TabIndex = 18;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick);
            // 
            // idncc
            // 
            this.idncc.FormattingEnabled = true;
            this.idncc.Location = new System.Drawing.Point(1022, 97);
            this.idncc.Name = "idncc";
            this.idncc.Size = new System.Drawing.Size(308, 28);
            this.idncc.TabIndex = 19;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(1245, 360);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(158, 44);
            this.btnthem.TabIndex = 20;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(1245, 446);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(158, 44);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1478, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(1245, 527);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(158, 44);
            this.btnlammoi.TabIndex = 23;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(1478, 360);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(158, 44);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1478, 527);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 44);
            this.button6.TabIndex = 25;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 656);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.idncc);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtkichco);
            this.Controls.Add(this.txtloai);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtloai;
        private System.Windows.Forms.TextBox txtkichco;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.ComboBox idncc;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button6;
    }
}
namespace giaydepnuna
{
    partial class PhieuNhap
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
            this.txtpn = new System.Windows.Forms.TextBox();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtncc = new System.Windows.Forms.TextBox();
            this.dgvpn = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvnhap = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnlmmoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDPN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDSP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDNCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn Giá:";
            // 
            // txtpn
            // 
            this.txtpn.Location = new System.Drawing.Point(98, 43);
            this.txtpn.Name = "txtpn";
            this.txtpn.Size = new System.Drawing.Size(126, 26);
            this.txtpn.TabIndex = 5;
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(98, 86);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(126, 26);
            this.txtsp.TabIndex = 6;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(98, 132);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(126, 26);
            this.txtsl.TabIndex = 7;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(344, 37);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(113, 26);
            this.txtdongia.TabIndex = 8;
            // 
            // txtncc
            // 
            this.txtncc.Location = new System.Drawing.Point(344, 86);
            this.txtncc.Name = "txtncc";
            this.txtncc.Size = new System.Drawing.Size(113, 26);
            this.txtncc.TabIndex = 9;
            // 
            // dgvpn
            // 
            this.dgvpn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpn.Location = new System.Drawing.Point(524, 37);
            this.dgvpn.Name = "dgvpn";
            this.dgvpn.RowHeadersWidth = 62;
            this.dgvpn.RowTemplate.Height = 28;
            this.dgvpn.Size = new System.Drawing.Size(824, 248);
            this.dgvpn.TabIndex = 10;
            this.dgvpn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phiếu Nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dgvnhap
            // 
            this.dgvnhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhap.Location = new System.Drawing.Point(45, 411);
            this.dgvnhap.Name = "dgvnhap";
            this.dgvnhap.RowHeadersWidth = 62;
            this.dgvnhap.RowTemplate.Height = 28;
            this.dgvnhap.Size = new System.Drawing.Size(892, 219);
            this.dgvnhap.TabIndex = 13;
            this.dgvnhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày lập:";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(98, 198);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 38);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnlmmoi
            // 
            this.btnlmmoi.Location = new System.Drawing.Point(98, 261);
            this.btnlmmoi.Name = "btnlmmoi";
            this.btnlmmoi.Size = new System.Drawing.Size(126, 41);
            this.btnlmmoi.TabIndex = 17;
            this.btnlmmoi.Text = "Làm mới";
            this.btnlmmoi.UseVisualStyleBackColor = true;
            this.btnlmmoi.Click += new System.EventHandler(this.btnlmmoi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlmmoi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvnhap);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvpn);
            this.Controls.Add(this.txtncc);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.txtpn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpn;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtncc;
        private System.Windows.Forms.DataGridView dgvpn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvnhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlmmoi;
        private System.Windows.Forms.Button button1;
    }
}
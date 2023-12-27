namespace giaydepnuna
{
    partial class Luong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtthuong = new System.Windows.Forms.TextBox();
            this.txtngaycong = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.cbidnv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvluong = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnlmmoi = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtthuong
            // 
            this.txtthuong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthuong.Location = new System.Drawing.Point(696, 115);
            this.txtthuong.Name = "txtthuong";
            this.txtthuong.Size = new System.Drawing.Size(288, 30);
            this.txtthuong.TabIndex = 0;
            // 
            // txtngaycong
            // 
            this.txtngaycong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaycong.Location = new System.Drawing.Point(696, 55);
            this.txtngaycong.Name = "txtngaycong";
            this.txtngaycong.Size = new System.Drawing.Size(288, 30);
            this.txtngaycong.TabIndex = 2;
            // 
            // txtthang
            // 
            this.txtthang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthang.Location = new System.Drawing.Point(151, 118);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(288, 30);
            this.txtthang.TabIndex = 3;
            this.txtthang.TextChanged += new System.EventHandler(this.txtthang_TextChanged);
            // 
            // cbidnv
            // 
            this.cbidnv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbidnv.FormattingEnabled = true;
            this.cbidnv.Location = new System.Drawing.Point(151, 58);
            this.cbidnv.Name = "cbidnv";
            this.cbidnv.Size = new System.Drawing.Size(288, 30);
            this.cbidnv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "IDNV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thưởng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Công:";
            // 
            // dgvluong
            // 
            this.dgvluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvluong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvluong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvluong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluong.Location = new System.Drawing.Point(81, 235);
            this.dgvluong.Name = "dgvluong";
            this.dgvluong.RowHeadersWidth = 62;
            this.dgvluong.RowTemplate.Height = 28;
            this.dgvluong.Size = new System.Drawing.Size(1077, 412);
            this.dgvluong.TabIndex = 9;
            this.dgvluong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvluong_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1213, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1213, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlmmoi
            // 
            this.btnlmmoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlmmoi.Location = new System.Drawing.Point(1213, 403);
            this.btnlmmoi.Name = "btnlmmoi";
            this.btnlmmoi.Size = new System.Drawing.Size(111, 59);
            this.btnlmmoi.TabIndex = 13;
            this.btnlmmoi.Text = "Làm mới";
            this.btnlmmoi.UseVisualStyleBackColor = true;
            this.btnlmmoi.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1213, 497);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 56);
            this.button5.TabIndex = 14;
            this.button5.Text = "Xuất Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1213, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 60);
            this.button3.TabIndex = 15;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1623, 699);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnlmmoi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbidnv);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.txtngaycong);
            this.Controls.Add(this.txtthuong);
            this.Name = "Luong";
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtthuong;
        private System.Windows.Forms.TextBox txtngaycong;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.ComboBox cbidnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlmmoi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}
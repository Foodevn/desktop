namespace bai1
{
    partial class FormBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rbTrang = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtSOLuong = new System.Windows.Forms.TextBox();
            this.btnSoLuong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTrang);
            this.groupBox1.Controls.Add(this.rbDo);
            this.groupBox1.Controls.Add(this.rbXanh);
            this.groupBox1.Location = new System.Drawing.Point(679, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Màu Xe";
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(23, 20);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(50, 17);
            this.rbXanh.TabIndex = 0;
            this.rbXanh.TabStop = true;
            this.rbXanh.Text = "Xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            this.rbXanh.CheckedChanged += new System.EventHandler(this.rbXanh_CheckedChanged);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(23, 43);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(39, 17);
            this.rbDo.TabIndex = 1;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // rbTrang
            // 
            this.rbTrang.AutoSize = true;
            this.rbTrang.Location = new System.Drawing.Point(23, 66);
            this.rbTrang.Name = "rbTrang";
            this.rbTrang.Size = new System.Drawing.Size(53, 17);
            this.rbTrang.TabIndex = 2;
            this.rbTrang.TabStop = true;
            this.rbTrang.Text = "Trắng";
            this.rbTrang.UseVisualStyleBackColor = true;
            this.rbTrang.CheckedChanged += new System.EventHandler(this.rbTrang_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(679, 184);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(49, 13);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(742, 177);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(162, 20);
            this.txtDonGia.TabIndex = 4;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(910, 180);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(13, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "$";
            // 
            // txtSOLuong
            // 
            this.txtSOLuong.Location = new System.Drawing.Point(742, 220);
            this.txtSOLuong.Name = "txtSOLuong";
            this.txtSOLuong.Size = new System.Drawing.Size(162, 20);
            this.txtSOLuong.TabIndex = 6;
            // 
            // btnSoLuong
            // 
            this.btnSoLuong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSoLuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSoLuong.Location = new System.Drawing.Point(702, 271);
            this.btnSoLuong.Name = "btnSoLuong";
            this.btnSoLuong.Size = new System.Drawing.Size(75, 23);
            this.btnSoLuong.TabIndex = 7;
            this.btnSoLuong.Text = "Tính Tiền";
            this.btnSoLuong.UseVisualStyleBackColor = false;
            this.btnSoLuong.Click += new System.EventHandler(this.btnSoLuong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(593, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng tiền thanh toán: ";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.Location = new System.Drawing.Point(785, 352);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(19, 20);
            this.lbTien.TabIndex = 9;
            this.lbTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(894, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 502);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSoLuong);
            this.Controls.Add(this.txtSOLuong);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormBai1";
            this.Text = "FormBai1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.RadioButton rbTrang;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtSOLuong;
        private System.Windows.Forms.Button btnSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label label4;
    }
}
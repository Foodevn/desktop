namespace bai2
{
	partial class Form1
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
			this.tbSoThuNhat = new System.Windows.Forms.TextBox();
			this.tbSOThuHai = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbChia = new System.Windows.Forms.RadioButton();
			this.rbNhan = new System.Windows.Forms.RadioButton();
			this.rbTru = new System.Windows.Forms.RadioButton();
			this.rbCong = new System.Windows.Forms.RadioButton();
			this.btnResult = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số Thứ Nhất:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số Thứ Hai";
			// 
			// tbSoThuNhat
			// 
			this.tbSoThuNhat.Location = new System.Drawing.Point(176, 66);
			this.tbSoThuNhat.Name = "tbSoThuNhat";
			this.tbSoThuNhat.Size = new System.Drawing.Size(120, 22);
			this.tbSoThuNhat.TabIndex = 1;
			// 
			// tbSOThuHai
			// 
			this.tbSOThuHai.Location = new System.Drawing.Point(176, 101);
			this.tbSOThuHai.Name = "tbSOThuHai";
			this.tbSOThuHai.Size = new System.Drawing.Size(120, 22);
			this.tbSOThuHai.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbChia);
			this.groupBox1.Controls.Add(this.rbNhan);
			this.groupBox1.Controls.Add(this.rbTru);
			this.groupBox1.Controls.Add(this.rbCong);
			this.groupBox1.Location = new System.Drawing.Point(96, 173);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 154);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn Phép Toán";
			// 
			// rbChia
			// 
			this.rbChia.AutoSize = true;
			this.rbChia.Location = new System.Drawing.Point(7, 117);
			this.rbChia.Name = "rbChia";
			this.rbChia.Size = new System.Drawing.Size(55, 20);
			this.rbChia.TabIndex = 3;
			this.rbChia.Text = "Chia";
			this.rbChia.UseVisualStyleBackColor = true;
			// 
			// rbNhan
			// 
			this.rbNhan.AutoSize = true;
			this.rbNhan.Location = new System.Drawing.Point(7, 91);
			this.rbNhan.Name = "rbNhan";
			this.rbNhan.Size = new System.Drawing.Size(60, 20);
			this.rbNhan.TabIndex = 2;
			this.rbNhan.Text = "Nhân";
			this.rbNhan.UseVisualStyleBackColor = true;
			// 
			// rbTru
			// 
			this.rbTru.AutoSize = true;
			this.rbTru.Location = new System.Drawing.Point(6, 65);
			this.rbTru.Name = "rbTru";
			this.rbTru.Size = new System.Drawing.Size(48, 20);
			this.rbTru.TabIndex = 1;
			this.rbTru.Text = "Trừ";
			this.rbTru.UseVisualStyleBackColor = true;
			// 
			// rbCong
			// 
			this.rbCong.AutoSize = true;
			this.rbCong.Checked = true;
			this.rbCong.Location = new System.Drawing.Point(7, 39);
			this.rbCong.Name = "rbCong";
			this.rbCong.Size = new System.Drawing.Size(63, 20);
			this.rbCong.TabIndex = 0;
			this.rbCong.TabStop = true;
			this.rbCong.Text = "Cộng ";
			this.rbCong.UseVisualStyleBackColor = true;
			// 
			// btnResult
			// 
			this.btnResult.Location = new System.Drawing.Point(141, 346);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(92, 23);
			this.btnResult.TabIndex = 3;
			this.btnResult.Text = "Xem Kết Quả";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 388);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kết quả là:";
			// 
			// lbKetQua
			// 
			this.lbKetQua.AutoSize = true;
			this.lbKetQua.Location = new System.Drawing.Point(193, 388);
			this.lbKetQua.Name = "lbKetQua";
			this.lbKetQua.Size = new System.Drawing.Size(14, 16);
			this.lbKetQua.TabIndex = 0;
			this.lbKetQua.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 450);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbSOThuHai);
			this.Controls.Add(this.tbSoThuNhat);
			this.Controls.Add(this.lbKetQua);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbSoThuNhat;
		private System.Windows.Forms.TextBox tbSOThuHai;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbChia;
		private System.Windows.Forms.RadioButton rbNhan;
		private System.Windows.Forms.RadioButton rbTru;
		private System.Windows.Forms.RadioButton rbCong;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbKetQua;
	}
}


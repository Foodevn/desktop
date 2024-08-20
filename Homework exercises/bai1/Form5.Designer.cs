namespace bai1
{
	partial class Form5
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnFlat = new System.Windows.Forms.Button();
			this.cbDoiMau = new System.Windows.Forms.CheckBox();
			this.cbDoiNen = new System.Windows.Forms.CheckBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(78, 78);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Button";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnFlat
			// 
			this.btnFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnFlat.Location = new System.Drawing.Point(78, 161);
			this.btnFlat.Name = "btnFlat";
			this.btnFlat.Size = new System.Drawing.Size(108, 23);
			this.btnFlat.TabIndex = 0;
			this.btnFlat.Text = "Button Flat";
			this.btnFlat.UseVisualStyleBackColor = true;
			// 
			// cbDoiMau
			// 
			this.cbDoiMau.AutoSize = true;
			this.cbDoiMau.Location = new System.Drawing.Point(299, 69);
			this.cbDoiMau.Name = "cbDoiMau";
			this.cbDoiMau.Size = new System.Drawing.Size(135, 20);
			this.cbDoiMau.TabIndex = 1;
			this.cbDoiMau.Text = "Thay đổi màu chữ";
			this.cbDoiMau.UseVisualStyleBackColor = true;
			this.cbDoiMau.CheckedChanged += new System.EventHandler(this.cbDoiMau_CheckedChanged);
			// 
			// cbDoiNen
			// 
			this.cbDoiNen.AutoSize = true;
			this.cbDoiNen.Location = new System.Drawing.Point(299, 95);
			this.cbDoiNen.Name = "cbDoiNen";
			this.cbDoiNen.Size = new System.Drawing.Size(136, 20);
			this.cbDoiNen.TabIndex = 1;
			this.cbDoiNen.Text = "Thay đổi màu nền";
			this.cbDoiNen.UseVisualStyleBackColor = true;
			this.cbDoiNen.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(299, 140);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 20);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "kiểu flat";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(299, 166);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(97, 20);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Kiểu Pupop";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 323);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.cbDoiNen);
			this.Controls.Add(this.cbDoiMau);
			this.Controls.Add(this.btnFlat);
			this.Controls.Add(this.button1);
			this.Name = "Form5";
			this.Text = "Form5";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnFlat;
		private System.Windows.Forms.CheckBox cbDoiMau;
		private System.Windows.Forms.CheckBox cbDoiNen;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
	}
}
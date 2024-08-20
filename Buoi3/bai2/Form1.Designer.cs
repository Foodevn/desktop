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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.GpMau = new System.Windows.Forms.GroupBox();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.btnToMAu = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tbMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GpMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Nu);
            this.groupBox1.Controls.Add(this.rb_Nam);
            this.groupBox1.Location = new System.Drawing.Point(205, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính ";
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Checked = true;
            this.rb_Nam.Location = new System.Drawing.Point(38, 30);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(47, 17);
            this.rb_Nam.TabIndex = 0;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            this.rb_Nam.CheckedChanged += new System.EventHandler(this.rb_Nam_CheckedChanged);
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Location = new System.Drawing.Point(38, 53);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rb_Nu.TabIndex = 1;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            this.rb_Nu.CheckedChanged += new System.EventHandler(this.rb_Nu_CheckedChanged);
            // 
            // GpMau
            // 
            this.GpMau.Controls.Add(this.btnToMAu);
            this.GpMau.Controls.Add(this.rbXanh);
            this.GpMau.Controls.Add(this.rbDo);
            this.GpMau.Location = new System.Drawing.Point(205, 237);
            this.GpMau.Name = "GpMau";
            this.GpMau.Size = new System.Drawing.Size(200, 100);
            this.GpMau.TabIndex = 2;
            this.GpMau.TabStop = false;
            this.GpMau.Text = "Màu";
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(38, 53);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(50, 17);
            this.rbXanh.TabIndex = 1;
            this.rbXanh.Text = "Xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Checked = true;
            this.rbDo.Location = new System.Drawing.Point(38, 30);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(39, 17);
            this.rbDo.TabIndex = 0;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            // 
            // btnToMAu
            // 
            this.btnToMAu.Location = new System.Drawing.Point(108, 47);
            this.btnToMAu.Name = "btnToMAu";
            this.btnToMAu.Size = new System.Drawing.Size(75, 23);
            this.btnToMAu.TabIndex = 2;
            this.btnToMAu.Text = "Tô Màu";
            this.btnToMAu.UseVisualStyleBackColor = true;
            this.btnToMAu.Click += new System.EventHandler(this.btnToMAu_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // tbMau
            // 
            this.tbMau.Location = new System.Drawing.Point(468, 284);
            this.tbMau.Name = "tbMau";
            this.tbMau.Size = new System.Drawing.Size(182, 20);
            this.tbMau.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMau);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.GpMau);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "bài tập 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpMau.ResumeLayout(false);
            this.GpMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.GroupBox GpMau;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.Button btnToMAu;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox tbMau;
    }
}


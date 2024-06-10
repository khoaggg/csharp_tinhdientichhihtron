namespace csharp_tinhdientichhihtron
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
            this.labell1 = new System.Windows.Forms.Label();
            this.btndt = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdt1 = new System.Windows.Forms.RadioButton();
            this.rdbcv1 = new System.Windows.Forms.RadioButton();
            this.chkdt1 = new System.Windows.Forms.CheckBox();
            this.chkcv1 = new System.Windows.Forms.CheckBox();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labell1
            // 
            this.labell1.AutoSize = true;
            this.labell1.Location = new System.Drawing.Point(92, 49);
            this.labell1.Name = "labell1";
            this.labell1.Size = new System.Drawing.Size(77, 13);
            this.labell1.TabIndex = 0;
            this.labell1.Text = "Nhập bán kinh";
            // 
            // btndt
            // 
            this.btndt.Location = new System.Drawing.Point(95, 161);
            this.btndt.Name = "btndt";
            this.btndt.Size = new System.Drawing.Size(75, 23);
            this.btndt.TabIndex = 1;
            this.btndt.Text = "diện tích";
            this.btndt.UseVisualStyleBackColor = true;
            this.btndt.Click += new System.EventHandler(this.btndt_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(175, 46);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(92, 96);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(43, 13);
            this.lblketqua.TabIndex = 3;
            this.lblketqua.Text = "kết quả";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(175, 89);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tính diện tích chu vi hình tròn";
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(226, 161);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 6;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcv1);
            this.groupBox1.Controls.Add(this.rdbdt1);
            this.groupBox1.Location = new System.Drawing.Point(362, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkcv1);
            this.groupBox2.Controls.Add(this.chkdt1);
            this.groupBox2.Location = new System.Drawing.Point(588, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chọn chức năng";
            // 
            // rdbdt1
            // 
            this.rdbdt1.AutoSize = true;
            this.rdbdt1.Location = new System.Drawing.Point(7, 20);
            this.rdbdt1.Name = "rdbdt1";
            this.rdbdt1.Size = new System.Drawing.Size(89, 17);
            this.rdbdt1.TabIndex = 0;
            this.rdbdt1.TabStop = true;
            this.rdbdt1.Text = "tính diện tích";
            this.rdbdt1.UseVisualStyleBackColor = true;
            // 
            // rdbcv1
            // 
            this.rdbcv1.AutoSize = true;
            this.rdbcv1.Location = new System.Drawing.Point(6, 61);
            this.rdbcv1.Name = "rdbcv1";
            this.rdbcv1.Size = new System.Drawing.Size(76, 17);
            this.rdbcv1.TabIndex = 1;
            this.rdbcv1.TabStop = true;
            this.rdbcv1.Text = "tính chu vi";
            this.rdbcv1.UseVisualStyleBackColor = true;
            // 
            // chkdt1
            // 
            this.chkdt1.AutoSize = true;
            this.chkdt1.Location = new System.Drawing.Point(7, 20);
            this.chkdt1.Name = "chkdt1";
            this.chkdt1.Size = new System.Drawing.Size(90, 17);
            this.chkdt1.TabIndex = 0;
            this.chkdt1.Text = "tính diện tích";
            this.chkdt1.UseVisualStyleBackColor = true;
            // 
            // chkcv1
            // 
            this.chkcv1.AutoSize = true;
            this.chkcv1.Location = new System.Drawing.Point(7, 59);
            this.chkcv1.Name = "chkcv1";
            this.chkcv1.Size = new System.Drawing.Size(77, 17);
            this.chkcv1.TabIndex = 1;
            this.chkcv1.Text = "tính chu vi";
            this.chkcv1.UseVisualStyleBackColor = true;
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(393, 171);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(75, 23);
            this.btntinh1.TabIndex = 9;
            this.btntinh1.Text = "tính 1";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.btntinh1_Click);
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(645, 171);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btntinh2.Size = new System.Drawing.Size(75, 23);
            this.btntinh2.TabIndex = 10;
            this.btntinh2.Text = "tính 2";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btndt);
            this.Controls.Add(this.labell1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labell1;
        private System.Windows.Forms.Button btndt;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcv1;
        private System.Windows.Forms.RadioButton rdbdt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkcv1;
        private System.Windows.Forms.CheckBox chkdt1;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.Button btntinh2;
    }
}


namespace _8__quản_lý_khách_hàng
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidphanhoi = new System.Windows.Forms.TextBox();
            this.ngay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtidkhachhang = new System.Windows.Forms.TextBox();
            this.txtnoidungphanhoi = new System.Windows.Forms.TextBox();
            this.txtngayphanhoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtidphanhoi
            // 
            this.txtidphanhoi.Location = new System.Drawing.Point(174, 34);
            this.txtidphanhoi.Name = "txtidphanhoi";
            this.txtidphanhoi.Size = new System.Drawing.Size(100, 22);
            this.txtidphanhoi.TabIndex = 3;
            this.txtidphanhoi.TextChanged += new System.EventHandler(this.txtidphanhoi_TextChanged);
            // 
            // ngay
            // 
            this.ngay.AutoSize = true;
            this.ngay.Location = new System.Drawing.Point(349, 40);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(97, 16);
            this.ngay.TabIndex = 4;
            this.ngay.Text = "Ngày phản hồi:";
            this.ngay.Click += new System.EventHandler(this.txtngayphanhoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtngayphanhoi);
            this.groupBox1.Controls.Add(this.txtnoidungphanhoi);
            this.groupBox1.Controls.Add(this.txtidkhachhang);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ngay);
            this.groupBox1.Controls.Add(this.gg);
            this.groupBox1.Controls.Add(this.txtidphanhoi);
            this.groupBox1.Controls.Add(this.ds);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(23, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Location = new System.Drawing.Point(73, 96);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(95, 16);
            this.ds.TabIndex = 7;
            this.ds.Text = "ID khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID phản hồi:";
            // 
            // gg
            // 
            this.gg.AutoSize = true;
            this.gg.Location = new System.Drawing.Point(328, 87);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(118, 16);
            this.gg.TabIndex = 9;
            this.gg.Text = "Nội dung phản hồi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(511, 261);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(184, 22);
            this.txttimkiem.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtidkhachhang
            // 
            this.txtidkhachhang.Location = new System.Drawing.Point(174, 87);
            this.txtidkhachhang.Name = "txtidkhachhang";
            this.txtidkhachhang.Size = new System.Drawing.Size(100, 22);
            this.txtidkhachhang.TabIndex = 11;
            this.txtidkhachhang.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtnoidungphanhoi
            // 
            this.txtnoidungphanhoi.Location = new System.Drawing.Point(470, 87);
            this.txtnoidungphanhoi.Multiline = true;
            this.txtnoidungphanhoi.Name = "txtnoidungphanhoi";
            this.txtnoidungphanhoi.Size = new System.Drawing.Size(219, 84);
            this.txtnoidungphanhoi.TabIndex = 12;
            // 
            // txtngayphanhoi
            // 
            this.txtngayphanhoi.Location = new System.Drawing.Point(470, 34);
            this.txtngayphanhoi.Name = "txtngayphanhoi";
            this.txtngayphanhoi.Size = new System.Drawing.Size(219, 22);
            this.txtngayphanhoi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phản Hồi Khách Hàng ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtidphanhoi;
        private System.Windows.Forms.Label ngay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtngayphanhoi;
        private System.Windows.Forms.TextBox txtnoidungphanhoi;
        private System.Windows.Forms.TextBox txtidkhachhang;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}



namespace MaHoaRSA
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
            this.btTaoKhoaMoi = new System.Windows.Forms.Button();
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuongDanTep = new System.Windows.Forms.TextBox();
            this.btTimTep = new System.Windows.Forms.Button();
            this.btTimKhoa = new System.Windows.Forms.Button();
            this.tbDuongDanKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTaoKhoaMoi
            // 
            this.btTaoKhoaMoi.Location = new System.Drawing.Point(289, 12);
            this.btTaoKhoaMoi.Name = "btTaoKhoaMoi";
            this.btTaoKhoaMoi.Size = new System.Drawing.Size(140, 23);
            this.btTaoKhoaMoi.TabIndex = 0;
            this.btTaoKhoaMoi.Text = "Tạo khóa mới";
            this.btTaoKhoaMoi.UseVisualStyleBackColor = true;
            this.btTaoKhoaMoi.Click += new System.EventHandler(this.btTaoKhoaMoi_Click);
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(12, 15);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(61, 17);
            this.rbMaHoa.TabIndex = 1;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged);
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(90, 15);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(60, 17);
            this.rbGiaiMa.TabIndex = 2;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn tệp tin";
            // 
            // tbDuongDanTep
            // 
            this.tbDuongDanTep.Location = new System.Drawing.Point(12, 56);
            this.tbDuongDanTep.Name = "tbDuongDanTep";
            this.tbDuongDanTep.ReadOnly = true;
            this.tbDuongDanTep.Size = new System.Drawing.Size(336, 20);
            this.tbDuongDanTep.TabIndex = 4;
            // 
            // btTimTep
            // 
            this.btTimTep.Location = new System.Drawing.Point(354, 54);
            this.btTimTep.Name = "btTimTep";
            this.btTimTep.Size = new System.Drawing.Size(75, 23);
            this.btTimTep.TabIndex = 5;
            this.btTimTep.Text = "Tìm";
            this.btTimTep.UseVisualStyleBackColor = true;
            this.btTimTep.Click += new System.EventHandler(this.btTimTep_Click);
            // 
            // btTimKhoa
            // 
            this.btTimKhoa.Location = new System.Drawing.Point(353, 94);
            this.btTimKhoa.Name = "btTimKhoa";
            this.btTimKhoa.Size = new System.Drawing.Size(75, 23);
            this.btTimKhoa.TabIndex = 8;
            this.btTimKhoa.Text = "Tìm";
            this.btTimKhoa.UseVisualStyleBackColor = true;
            this.btTimKhoa.Click += new System.EventHandler(this.btTimKhoa_Click);
            // 
            // tbDuongDanKhoa
            // 
            this.tbDuongDanKhoa.Location = new System.Drawing.Point(11, 96);
            this.tbDuongDanKhoa.Name = "tbDuongDanKhoa";
            this.tbDuongDanKhoa.ReadOnly = true;
            this.tbDuongDanKhoa.Size = new System.Drawing.Size(336, 20);
            this.tbDuongDanKhoa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn khóa";
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(15, 122);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(75, 23);
            this.btThucHien.TabIndex = 9;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 160);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.btTimKhoa);
            this.Controls.Add(this.tbDuongDanKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTimTep);
            this.Controls.Add(this.tbDuongDanTep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbGiaiMa);
            this.Controls.Add(this.rbMaHoa);
            this.Controls.Add(this.btTaoKhoaMoi);
            this.Name = "Form1";
            this.Text = "Mã hóa RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTaoKhoaMoi;
        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuongDanTep;
        private System.Windows.Forms.Button btTimTep;
        private System.Windows.Forms.Button btTimKhoa;
        private System.Windows.Forms.TextBox tbDuongDanKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThucHien;
    }
}


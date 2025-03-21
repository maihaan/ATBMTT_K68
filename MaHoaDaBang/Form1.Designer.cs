
namespace MaHoaDaBang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuLieuCanMaHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKetQuaMaHoa = new System.Windows.Forms.TextBox();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.tbKetQuaGiaiMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDuLieuCanMaHoa
            // 
            this.tbDuLieuCanMaHoa.Location = new System.Drawing.Point(13, 26);
            this.tbDuLieuCanMaHoa.Multiline = true;
            this.tbDuLieuCanMaHoa.Name = "tbDuLieuCanMaHoa";
            this.tbDuLieuCanMaHoa.Size = new System.Drawing.Size(429, 61);
            this.tbDuLieuCanMaHoa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(13, 111);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(240, 20);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMatKhau_KeyDown);
            // 
            // btMaHoa
            // 
            this.btMaHoa.Image = global::MaHoaDaBang.Properties.Resources.lock20;
            this.btMaHoa.Location = new System.Drawing.Point(13, 138);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(82, 27);
            this.btMaHoa.TabIndex = 2;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kết quả mã hóa";
            // 
            // tbKetQuaMaHoa
            // 
            this.tbKetQuaMaHoa.Location = new System.Drawing.Point(12, 195);
            this.tbKetQuaMaHoa.Multiline = true;
            this.tbKetQuaMaHoa.Name = "tbKetQuaMaHoa";
            this.tbKetQuaMaHoa.ReadOnly = true;
            this.tbKetQuaMaHoa.Size = new System.Drawing.Size(429, 61);
            this.tbKetQuaMaHoa.TabIndex = 3;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(15, 263);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 4;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // tbKetQuaGiaiMa
            // 
            this.tbKetQuaGiaiMa.Location = new System.Drawing.Point(12, 317);
            this.tbKetQuaGiaiMa.Multiline = true;
            this.tbKetQuaGiaiMa.Name = "tbKetQuaGiaiMa";
            this.tbKetQuaGiaiMa.ReadOnly = true;
            this.tbKetQuaGiaiMa.Size = new System.Drawing.Size(429, 61);
            this.tbKetQuaGiaiMa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kết quả giải mã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 390);
            this.Controls.Add(this.tbKetQuaGiaiMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.tbKetQuaMaHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDuLieuCanMaHoa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mã hóa đa bảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuLieuCanMaHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKetQuaMaHoa;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.TextBox tbKetQuaGiaiMa;
        private System.Windows.Forms.Label label4;
    }
}


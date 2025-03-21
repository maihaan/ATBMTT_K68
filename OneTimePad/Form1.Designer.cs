
namespace OneTimePad
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
            this.tbKetQuaGiaiMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.tbKetQuaMaHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.tbDuLieuCanMaHoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKetQuaGiaiMa
            // 
            this.tbKetQuaGiaiMa.Location = new System.Drawing.Point(11, 272);
            this.tbKetQuaGiaiMa.Multiline = true;
            this.tbKetQuaGiaiMa.Name = "tbKetQuaGiaiMa";
            this.tbKetQuaGiaiMa.ReadOnly = true;
            this.tbKetQuaGiaiMa.Size = new System.Drawing.Size(429, 61);
            this.tbKetQuaGiaiMa.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kết quả giải mã";
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(14, 218);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 19;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // tbKetQuaMaHoa
            // 
            this.tbKetQuaMaHoa.Location = new System.Drawing.Point(11, 150);
            this.tbKetQuaMaHoa.Multiline = true;
            this.tbKetQuaMaHoa.Name = "tbKetQuaMaHoa";
            this.tbKetQuaMaHoa.ReadOnly = true;
            this.tbKetQuaMaHoa.Size = new System.Drawing.Size(429, 61);
            this.tbKetQuaMaHoa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kết quả mã hóa";
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(12, 93);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(82, 27);
            this.btMaHoa.TabIndex = 17;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // tbDuLieuCanMaHoa
            // 
            this.tbDuLieuCanMaHoa.Location = new System.Drawing.Point(13, 26);
            this.tbDuLieuCanMaHoa.Multiline = true;
            this.tbDuLieuCanMaHoa.Name = "tbDuLieuCanMaHoa";
            this.tbDuLieuCanMaHoa.Size = new System.Drawing.Size(429, 61);
            this.tbDuLieuCanMaHoa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 348);
            this.Controls.Add(this.tbKetQuaGiaiMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.tbKetQuaMaHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.tbDuLieuCanMaHoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKetQuaGiaiMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.TextBox tbKetQuaMaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.TextBox tbDuLieuCanMaHoa;
        private System.Windows.Forms.Label label1;
    }
}


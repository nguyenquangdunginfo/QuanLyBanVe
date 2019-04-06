namespace AirTicketBookingManagement
{
    partial class frm_DoanhThuThang
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
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.bnt_baocao = new System.Windows.Forms.Button();
            this.bnt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BÁO CÁO DOANH THU THÁNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cb_thang.Location = new System.Drawing.Point(92, 70);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(83, 24);
            this.cb_thang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.cb_nam.Location = new System.Drawing.Point(277, 70);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(77, 24);
            this.cb_nam.TabIndex = 4;
            // 
            // bnt_baocao
            // 
            this.bnt_baocao.Location = new System.Drawing.Point(19, 139);
            this.bnt_baocao.Name = "bnt_baocao";
            this.bnt_baocao.Size = new System.Drawing.Size(118, 23);
            this.bnt_baocao.TabIndex = 5;
            this.bnt_baocao.Text = "Báo Cáo";
            this.bnt_baocao.UseVisualStyleBackColor = true;
            // 
            // bnt_thoat
            // 
            this.bnt_thoat.Location = new System.Drawing.Point(246, 139);
            this.bnt_thoat.Name = "bnt_thoat";
            this.bnt_thoat.Size = new System.Drawing.Size(106, 23);
            this.bnt_thoat.TabIndex = 6;
            this.bnt_thoat.Text = "Thoát";
            this.bnt_thoat.UseVisualStyleBackColor = true;
            this.bnt_thoat.Click += new System.EventHandler(this.bnt_thoat_Click);
            // 
            // frm_DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(379, 194);
            this.Controls.Add(this.bnt_thoat);
            this.Controls.Add(this.bnt_baocao);
            this.Controls.Add(this.cb_nam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DoanhThuThang";
            this.Text = "BC Doanh Thu Tháng";
            this.Load += new System.EventHandler(this.frm_BaoCaoDoanhThuThang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Button bnt_baocao;
        private System.Windows.Forms.Button bnt_thoat;
    }
}


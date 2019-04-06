namespace BCDoanhThuNam
{
    partial class frm_DoanhThuNam
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
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.bnt_1 = new System.Windows.Forms.Button();
            this.bnt_2 = new System.Windows.Forms.Button();
           // this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU NĂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // cb_1
            // 
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cb_1.Location = new System.Drawing.Point(131, 71);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(121, 24);
            this.cb_1.TabIndex = 2;
            // 
            // bnt_1
            // 
            this.bnt_1.Location = new System.Drawing.Point(31, 133);
            this.bnt_1.Name = "bnt_1";
            this.bnt_1.Size = new System.Drawing.Size(75, 23);
            this.bnt_1.TabIndex = 3;
            this.bnt_1.Text = "Báo Cáo";
            this.bnt_1.UseVisualStyleBackColor = true;
            // 
            // bnt_2
            // 
            this.bnt_2.Location = new System.Drawing.Point(277, 133);
            this.bnt_2.Name = "bnt_2";
            this.bnt_2.Size = new System.Drawing.Size(75, 23);
            this.bnt_2.TabIndex = 4;
            this.bnt_2.Text = "Thoát";
            this.bnt_2.UseVisualStyleBackColor = true;
            this.bnt_2.Click += new System.EventHandler(this.bnt_2_Click);
            // 
            // reportViewer1
            // 
              // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 324);
         //   this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bnt_2);
            this.Controls.Add(this.bnt_1);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.Button bnt_1;
        private System.Windows.Forms.Button bnt_2;
      //  private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}


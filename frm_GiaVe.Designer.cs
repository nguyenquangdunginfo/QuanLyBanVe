﻿namespace QuanLyBanVeMayBay
{
    partial class frm_GiaVe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_chuyenbay = new System.Windows.Forms.ComboBox();
            this.cb_hangve = new System.Windows.Forms.ComboBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-13, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.cb_chuyenbay);
            this.groupBox1.Controls.Add(this.cb_hangve);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(391, 20);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(98, 30);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cb_chuyenbay
            // 
            this.cb_chuyenbay.FormattingEnabled = true;
            this.cb_chuyenbay.Location = new System.Drawing.Point(115, 35);
            this.cb_chuyenbay.Name = "cb_chuyenbay";
            this.cb_chuyenbay.Size = new System.Drawing.Size(189, 21);
            this.cb_chuyenbay.TabIndex = 7;
            // 
            // cb_hangve
            // 
            this.cb_hangve.FormattingEnabled = true;
            this.cb_hangve.Location = new System.Drawing.Point(115, 66);
            this.cb_hangve.Name = "cb_hangve";
            this.cb_hangve.Size = new System.Drawing.Size(189, 21);
            this.cb_hangve.TabIndex = 6;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(115, 98);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(189, 20);
            this.txtgia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hạng vé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyến bay :";
            // 
            // frm_GiaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_GiaVe";
            this.Text = "Quản lý giá";
            this.Load += new System.EventHandler(this.frm_quanlygia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_chuyenbay;
        private System.Windows.Forms.ComboBox cb_hangve;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
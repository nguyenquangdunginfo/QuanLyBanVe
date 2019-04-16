namespace ThayDoiQD2
{
    partial class frm_ThayDoiQD2
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Bản Đơn Giá Vé");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.listView_1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnt_1 = new System.Windows.Forms.Button();
            this.bnt_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUY ĐINH HẠNG VÉ_ĐƠN ĐẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Lượng Các Hạng Vé";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(229, 67);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(120, 22);
            this.txt_1.TabIndex = 2;
            // 
            // listView_1
            // 
            this.listView_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_1.Location = new System.Drawing.Point(38, 134);
            this.listView_1.Name = "listView_1";
            this.listView_1.Size = new System.Drawing.Size(311, 120);
            this.listView_1.TabIndex = 3;
            this.listView_1.UseCompatibleStateImageBehavior = false;
            this.listView_1.UseWaitCursor = true;
            this.listView_1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sân Bay";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sân Bay";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hạng Vé";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            // 
            // bnt_1
            // 
            this.bnt_1.Location = new System.Drawing.Point(38, 286);
            this.bnt_1.Name = "bnt_1";
            this.bnt_1.Size = new System.Drawing.Size(75, 23);
            this.bnt_1.TabIndex = 4;
            this.bnt_1.Text = "Cập Nhật";
            this.bnt_1.UseVisualStyleBackColor = true;
            // 
            // bnt_2
            // 
            this.bnt_2.Location = new System.Drawing.Point(274, 286);
            this.bnt_2.Name = "bnt_2";
            this.bnt_2.Size = new System.Drawing.Size(75, 23);
            this.bnt_2.TabIndex = 5;
            this.bnt_2.Text = "Thoát";
            this.bnt_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.bnt_2);
            this.Controls.Add(this.bnt_1);
            this.Controls.Add(this.listView_1);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.ListView listView_1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button bnt_1;
        private System.Windows.Forms.Button bnt_2;
    }
}


namespace QuanLyBanVeMayBay
{
    partial class frm_XuatBaocao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanlybanveDataSet = new QuanLyBanVeMayBay.QuanlybanveDataSet();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new QuanLyBanVeMayBay.QuanlybanveDataSetTableAdapters.HOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCaoBanVe";
            reportDataSource1.Value = this.HOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanVeMayBay.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(598, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanlybanveDataSet
            // 
            this.QuanlybanveDataSet.DataSetName = "QuanlybanveDataSet";
            this.QuanlybanveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QuanlybanveDataSet;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // frm_XuatBaoco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 391);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_XuatBaoco";
            this.Text = "Xuất báo cáo";
            this.Load += new System.EventHandler(this.frm_XuatBaoco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QuanlybanveDataSet QuanlybanveDataSet;
        private QuanlybanveDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
    }
}
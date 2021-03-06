namespace QLCuaHangVLDX.report
{
    partial class F_vatLieu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetVatLieu = new QLCuaHangVLDX.report.DataSetVatLieu();
            this.USP_nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetgetNguoiDung = new QLCuaHangVLDX.report.DataSetgetNguoiDung();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vatLieuTableAdapter = new QLCuaHangVLDX.report.DataSetVatLieuTableAdapters.vatLieuTableAdapter();
            this.USP_nhanVienTableAdapter = new QLCuaHangVLDX.report.DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vatLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVatLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetgetNguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vatLieuBindingSource
            // 
            this.vatLieuBindingSource.DataMember = "vatLieu";
            this.vatLieuBindingSource.DataSource = this.DataSetVatLieu;
            // 
            // DataSetVatLieu
            // 
            this.DataSetVatLieu.DataSetName = "DataSetVatLieu";
            this.DataSetVatLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_nhanVienBindingSource
            // 
            this.USP_nhanVienBindingSource.DataMember = "USP_nhanVien";
            this.USP_nhanVienBindingSource.DataSource = this.DataSetgetNguoiDung;
            // 
            // DataSetgetNguoiDung
            // 
            this.DataSetgetNguoiDung.DataSetName = "DataSetgetNguoiDung";
            this.DataSetgetNguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(674, 651);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_vatLieu";
            reportDataSource1.Value = this.vatLieuBindingSource;
            reportDataSource2.Name = "DataSet_VL2";
            reportDataSource2.Value = this.USP_nhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangVLDX.report.RP_vatLieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // vatLieuTableAdapter
            // 
            this.vatLieuTableAdapter.ClearBeforeFill = true;
            // 
            // USP_nhanVienTableAdapter
            // 
            this.USP_nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // F_vatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.panel1);
            this.Name = "F_vatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tồn kho";
            this.Load += new System.EventHandler(this.F_vatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vatLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVatLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetgetNguoiDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vatLieuBindingSource;
        private DataSetVatLieu DataSetVatLieu;
        private System.Windows.Forms.BindingSource USP_nhanVienBindingSource;
        private DataSetgetNguoiDung DataSetgetNguoiDung;
        private DataSetVatLieuTableAdapters.vatLieuTableAdapter vatLieuTableAdapter;
        private DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter USP_nhanVienTableAdapter;
    }
}
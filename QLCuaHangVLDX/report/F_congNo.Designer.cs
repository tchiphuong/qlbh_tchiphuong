namespace QLCuaHangVLDX.report
{
    partial class F_congNo
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
            this.View_congNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCongNo = new QLCuaHangVLDX.report.DataSetCongNo();
            this.USP_nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetgetNguoiDung = new QLCuaHangVLDX.report.DataSetgetNguoiDung();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_congNoTableAdapter = new QLCuaHangVLDX.report.DataSetCongNoTableAdapters.View_congNoTableAdapter();
            this.USP_nhanVienTableAdapter = new QLCuaHangVLDX.report.DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_congNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetgetNguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_congNoBindingSource
            // 
            this.View_congNoBindingSource.DataMember = "View_congNo";
            this.View_congNoBindingSource.DataSource = this.DataSetCongNo;
            // 
            // DataSetCongNo
            // 
            this.DataSetCongNo.DataSetName = "DataSetCongNo";
            this.DataSetCongNo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            reportDataSource1.Name = "DataSet_congNo";
            reportDataSource1.Value = this.View_congNoBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.USP_nhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangVLDX.report.RP_congNo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_congNoTableAdapter
            // 
            this.View_congNoTableAdapter.ClearBeforeFill = true;
            // 
            // USP_nhanVienTableAdapter
            // 
            this.USP_nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // F_congNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.panel1);
            this.Name = "F_congNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê công nợ";
            this.Load += new System.EventHandler(this.F_congNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_congNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetgetNguoiDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_congNoBindingSource;
        private DataSetCongNo DataSetCongNo;
        private System.Windows.Forms.BindingSource USP_nhanVienBindingSource;
        private DataSetgetNguoiDung DataSetgetNguoiDung;
        private DataSetCongNoTableAdapters.View_congNoTableAdapter View_congNoTableAdapter;
        private DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter USP_nhanVienTableAdapter;
    }
}
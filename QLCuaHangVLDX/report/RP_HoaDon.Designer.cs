namespace QLCuaHangVLDX.report
{
    partial class RP_HoaDon
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
            this.DataTableHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetHoaDon = new QLCuaHangVLDX.report.DataSetHoaDon();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableHoaDonTableAdapter = new QLCuaHangVLDX.report.DataSetHoaDonTableAdapters.DataTableHoaDonTableAdapter();
            this.dataSetHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSetTongTien = new QLCuaHangVLDX.DataSetTongTien();
            this.uSPtongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_tongTienTableAdapter = new QLCuaHangVLDX.DataSetTongTienTableAdapters.USP_tongTienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDonBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPtongTienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableHoaDonBindingSource
            // 
            this.DataTableHoaDonBindingSource.DataMember = "DataTableHoaDon";
            this.DataTableHoaDonBindingSource.DataSource = this.DataSetHoaDon;
            // 
            // DataSetHoaDon
            // 
            this.DataSetHoaDon.DataSetName = "DataSetHoaDon";
            this.DataSetHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "inHoaDon";
            reportDataSource1.Value = this.DataTableHoaDonBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPtongTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangVLDX.report.RP_HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(634, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableHoaDonTableAdapter
            // 
            this.DataTableHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetHoaDonBindingSource
            // 
            this.dataSetHoaDonBindingSource.DataSource = this.DataSetHoaDon;
            this.dataSetHoaDonBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(674, 651);
            this.panel1.TabIndex = 1;
            // 
            // dataSetTongTien
            // 
            this.dataSetTongTien.DataSetName = "DataSetTongTien";
            this.dataSetTongTien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPtongTienBindingSource
            // 
            this.uSPtongTienBindingSource.DataMember = "USP_tongTien";
            this.uSPtongTienBindingSource.DataSource = this.dataSetTongTien;
            // 
            // uSP_tongTienTableAdapter
            // 
            this.uSP_tongTienTableAdapter.ClearBeforeFill = true;
            // 
            // RP_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDonBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPtongTienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableHoaDonBindingSource;
        private DataSetHoaDon DataSetHoaDon;
        private DataSetHoaDonTableAdapters.DataTableHoaDonTableAdapter DataTableHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource dataSetHoaDonBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource uSPtongTienBindingSource;
        private DataSetTongTien dataSetTongTien;
        private DataSetTongTienTableAdapters.USP_tongTienTableAdapter uSP_tongTienTableAdapter;
    }
}
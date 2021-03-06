namespace QLCuaHangVLDX.report
{
    partial class RP_doanhThu
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
            this.uSPnhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetgetNguoiDung = new QLCuaHangVLDX.report.DataSetgetNguoiDung();
            this.uSPdoanhThuBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDoanhThu = new QLCuaHangVLDX.report.DataSetDoanhThu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uSP_nhanVienTableAdapter = new QLCuaHangVLDX.report.DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter();
            this.uSP_doanhThuBanHangTableAdapter = new QLCuaHangVLDX.report.DataSetDoanhThuTableAdapters.USP_doanhThuBanHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPnhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetgetNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPdoanhThuBanHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uSPnhanVienBindingSource
            // 
            this.uSPnhanVienBindingSource.DataMember = "USP_nhanVien";
            this.uSPnhanVienBindingSource.DataSource = this.dataSetgetNguoiDung;
            // 
            // dataSetgetNguoiDung
            // 
            this.dataSetgetNguoiDung.DataSetName = "DataSetgetNguoiDung";
            this.dataSetgetNguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPdoanhThuBanHangBindingSource
            // 
            this.uSPdoanhThuBanHangBindingSource.DataMember = "USP_doanhThuBanHang";
            this.uSPdoanhThuBanHangBindingSource.DataSource = this.dataSetDoanhThu;
            // 
            // dataSetDoanhThu
            // 
            this.dataSetDoanhThu.DataSetName = "DataSetDoanhThu";
            this.dataSetDoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(674, 48);
            this.panel1.TabIndex = 0;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "\'ngày\' dd \'tháng\' MM \'năm\' yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(289, 12);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 24);
            this.dateTo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "đến";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "\'ngày\' dd \'tháng\' MM \'năm\' yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(45, 12);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 24);
            this.dateFrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(508, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tạo báo cáo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNhanVien";
            reportDataSource1.Value = this.uSPnhanVienBindingSource;
            reportDataSource2.Name = "DataSet_doanhthuBan";
            reportDataSource2.Value = this.uSPdoanhThuBanHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangVLDX.report.RP_doanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 563);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(674, 603);
            this.panel2.TabIndex = 1;
            // 
            // uSP_nhanVienTableAdapter
            // 
            this.uSP_nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // uSP_doanhThuBanHangTableAdapter
            // 
            this.uSP_doanhThuBanHangTableAdapter.ClearBeforeFill = true;
            // 
            // RP_doanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP_doanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu bán hàng";
            this.Load += new System.EventHandler(this.RP_doanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPnhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetgetNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPdoanhThuBanHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource uSPnhanVienBindingSource;
        private DataSetgetNguoiDung dataSetgetNguoiDung;
        private System.Windows.Forms.BindingSource uSPdoanhThuBanHangBindingSource;
        private DataSetDoanhThu dataSetDoanhThu;
        private DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter uSP_nhanVienTableAdapter;
        private DataSetDoanhThuTableAdapters.USP_doanhThuBanHangTableAdapter uSP_doanhThuBanHangTableAdapter;
    }
}
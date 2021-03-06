namespace QLCuaHangVLDX.report
{
    partial class F_xuatHang
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
            this.USP_xuatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetXuatHang = new QLCuaHangVLDX.report.DataSetXuatHang();
            this.USP_nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetgetNguoiDung = new QLCuaHangVLDX.report.DataSetgetNguoiDung();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_xuatHangTableAdapter = new QLCuaHangVLDX.report.DataSetXuatHangTableAdapters.USP_xuatHangTableAdapter();
            this.USP_nhanVienTableAdapter = new QLCuaHangVLDX.report.DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_xuatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetgetNguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_xuatHangBindingSource
            // 
            this.USP_xuatHangBindingSource.DataMember = "USP_xuatHang";
            this.USP_xuatHangBindingSource.DataSource = this.DataSetXuatHang;
            // 
            // DataSetXuatHang
            // 
            this.DataSetXuatHang.DataSetName = "DataSetXuatHang";
            this.DataSetXuatHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(519, 13);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 24);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Tạo báo cáo";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "\'ngày\' dd \'tháng\' MM \'năm\' yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(297, 12);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 24);
            this.dateTo.TabIndex = 8;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "\'ngày\' dd \'tháng\' MM \'năm\' yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(53, 12);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 24);
            this.dateFrom.TabIndex = 7;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(674, 602);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_xuatHang";
            reportDataSource1.Value = this.USP_xuatHangBindingSource;
            reportDataSource2.Name = "DataSet_nd";
            reportDataSource2.Value = this.USP_nhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangVLDX.report.ReportXuatHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(634, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_xuatHangTableAdapter
            // 
            this.USP_xuatHangTableAdapter.ClearBeforeFill = true;
            // 
            // USP_nhanVienTableAdapter
            // 
            this.USP_nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // F_xuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_xuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê xuất hàng";
            this.Load += new System.EventHandler(this.F_xuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_xuatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetgetNguoiDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_xuatHangBindingSource;
        private DataSetXuatHang DataSetXuatHang;
        private System.Windows.Forms.BindingSource USP_nhanVienBindingSource;
        private DataSetgetNguoiDung DataSetgetNguoiDung;
        private DataSetXuatHangTableAdapters.USP_xuatHangTableAdapter USP_xuatHangTableAdapter;
        private DataSetgetNguoiDungTableAdapters.USP_nhanVienTableAdapter USP_nhanVienTableAdapter;
    }
}
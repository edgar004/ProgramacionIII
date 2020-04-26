namespace InventarioNew
{
    partial class reporteDepartamentos
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
            this.DepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteDepartamentosDataSet1 = new InventarioNew.ReporteDepartamentosDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DepartamentosTableAdapter = new InventarioNew.ReporteDepartamentosDataSet1TableAdapters.DepartamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDepartamentosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartamentosBindingSource
            // 
            this.DepartamentosBindingSource.DataMember = "Departamentos";
            this.DepartamentosBindingSource.DataSource = this.ReporteDepartamentosDataSet1;
            // 
            // ReporteDepartamentosDataSet1
            // 
            this.ReporteDepartamentosDataSet1.DataSetName = "ReporteDepartamentosDataSet1";
            this.ReporteDepartamentosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDepartamento";
            reportDataSource1.Value = this.DepartamentosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventarioNew.informeDepartamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DepartamentosTableAdapter
            // 
            this.DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // reporteDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteDepartamentos";
            this.Text = "reporteDepartamentos";
            this.Load += new System.EventHandler(this.reporteDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDepartamentosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DepartamentosBindingSource;
        private ReporteDepartamentosDataSet1 ReporteDepartamentosDataSet1;
        private ReporteDepartamentosDataSet1TableAdapters.DepartamentosTableAdapter DepartamentosTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
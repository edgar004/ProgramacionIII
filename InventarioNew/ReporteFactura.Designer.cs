namespace InventarioNew
{
    partial class ReporteFactura
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
            this.DatasetDatosFactura = new InventarioNew.DatasetDatosFactura();
            this.DatosFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosFacturaTableAdapter = new InventarioNew.DatasetDatosFacturaTableAdapters.DatosFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetDatosFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatasetFactura";
            reportDataSource1.Value = this.DatosFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventarioNew.InformeFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetDatosFactura
            // 
            this.DatasetDatosFactura.DataSetName = "DatasetDatosFactura";
            this.DatasetDatosFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosFacturaBindingSource
            // 
            this.DatosFacturaBindingSource.DataMember = "DatosFactura";
            this.DatosFacturaBindingSource.DataSource = this.DatasetDatosFactura;
            // 
            // DatosFacturaTableAdapter
            // 
            this.DatosFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura";
            this.Text = "ReporteFactura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetDatosFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DatosFacturaBindingSource;
        private DatasetDatosFactura DatasetDatosFactura;
        private DatasetDatosFacturaTableAdapters.DatosFacturaTableAdapter DatosFacturaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
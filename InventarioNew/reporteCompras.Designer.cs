﻿namespace InventarioNew
{
    partial class reporteCompras
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
            this.ComprasDataSet = new InventarioNew.ComprasDataSet();
            this.DatosComprarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosComprarTableAdapter = new InventarioNew.ComprasDataSetTableAdapters.DatosComprarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosComprarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCompras";
            reportDataSource1.Value = this.DatosComprarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventarioNew.informeCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ComprasDataSet
            // 
            this.ComprasDataSet.DataSetName = "ComprasDataSet";
            this.ComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosComprarBindingSource
            // 
            this.DatosComprarBindingSource.DataMember = "DatosComprar";
            this.DatosComprarBindingSource.DataSource = this.ComprasDataSet;
            // 
            // DatosComprarTableAdapter
            // 
            this.DatosComprarTableAdapter.ClearBeforeFill = true;
            // 
            // reporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteCompras";
            this.Text = "reporteCompras";
            this.Load += new System.EventHandler(this.reporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosComprarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DatosComprarBindingSource;
        private ComprasDataSet ComprasDataSet;
        private ComprasDataSetTableAdapters.DatosComprarTableAdapter DatosComprarTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
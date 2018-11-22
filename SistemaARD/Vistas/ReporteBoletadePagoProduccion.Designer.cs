namespace SistemaARD
{
    partial class ReporteBoletadePagoProduccion
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
            this.losnacimientosDataSet = new SistemaARD.losnacimientosDataSet();
            this.reporte_planillaproduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_planillaproduccionTableAdapter = new SistemaARD.losnacimientosDataSetTableAdapters.reporte_planillaproduccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_planillaproduccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetBoletadePagoProduccion";
            reportDataSource1.Value = this.reporte_planillaproduccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaARD.Reportes.BoletadePagoProduccion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // losnacimientosDataSet
            // 
            this.losnacimientosDataSet.DataSetName = "losnacimientosDataSet";
            this.losnacimientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_planillaproduccionBindingSource
            // 
            this.reporte_planillaproduccionBindingSource.DataMember = "reporte_planillaproduccion";
            this.reporte_planillaproduccionBindingSource.DataSource = this.losnacimientosDataSet;
            // 
            // reporte_planillaproduccionTableAdapter
            // 
            this.reporte_planillaproduccionTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteBoletadePagoProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteBoletadePagoProduccion";
            this.Text = "ReporteBoletadePagoProduccion";
            this.Load += new System.EventHandler(this.ReporteBoletadePagoProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_planillaproduccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_planillaproduccionBindingSource;
        private losnacimientosDataSet losnacimientosDataSet;
        private losnacimientosDataSetTableAdapters.reporte_planillaproduccionTableAdapter reporte_planillaproduccionTableAdapter;
    }
}
namespace SistemaARD
{
    partial class ReporteIndemnizacionProduccion
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
            this.Reporte_Indemnizacion_ProduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Indemnizacion_ProduccionTableAdapter = new SistemaARD.losnacimientosDataSetTableAdapters.Reporte_Indemnizacion_ProduccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Indemnizacion_ProduccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1Indemnizacion";
            reportDataSource1.Value = this.Reporte_Indemnizacion_ProduccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaARD.Reportes.ReporteIndemnizacionProduccion.rdlc";
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
            // Reporte_Indemnizacion_ProduccionBindingSource
            // 
            this.Reporte_Indemnizacion_ProduccionBindingSource.DataMember = "Reporte_Indemnizacion_Produccion";
            this.Reporte_Indemnizacion_ProduccionBindingSource.DataSource = this.losnacimientosDataSet;
            // 
            // Reporte_Indemnizacion_ProduccionTableAdapter
            // 
            this.Reporte_Indemnizacion_ProduccionTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteIndemnizacionProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteIndemnizacionProduccion";
            this.Text = "ReporteIndemnizacionProduccion";
            this.Load += new System.EventHandler(this.ReporteIndemnizacionProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Indemnizacion_ProduccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Indemnizacion_ProduccionBindingSource;
        private losnacimientosDataSet losnacimientosDataSet;
        private losnacimientosDataSetTableAdapters.Reporte_Indemnizacion_ProduccionTableAdapter Reporte_Indemnizacion_ProduccionTableAdapter;
    }
}
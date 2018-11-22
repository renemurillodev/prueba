namespace SistemaARD
{
    partial class ReporteAguinaldoMantenimiento
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
            this.Reporte_Aguinaldo_MantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Aguinaldo_MantenimientoTableAdapter = new SistemaARD.losnacimientosDataSetTableAdapters.Reporte_Aguinaldo_MantenimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Aguinaldo_MantenimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAguinaldoMantenimiento";
            reportDataSource1.Value = this.Reporte_Aguinaldo_MantenimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaARD.Reportes.ReporteAguinaldoMantenimiento.rdlc";
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
            // Reporte_Aguinaldo_MantenimientoBindingSource
            // 
            this.Reporte_Aguinaldo_MantenimientoBindingSource.DataMember = "Reporte_Aguinaldo_Mantenimiento";
            this.Reporte_Aguinaldo_MantenimientoBindingSource.DataSource = this.losnacimientosDataSet;
            // 
            // Reporte_Aguinaldo_MantenimientoTableAdapter
            // 
            this.Reporte_Aguinaldo_MantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAguinaldoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAguinaldoMantenimiento";
            this.Text = "ReporteAguinaldoMantenimiento";
            this.Load += new System.EventHandler(this.ReporteAguinaldoMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Aguinaldo_MantenimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Aguinaldo_MantenimientoBindingSource;
        private losnacimientosDataSet losnacimientosDataSet;
        private losnacimientosDataSetTableAdapters.Reporte_Aguinaldo_MantenimientoTableAdapter Reporte_Aguinaldo_MantenimientoTableAdapter;
    }
}
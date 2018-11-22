namespace SistemaARD
{
    partial class ReporteQuincenalPlanillaVentas
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
            this.ReporteQuincenalVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.losnacimientosDataSet = new SistemaARD.losnacimientosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteQuincenalVentasTableAdapter = new SistemaARD.losnacimientosDataSetTableAdapters.ReporteQuincenalVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteQuincenalVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteQuincenalVentasBindingSource
            // 
            this.ReporteQuincenalVentasBindingSource.DataMember = "ReporteQuincenalVentas";
            this.ReporteQuincenalVentasBindingSource.DataSource = this.losnacimientosDataSet;
            // 
            // losnacimientosDataSet
            // 
            this.losnacimientosDataSet.DataSetName = "losnacimientosDataSet";
            this.losnacimientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteQuincenalVentas";
            reportDataSource1.Value = this.ReporteQuincenalVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaARD.Reportes.ReporteQuincenalPlanillaVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteQuincenalVentasTableAdapter
            // 
            this.ReporteQuincenalVentasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteQuincenalPlanillaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteQuincenalPlanillaVentas";
            this.Text = "ReporteQuincenalPlanillaVentas";
            this.Load += new System.EventHandler(this.ReporteQuincenalPlanillaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteQuincenalVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteQuincenalVentasBindingSource;
        private losnacimientosDataSet losnacimientosDataSet;
        private losnacimientosDataSetTableAdapters.ReporteQuincenalVentasTableAdapter ReporteQuincenalVentasTableAdapter;
    }
}
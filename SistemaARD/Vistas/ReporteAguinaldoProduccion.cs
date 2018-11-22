using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD
{
    public partial class ReporteAguinaldoProduccion : Form
    {
        public ReporteAguinaldoProduccion()
        {
            InitializeComponent();
        }
        private int _Año;

        public int Año
        {
            get { return _Año; }
            set { _Año = value; }
        }
        private void ReporteAguinaldoProduccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'losnacimientosDataSet.Reporte_Aguinaldo_Produccion' Puede moverla o quitarla según sea necesario.
            try
            {
                this.Reporte_Aguinaldo_ProduccionTableAdapter.Fill(this.losnacimientosDataSet.Reporte_Aguinaldo_Produccion, Año);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                this.reportViewer1.RefreshReport();
            }

            this.reportViewer1.RefreshReport();
        }
    }
}

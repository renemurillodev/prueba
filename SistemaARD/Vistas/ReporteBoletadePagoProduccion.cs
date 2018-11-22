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
    public partial class ReporteBoletadePagoProduccion : Form
    {
        public ReporteBoletadePagoProduccion()
        {
            InitializeComponent();
        }
        private int _idPlanillaVenta;

        public int idPlanillaVenta
        {
            get { return _idPlanillaVenta; }
            set { _idPlanillaVenta = value; }
        }

        private void ReporteBoletadePagoProduccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'losnacimientosDataSet.reporte_planillaproduccion' Puede moverla o quitarla según sea necesario.
            try
            {
                this.reporte_planillaproduccionTableAdapter.Fill(this.losnacimientosDataSet.reporte_planillaproduccion, idPlanillaVenta);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}

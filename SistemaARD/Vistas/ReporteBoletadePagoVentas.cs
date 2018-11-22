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
    public partial class ReporteBoletadePagoVentas : Form
    {
        public ReporteBoletadePagoVentas()
        {
            InitializeComponent();
        }
        private int _idPlanillaVenta;

        public int idPlanillaVenta
        {
            get { return _idPlanillaVenta; }
            set { _idPlanillaVenta = value; }
        }

        private void ReporteBoletadePagoVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'losnacimientosDataSet.ReporteQuincenalVentas' Puede moverla o quitarla según sea necesario.
            try
            {
                this.reporte_planillaventa1TableAdapter.Fill(this.losnacimientosDataSet.reporte_planillaventa1, idPlanillaVenta);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                this.reportViewer1.RefreshReport();
            }
            
        }
    }
}

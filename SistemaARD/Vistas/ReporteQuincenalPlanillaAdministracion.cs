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
    public partial class ReporteQuincenalPlanillaAdministracion : Form
    {
        public ReporteQuincenalPlanillaAdministracion()
        {
            InitializeComponent();
        }
        private DateTime _FechaInicio;

        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
        private DateTime _FechaFinal;

        public DateTime FechaFinal
        {
            get { return _FechaFinal; }
            set { _FechaFinal = value; }
        }
        private void ReporteQuincenalPlanillaAdministracion_Load(object sender, EventArgs e)
        {
            try
            {
                this.ReporteQuincenalAdministracionTableAdapter.Fill(this.losnacimientosDataSet.ReporteQuincenalAdministracion, FechaInicio, FechaFinal);

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

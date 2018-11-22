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
    public partial class ReporteAguinaldoAdministracion : Form
    {
        public ReporteAguinaldoAdministracion()
        {
            InitializeComponent();
        }
        private int _Año;

        public int Año
        {
            get { return _Año; }
            set { _Año = value; }
        }
                
        private void ReporteAguinaldoAdministracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'losnacimientosDataSet.Reporte_Aguinaldo_Administracion' Puede moverla o quitarla según sea necesario.
            try
            {
                this.Reporte_Aguinaldo_AdministracionTableAdapter.Fill(this.losnacimientosDataSet.Reporte_Aguinaldo_Administracion,Año);

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

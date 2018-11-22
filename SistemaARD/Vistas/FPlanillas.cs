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
    public partial class FPlanillas : Form
    {
        private PlanillasVentas planiventas = new PlanillasVentas();
        private PlanillasProduccion planiproduccion = new PlanillasProduccion();
        private Empleados empleados = new Empleados();
        string idPlanillaVentas = "";
        string idPlanillaProduccion = "";
        string idPlanillaTransporte = "";
        

        public FPlanillas()
        {
            InitializeComponent();
        }

        void CargarGrid()
        {

            dgvVentas.AutoGenerateColumns = false;
            dgvTransporte.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {

                try
                {
                    var queryventas = (from pv in db.PlanillasVentas
                                       where pv.Categoria_Id == 1
                                       || pv.Categoria_Id == 2
                                       join em in db.Empleados on pv.Empleado_Id equals em.Id
                                       join cp in db.CategoriasPlanillas on pv.Categoria_Id equals cp.Id
                                       select new
                                       {
                                           Id = pv.Id,
                                           Nombres = em.Nombres,
                                           Apellidos = em.Apellidos,
                                           Dias_laborados = pv.Dias_laborados,
                                           Horas_extra = pv.Horas_extra,
                                           Anticipos = pv.Anticipos,
                                           Fecha_Final = pv.Fecha_Final,
                                           Fecha_Inicio = pv.Fecha_Inicio,
                                           Categoria_Id = cp.Nombre
                                       }).ToList();

                    var querytransporte = (from pv in db.PlanillasVentas
                                           where pv.Categoria_Id == 3
                                           join em in db.Empleados on pv.Empleado_Id equals em.Id
                                           join cp in db.CategoriasPlanillas on pv.Categoria_Id equals cp.Id
                                           select new
                                           {
                                               Id = pv.Id,
                                               Nombres = em.Nombres,
                                               Apellidos = em.Apellidos,
                                               Dias_laborados = pv.Dias_laborados,
                                               Horas_extra = pv.Horas_extra,
                                               Anticipos = pv.Anticipos,
                                               Fecha_Final = pv.Fecha_Final,
                                               Fecha_Inicio = pv.Fecha_Inicio,
                                               Categoria_Id = cp.Nombre
                                           }).ToList();

                    var querymantenimiento = (from pv in db.PlanillasVentas
                                              where pv.Categoria_Id == 3
                                              join em in db.Empleados on pv.Empleado_Id equals em.Id
                                              join cp in db.CategoriasPlanillas on pv.Categoria_Id equals cp.Id
                                              select new
                                              {
                                                  Id = pv.Id,
                                                  Nombres = em.Nombres,
                                                  Apellidos = em.Apellidos,
                                                  Dias_laborados = pv.Dias_laborados,
                                                  Horas_extra = pv.Horas_extra,
                                                  Anticipos = pv.Anticipos,
                                                  Fecha_Final = pv.Fecha_Final,
                                                  Fecha_Inicio = pv.Fecha_Inicio,
                                                  Categoria_Id = cp.Nombre
                                              }).ToList();

                    var queryproduccion = (from pv in db.PlanillasProduccion
                                           where pv.Categoria_Id == 4
                                           join em in db.Empleados on pv.Empleado_Id equals em.Id
                                           join cp in db.CategoriasPlanillas on pv.Categoria_Id equals cp.Id
                                           select new
                                           {
                                               Id = pv.Id,
                                               Nombres = em.Nombres,
                                               Apellidos = em.Apellidos,
                                               Horas_laboradas = pv.Horas_laboradas,
                                               Horas_extras = pv.Horas_extras,
                                               Anticipos = pv.Anticipos,
                                               Fecha_Final = pv.Fecha_Final,
                                               Fecha_Inicio = pv.Fecha_Inicio,
                                               Categoria_Id = cp.Nombre
                                           }).ToList();

                    var queryadmon = (from pv in db.Planillas_Jefes
                                      where pv.Categoria_Id == 5
                                      join em in db.Empleados on pv.Empleado_Id equals em.Id
                                      join cp in db.CategoriasPlanillas on pv.Categoria_Id equals cp.Id
                                      select new
                                      {
                                          Id = pv.Id,
                                          Nombres = em.Nombres,
                                          Apellidos = em.Apellidos,
                                          Anticipos = pv.Anticipos,
                                          Fecha_Final = pv.Fecha_Final,
                                          Fecha_Inicio = pv.Fecha_Inicio,
                                          Salario_quincenal = pv.Salario_quincenal,
                                          Categoria_Id = cp.Nombre
                                      }).ToList();

                    dgvVentas.DataSource = queryventas;
                    dgvTransporte.DataSource = querytransporte;
                    
                    dgvProduccion.DataSource = queryproduccion;
                    dgvAdministracion.DataSource = queryadmon;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de Conexion a la base de datos");
                }

            }
        }

        private void FPlanillas_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvVentas.CurrentRow.Index != -1)
                {
                    idPlanillaVentas = Convert.ToString(dgvVentas.CurrentRow.Cells["Id"].Value);
                    btnGenerarReporteVentas.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registros vacío");
            }
        }

        private void btnGenerarReporteVentas_Click(object sender, EventArgs e)
        {
            ReporteBoletadePagoVentas frmreportes = new ReporteBoletadePagoVentas();
            if (dgvVentas.CurrentRow.Index != -1)
            {
                frmreportes.idPlanillaVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["Id"].Value);
                frmreportes.ShowDialog();
            }
        }

        private void btnReporteMensualVentas_Click(object sender, EventArgs e)
        {
            ReporteQuincenalPlanillaVentas formrepoquinceventa = new ReporteQuincenalPlanillaVentas();
            formrepoquinceventa.FechaInicio = dtpfecha_inicio_reportemensual_ventas.Value.Date;
            formrepoquinceventa.FechaFinal = dtpfecha_final_reportemensual_ventas.Value.Date;
            formrepoquinceventa.ShowDialog();
        }

        private void btnGenerarReporteProduccion_Click(object sender, EventArgs e)
        {
            ReporteBoletadePagoProduccion frmreportes = new ReporteBoletadePagoProduccion();
            if (dgvProduccion.CurrentRow.Index != -1)
            {
                frmreportes.idPlanillaVenta = Convert.ToInt32(dgvProduccion.CurrentRow.Cells["Id_Produccion"].Value);
                frmreportes.ShowDialog();
            }
        }

        private void btnGenerarReporteTransporte_Click(object sender, EventArgs e)
        {
            ReporteBoletadePagoTransporte frmreportes = new ReporteBoletadePagoTransporte();
            if (dgvTransporte.CurrentRow.Index != -1)
            {
                frmreportes.idPlanillaVenta = Convert.ToInt32(dgvTransporte.CurrentRow.Cells["Id_Transporte"].Value);
                frmreportes.ShowDialog();
            }
        }


        private void btnGenerarReporteAdministracion_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduccion.CurrentRow.Index != -1)
                {
                    idPlanillaProduccion = Convert.ToString(dgvProduccion.CurrentRow.Cells["Id_Produccion"].Value);
                    btnGenerarReporteProduccion.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registros vacío");
            }
        }

        private void btnReporteQuincenalProduccion_Click(object sender, EventArgs e)
        {
            ReporteQuincenalPlanillaProduccion formrepoquinceproduccion = new ReporteQuincenalPlanillaProduccion();
            formrepoquinceproduccion.FechaInicio = dtpFecha_Inicio_Produccion.Value.Date;
            formrepoquinceproduccion.FechaFinal = dtpFecha_Final_Produccion.Value.Date;
            formrepoquinceproduccion.ShowDialog();
        }

        private void dgvTransporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTransporte.CurrentRow.Index != -1)
                {
                    idPlanillaTransporte = Convert.ToString(dgvTransporte.CurrentRow.Cells["Id_Transporte"].Value);
                    btnGenerarReporteTransporte.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registros vacío");
            }
        }

        private void btnReporteQuincenalTransporte_Click(object sender, EventArgs e)
        {
            ReporteQuincenalPlanillaTransporte formrepoquinceproduccion = new ReporteQuincenalPlanillaTransporte();
            formrepoquinceproduccion.FechaInicio = dtpFecha_Inicio_Transporte.Value.Date;
            formrepoquinceproduccion.FechaFinal = dtpFecha_Final_Transporte.Value.Date;
            formrepoquinceproduccion.ShowDialog();
        }

        private void btnReporteQuincenalAdministracion_Click(object sender, EventArgs e)
        {
            ReporteQuincenalPlanillaAdministracion formrepoquinceproduccion = new ReporteQuincenalPlanillaAdministracion();
            formrepoquinceproduccion.FechaInicio = dtpFecha_Inicio_Admon.Value.Date;
            formrepoquinceproduccion.FechaFinal = dtpFecha_Final_Admon.Value.Date;
            formrepoquinceproduccion.ShowDialog();
        }
    }
}

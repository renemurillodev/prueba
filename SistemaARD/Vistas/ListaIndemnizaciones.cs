using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class ListaIndemnizaciones : Form
    {
        SqlConnection cnn = new SqlConnection(Clases.Connection.ObtenerConexion());
        
        public ListaIndemnizaciones()
        {
            InitializeComponent();
        }

        private void ListaIndemnizaciones_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            CargarTodas();
            CalcularPago();
            cbxDepartamento.SelectedIndex = 0;
        }

        void LimpiarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
        }

        void CalcularPago()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns.Add("TotalPagar", "TOTAL A PAGAR");
            dataGridView1.Columns.Add("Retencion", "RETENCIÓN (10 %)");
            dataGridView1.Columns.Add("LiquidoPagar", "LIQUIDO A PAGAR");

            decimal salarioMensual = 0;
            int diasPendiente = 0;
            decimal totalPagar = 0;
            decimal retencion = 0;
            decimal liquidoPagar = 0;
            decimal totalPago = 0;
            decimal totalRetenciones = 0;
            decimal totalPagoLiquido = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                diasPendiente = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                totalPagar = Convert.ToDecimal((salarioMensual * diasPendiente) / 365);

                retencion = Convert.ToDecimal(totalPagar * Convert.ToDecimal(0.1));
                liquidoPagar = totalPagar - retencion;

                dataGridView1.Rows[i].Cells[7].Value = "$" + Math.Round(totalPagar, 2);
                dataGridView1.Rows[i].Cells[8].Value = "$" + Math.Round(retencion, 2);
                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(liquidoPagar, 2);

                totalPago += totalPagar;
                totalRetenciones += retencion;
                totalPagoLiquido += liquidoPagar;
            }
            lblTotalPago.Text = "El total a pagar es: $" + Math.Round(totalPago, 2);
            lblRetenciones.Text = "El total de retenciones es: $" + Math.Round(totalRetenciones, 2);
            lblTotalPagoLiquido.Text = "El total liquido a pagar es: $" + Math.Round(totalPagoLiquido, 2);
        }

        void CargarTodas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizaciones", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarAdministracion()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesAdministracion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarAdministracionFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesAdministracionConFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarMantenimiento()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesMantenimiento", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarMantenimientoFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesMantenimientoConFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarProduccion()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesProduccion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarProduccionFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesProduccionConFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarTransporte()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesTransporte", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarTransporteFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesTransporteConFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarVentas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesVentas", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarVentasFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizacionesVentasConFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarTodasFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarTodasIndemnizacionesFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(dtpHasta.Value.Year < dtpDesde.Value.Year || dtpHasta.Value.Year == dtpDesde.Value.Year)
            {
                MessageBox.Show("El año de la fecha hasta debe ser mayor al año de la fecha desde");
            }
            else
            {
                if(dtpHasta.Value.Year - dtpDesde.Value.Year > 1)
                {
                    MessageBox.Show("El periodo de la indemnización no debe ser mayor a un año");
                }
                else
                {
                    DialogResult dialog;
                    dialog = MessageBox.Show("¿Seguro que desea generar la indemnización para todos sus empleados?", "Generar Indemnización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            int res;
                            using (DBEntities db = new DBEntities())
                            {
                                db.Database.Connection.Open();
                                System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                                cmd.CommandText = "InsertarIndemnizacion";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                                res = (int)cmd.ExecuteScalar();
                                db.Database.Connection.Close();
                            }

                            if (res == 0)
                            {
                                MessageBox.Show("Ya existe una indemnización creada para el año indicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                LimpiarGrid();
                                CargarTodas();
                                CalcularPago();
                                MessageBox.Show("Indemnización generada correctamente para todos los empleados", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }               
            }           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            LimpiarGrid();
            
            string fechadesde = dtpDesde.Value.ToShortDateString();
            string fechahasta = dtpHasta.Value.ToShortDateString();
            string fechaactual = DateTime.Now.ToShortDateString();
            if(cbxDepartamento.Text == "Todos")
            {
                if(fechadesde != fechaactual && fechahasta != fechaactual)
                {
                    CargarTodasFiltro();
                }
                else
                {
                    CargarTodas();
                }
                
            }
            else if(cbxDepartamento.Text == "Administración")
            {
                if (fechadesde != fechaactual && fechahasta != fechaactual)
                {
                    CargarAdministracionFiltro();
                }
                else
                {
                    CargarAdministracion();
                }
                
            }
            else if (cbxDepartamento.Text == "Mantenimiento")
            {
                if (fechadesde != fechaactual && fechahasta != fechaactual)
                {
                    CargarMantenimientoFiltro();
                }
                else
                {
                    CargarMantenimiento();
                }
                
            }
            else if (cbxDepartamento.Text == "Producción")
            {
                if (fechadesde != fechaactual && fechahasta != fechaactual)
                {
                    CargarProduccionFiltro();
                }
                else
                {
                    CargarProduccion();
                }
                
            }
            else if (cbxDepartamento.Text == "Ventas")
            {
                if (fechadesde != fechaactual && fechahasta != fechaactual)
                {
                    CargarVentasFiltro();
                }
                else
                {
                    CargarVentas();
                }
                
            }
            else if (cbxDepartamento.Text == "Transporte")
            {
                if (fechadesde != fechaactual && fechahasta != fechaactual)
                {
                    CargarTransporteFiltro();
                }
                else
                {
                    CargarTransporte();
                }
            }
            CalcularPago();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbxDepartamento_TextChanged(object sender, EventArgs e)
        {
            if (cbxDepartamento.Text == "Ventas")
            {
                btnReporteIndemnizacionVentas.Visible = true;
                btnReporteIndemnizacionAdministracion.Visible = false;
                btnReporteIndemnizacionMantenimiento.Visible = false;
                btnReporteIndemnizacionTransporte.Visible = false;
                btnReporteIndemnizacionProduccion.Visible = false;
            }
            else if (cbxDepartamento.Text == "Administración")
            {
                btnReporteIndemnizacionVentas.Visible = false;
                btnReporteIndemnizacionAdministracion.Visible = true;
                btnReporteIndemnizacionMantenimiento.Visible = false;
                btnReporteIndemnizacionTransporte.Visible = false;
                btnReporteIndemnizacionProduccion.Visible = false;
            }
            else if (cbxDepartamento.Text == "Mantenimiento")
            {
                btnReporteIndemnizacionVentas.Visible = false;
                btnReporteIndemnizacionAdministracion.Visible = false;
                btnReporteIndemnizacionMantenimiento.Visible = true;
                btnReporteIndemnizacionTransporte.Visible = false;
                btnReporteIndemnizacionProduccion.Visible = false;
            }
            else if (cbxDepartamento.Text == "Transporte")
            {
                btnReporteIndemnizacionVentas.Visible = false;
                btnReporteIndemnizacionAdministracion.Visible = false;
                btnReporteIndemnizacionMantenimiento.Visible = false;
                btnReporteIndemnizacionTransporte.Visible = true;
                btnReporteIndemnizacionProduccion.Visible = false;
            }
            else if (cbxDepartamento.Text == "Producción")
            {
                btnReporteIndemnizacionVentas.Visible = false;
                btnReporteIndemnizacionAdministracion.Visible = false;
                btnReporteIndemnizacionMantenimiento.Visible = false;
                btnReporteIndemnizacionTransporte.Visible = false;
                btnReporteIndemnizacionProduccion.Visible = true;
            }
            else
            {
                btnReporteIndemnizacionVentas.Visible = false;
                btnReporteIndemnizacionAdministracion.Visible = false;
                btnReporteIndemnizacionMantenimiento.Visible = false;
                btnReporteIndemnizacionTransporte.Visible = false;
                btnReporteIndemnizacionProduccion.Visible = false;
            }
        }
        private void btnReporteIndemnizacionAdministracion_Click(object sender, EventArgs e)
        {
            ReporteIndemnizacionAdministracion formrepoquinceventa = new ReporteIndemnizacionAdministracion();
            formrepoquinceventa.FechaInicio = dtpDesde.Value.Date;
            formrepoquinceventa.FechaFinal = dtpHasta.Value.Date;
            formrepoquinceventa.ShowDialog();
        }

        private void btnReporteIndemnizacionVentas_Click(object sender, EventArgs e)
        {
            ReporteIndemnizacionVentas formrepoquinceventa = new ReporteIndemnizacionVentas();
            formrepoquinceventa.FechaInicio = dtpDesde.Value.Date;
            formrepoquinceventa.FechaFinal = dtpHasta.Value.Date;
            formrepoquinceventa.ShowDialog();
        }

        private void btnReporteIndemnizacionProduccion_Click(object sender, EventArgs e)
        {
            ReporteIndemnizacionProduccion formrepoquinceventa = new ReporteIndemnizacionProduccion();
            formrepoquinceventa.FechaInicio = dtpDesde.Value.Date;
            formrepoquinceventa.FechaFinal = dtpHasta.Value.Date;
            formrepoquinceventa.ShowDialog();
        }

        private void btnReporteIndemnizacionTransporte_Click(object sender, EventArgs e)
        {
            ReporteIndemnizacionTransporte formrepoquinceventa = new ReporteIndemnizacionTransporte();
            formrepoquinceventa.FechaInicio = dtpDesde.Value.Date;
            formrepoquinceventa.FechaFinal = dtpHasta.Value.Date;
            formrepoquinceventa.ShowDialog();
        }

        private void btnReporteIndemnizacionMantenimiento_Click(object sender, EventArgs e)
        {
            ReporteIndemnizacionMantenimiento formrepoquinceventa = new ReporteIndemnizacionMantenimiento();
            formrepoquinceventa.FechaInicio = dtpDesde.Value.Date;
            formrepoquinceventa.FechaFinal = dtpHasta.Value.Date;
            formrepoquinceventa.ShowDialog();
        }
    }
}

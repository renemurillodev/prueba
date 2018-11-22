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
    public partial class MostrarAguinaldos : Form
    {
        int nuevo = 0;
        SqlConnection cnn = new SqlConnection(Clases.Connection.ObtenerConexion());
        decimal salarioDiario = 0;
        decimal salarioMensual = 0;
        int diasPagar = 0;
        int diasTrabajados = 0;
        decimal totalPagar = 0;

        public MostrarAguinaldos()
        {
            InitializeComponent();
        }

        private void MostrarAguinaldos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarCombo();
        }

        void CargarCombo()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxDepartamento.DataSource = db.Departamentos.ToList<Departamentos>();
                cbxDepartamento.DisplayMember = "Nombre";
                cbxDepartamento.ValueMember = "Id";
            }
        }

        void LlenarAguinaldoAdministracion()
        {
            if(nuevo != 0)
            {
                LimpiarGrid();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("ListarAguinaldosAdministracion", cnn);
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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;


            dataGridView1.Columns.Add("PagoDiario", "Pago diario");
            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                salarioDiario = Math.Round(salarioMensual / 30, 2);
                diasPagar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                diasTrabajados = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                if (diasPagar == 0)
                {
                    totalPagar = Convert.ToDecimal(((salarioDiario * 15) / 365) * diasTrabajados);
                }
                else
                {
                    totalPagar = Convert.ToDecimal(salarioDiario * diasPagar);
                }

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(salarioDiario, 2);
                dataGridView1.Rows[i].Cells[10].Value = "$" + Math.Round(totalPagar, 2);

            }
           
        }

        void LimpiarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
        }

        void LlenarAguinaldoVentas()
        {
            LimpiarGrid();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarAguinaldosVentas", cnn);
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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns.Add("PagoDiario", "Pago diario");
            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                salarioDiario = Math.Round(salarioMensual / 30, 2);
                diasPagar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                diasTrabajados = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                if (diasPagar == 0)
                {
                    totalPagar = Convert.ToDecimal(((salarioDiario * 15) / 365) * diasTrabajados);
                }
                else
                {
                    totalPagar = Convert.ToDecimal(salarioDiario * diasPagar);
                }

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(salarioDiario, 2);
                dataGridView1.Rows[i].Cells[10].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }

        void LlenarAguinaldoMantenimiento()
        {
            LimpiarGrid();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarAguinaldosMantenimiento", cnn);
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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns.Add("PagoDiario", "Pago diario");
            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                salarioDiario = Math.Round(salarioMensual / 30, 2);
                diasPagar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                diasTrabajados = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                if (diasPagar == 0)
                {
                    totalPagar = Convert.ToDecimal(((salarioDiario * 15) / 365) * diasTrabajados);
                }
                else
                {
                    totalPagar = Convert.ToDecimal(salarioDiario * diasPagar);
                }

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(salarioDiario, 2);
                dataGridView1.Rows[i].Cells[10].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }

        void LlenarAguinaldoTransporte()
        {
            LimpiarGrid();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarAguinaldosTransporte", cnn);
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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns.Add("PagoDiario", "Pago diario");
            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                salarioDiario = Math.Round(salarioMensual / 30, 2);
                diasPagar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                diasTrabajados = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                if (diasPagar == 0)
                {
                    totalPagar = Convert.ToDecimal(((salarioDiario * 15) / 365) * diasTrabajados);
                }
                else
                {
                    totalPagar = Convert.ToDecimal(salarioDiario * diasPagar);
                }

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(salarioDiario, 2);
                dataGridView1.Rows[i].Cells[10].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }

        void LlenarAguinaldoProduccion()
        {
            LimpiarGrid();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarAguinaldosProduccion", cnn);
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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns.Add("PagoDiario", "Pago diario");
            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
                salarioDiario = Math.Round(salarioMensual / 30, 2);
                diasPagar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                diasTrabajados = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                if (diasPagar == 0)
                {
                    totalPagar = Convert.ToDecimal(((salarioDiario * 15) / 365) * diasTrabajados);
                }
                else
                {
                    totalPagar = Convert.ToDecimal(salarioDiario * diasPagar);
                }

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(salarioDiario, 2);
                dataGridView1.Rows[i].Cells[10].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }


        private void cbxDepartamento_TextChanged(object sender, EventArgs e)
        {
            if(cbxDepartamento.Text == "Ventas")
            {
                LlenarAguinaldoVentas();

                btnReporteAguinaldoVentas.Visible = true;
                btnReporteAguinaldo.Visible = false;
                btnReporteAguinaldoMantenimiento.Visible = false;
                btnReporteAguinaldoTransporte.Visible = false;
                btnReporteAguinaldoProduccion.Visible = false;
            }
            else if (cbxDepartamento.Text == "Administración")
            {
                LlenarAguinaldoAdministracion();
                btnReporteAguinaldo.Visible = true;
                btnReporteAguinaldoMantenimiento.Visible = false;
                btnReporteAguinaldoTransporte.Visible = false;
                btnReporteAguinaldoProduccion.Visible = false;
                btnReporteAguinaldoVentas.Visible = false;
            }
            else if (cbxDepartamento.Text == "Mantenimiento")
            {
                LlenarAguinaldoMantenimiento();

                btnReporteAguinaldoMantenimiento.Visible = true;
                btnReporteAguinaldoTransporte.Visible = false;
                btnReporteAguinaldoProduccion.Visible = false;
                btnReporteAguinaldoVentas.Visible = false;
                btnReporteAguinaldo.Visible = false;
            }
            else if (cbxDepartamento.Text == "Transporte")
            {
                LlenarAguinaldoTransporte();

                btnReporteAguinaldoTransporte.Visible = true;
                btnReporteAguinaldoProduccion.Visible = false;
                btnReporteAguinaldoVentas.Visible = false;
                btnReporteAguinaldo.Visible = false;
                btnReporteAguinaldoMantenimiento.Visible = false;
            }
            else if (cbxDepartamento.Text == "Producción")
            {
                LlenarAguinaldoProduccion();

                btnReporteAguinaldoProduccion.Visible = true;
                btnReporteAguinaldoVentas.Visible = false;
                btnReporteAguinaldo.Visible = false;
                btnReporteAguinaldoMantenimiento.Visible = false;
                btnReporteAguinaldoTransporte.Visible = false;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReporteAguinaldo_Click(object sender, EventArgs e)
        {
            ReporteAguinaldoAdministracion formrepoquinceproduccion = new ReporteAguinaldoAdministracion();
            formrepoquinceproduccion.Año = Convert.ToInt32(cmbxAño.SelectedItem);
            formrepoquinceproduccion.ShowDialog();
        }

        private void btnReporteAguinaldoVentas_Click(object sender, EventArgs e)
        {
            ReporteAguinaldoVentas formrepoquinceproduccion = new ReporteAguinaldoVentas();
            formrepoquinceproduccion.Año = Convert.ToInt32(cmbxAño.SelectedItem);
            formrepoquinceproduccion.ShowDialog();
        }

        private void btnReporteAguinaldoProduccion_Click(object sender, EventArgs e)
        {
            ReporteAguinaldoProduccion formrepoquinceproduccion = new ReporteAguinaldoProduccion();
            formrepoquinceproduccion.Año = Convert.ToInt32(cmbxAño.SelectedItem);
            formrepoquinceproduccion.ShowDialog();
        }

        private void btnReporteAguinaldoTransporte_Click(object sender, EventArgs e)
        {
            ReporteAguinaldoTransporte formrepoquinceproduccion = new ReporteAguinaldoTransporte();
            formrepoquinceproduccion.Año = Convert.ToInt32(cmbxAño.SelectedItem);
            formrepoquinceproduccion.ShowDialog();
        }

        private void btnReporteAguinaldoMantenimiento_Click(object sender, EventArgs e)
        {
            ReporteAguinaldoMantenimiento formrepoquinceproduccion = new ReporteAguinaldoMantenimiento();
            formrepoquinceproduccion.Año = Convert.ToInt32(cmbxAño.SelectedItem);
            formrepoquinceproduccion.ShowDialog();
        }
    }

        
 }

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
                dataGridView1.Columns.RemoveAt(9);
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


            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                salarioDiario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
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

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(totalPagar, 2);

            }
           
        }
        void LlenarAguinaldoVentas()
        {
            dataGridView1.Columns.RemoveAt(9);
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

            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioDiario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
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

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }

        void LlenarAguinaldoMantenimiento()
        {
            dataGridView1.Columns.RemoveAt(9);
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

            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioDiario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
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

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }

        void LlenarAguinaldoTransporte()
        {
            dataGridView1.Columns.RemoveAt(9);
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

            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioDiario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
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

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }

        void LlenarAguinaldoProduccion()
        {
            dataGridView1.Columns.RemoveAt(9);
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

            dataGridView1.Columns.Add("TotalPagar", "Total a pagar");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var salario = dataGridView1.Rows[i].Cells[3].Value.ToString();
                salarioDiario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString());
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

                dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(totalPagar, 2);

            }
            nuevo = 1;
        }


        private void cbxDepartamento_TextChanged(object sender, EventArgs e)
        {
            if(cbxDepartamento.Text == "Ventas")
            {
                LlenarAguinaldoVentas();
            }
            else if (cbxDepartamento.Text == "Administración")
            {
                LlenarAguinaldoAdministracion();
                
            }
            else if (cbxDepartamento.Text == "Mantenimiento")
            {
                LlenarAguinaldoMantenimiento();
            }
            else if (cbxDepartamento.Text == "Transporte")
            {
                LlenarAguinaldoTransporte();
            }
            else if (cbxDepartamento.Text == "Producción")
            {
                LlenarAguinaldoProduccion();
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
    }

        
 }

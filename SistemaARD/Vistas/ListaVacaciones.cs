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
    public partial class ListaVacaciones : Form
    {
        SqlConnection cnn = new SqlConnection(Clases.Connection.ObtenerConexion());
        public ListaVacaciones()
        {
            InitializeComponent();
        }

        private void ListaVacaciones_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarTodas();
            OcultarCampos();
        }

        void CargarCombo()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxDepartamentos.DataSource = db.Departamentos.ToList<Departamentos>();
                cbxDepartamentos.DisplayMember = "Nombre";
                cbxDepartamentos.ValueMember = "Id";
            }
        }

        void CargarTodas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarTodosPagosVacaciones", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgPagos.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("ListarPagosVacacionesAdministracion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgPagos.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("ListarPagosVacacionesMantenimiento", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgPagos.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("ListarPagosVacacionesProduccion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgPagos.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("ListarPagosVacacionesTransporte", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgPagos.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("ListarPagosVacacionesVentas", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgPagos.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void LimpiarGrid()
        {
            dtgPagos.DataSource = null;
        }

        void OcultarCampos()
        {
            dtgPagos.Columns[0].Visible = false;
            dtgPagos.Columns[1].Visible = false;
            dtgPagos.Columns[7].Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(cbxDepartamentos.Text == "Administración")
            {
                LimpiarGrid();
                CargarAdministracion();
                OcultarCampos();
            }
            else if (cbxDepartamentos.Text == "Mantenimiento")
            {
                LimpiarGrid();
                CargarMantenimiento();
                OcultarCampos();
            }
            else if (cbxDepartamentos.Text == "Producción")
            {
                LimpiarGrid();
                CargarProduccion();
                OcultarCampos();
            }
            else if (cbxDepartamentos.Text == "Transporte")
            {
                LimpiarGrid();
                CargarTransporte();
                OcultarCampos();
            }
            else if (cbxDepartamentos.Text == "Ventas")
            {
                LimpiarGrid();
                CargarVentas();
                OcultarCampos();
            }
        }
    }
}

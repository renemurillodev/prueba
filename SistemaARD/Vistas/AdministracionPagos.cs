using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class AdministracionPagos : Form
    {
        string id;
        Pagos pago = new Pagos();
        public AdministracionPagos()
        {
            InitializeComponent();
        }
        void CargarGrid()
        {
            using (DBEntities db = new DBEntities())
            {
                dtgPagos.AutoGenerateColumns = false;
                var pagos = db.Pagos.ToList();

                dtgPagos.DataSource = pagos;
            }
        }

        void LimpiarCampos()
        {
            txtModalidad.Text = txtValor.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            pago.Modalidad = txtModalidad.Text.Trim();
            pago.Cantidad = Convert.ToDecimal(txtValor.Text);

            if(btnRegistrar.Text == "Registrar")
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        db.Pagos.Add(pago);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Modalidad de pago registrada con éxito", "Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        pago.Id = Convert.ToInt32(id);
                        db.Entry(pago).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Modalidad de pago actualizada con éxito", "Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                    btnRegistrar.Text = "Registrar";
                    txtModalidad.Enabled = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private void dtgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtgPagos.CurrentRow.Cells[0].Value.ToString();
            txtModalidad.Text = dtgPagos.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = dtgPagos.CurrentRow.Cells[2].Value.ToString();
            txtModalidad.Enabled = false;
            btnRegistrar.Text = "Actualizar";
        }

        private void AdministracionPagos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarGrid();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

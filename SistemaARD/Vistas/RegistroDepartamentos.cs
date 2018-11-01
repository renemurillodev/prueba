using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class RegistroDepartamentos : Form
    {
        Departamentos dptos = new Departamentos();
        string idDepartamento = "";
        public RegistroDepartamentos()
        {
            InitializeComponent();
        }

        private void RegistroDepartamentos_Load(object sender, EventArgs e)
        {
            btnAdministrar.Visible = false;
            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Departamentos.ToList<Departamentos>();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else
            {
                dptos.Nombre = txtNombre.Text.Trim();
                using (DBEntities db = new DBEntities())
                {
                    db.Departamentos.Add(dptos);
                    db.SaveChanges();
                }
                MessageBox.Show("Departamento almacenado con éxito");
                txtNombre.Text = "";
                LlenarDataGrid();
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                idDepartamento = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                btnAdministrar.Visible = true;
            
            
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            AdministracionPlanilla admonplanilla = new AdministracionPlanilla();
            admonplanilla.idDepto = idDepartamento;

            AddOwnedForm(admonplanilla);
            admonplanilla.TopLevel = false;
            admonplanilla.Dock = DockStyle.Fill;
            this.Controls.Add(admonplanilla);
            this.Tag = admonplanilla;
            admonplanilla.BringToFront();
            admonplanilla.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

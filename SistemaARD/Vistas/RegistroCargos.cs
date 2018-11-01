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
    public partial class RegistroCargos : Form
    {
        int IdCargo = 0;
        Cargos cargo = new Cargos();
        public RegistroCargos()
        {
            InitializeComponent();
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

        void CargarDataGrid()
        {
            using (DBEntities db = new DBEntities())
            {
                dtgCargos.AutoGenerateColumns = false;
                var cargos = db.Database.SqlQuery<LlenarGridCargos>("SELECT dbo.Cargos.Id as Id, dbo.Cargos.Nombre as Nombre, dbo.Cargos.Departamento_Id as Departamento_Id, dbo.Departamentos.Nombre as Departamento FROM dbo.Cargos INNER JOIN dbo.Departamentos ON dbo.Cargos.Departamento_Id = dbo.Departamentos.Id").ToList();

                dtgCargos.DataSource = cargos;
            }
        }

        private void RegistroCargos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarDataGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cargo");
            }
            else
            {
                cargo.Nombre = txtNombre.Text.Trim();
                cargo.Departamento_Id = Convert.ToInt32(cbxDepartamento.SelectedValue);
                if (btnRegistrar.Text == "Registrar")
                {
                    using (DBEntities db = new DBEntities())
                    {
                        db.Cargos.Add(cargo);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Cargo registrado con éxito");
                }
                else
                {
                    cargo.Id = IdCargo;
                    using (DBEntities db = new DBEntities())
                    {
                        db.Entry(cargo).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Cargo actualizado con éxito");
                    btnRegistrar.Text = "Registrar";
                }
                
                txtNombre.Text = "";
                cbxDepartamento.SelectedValue = 1;
                CargarDataGrid();
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtgCargos.CurrentRow.Cells[1].Value.ToString();
            cbxDepartamento.SelectedValue = Convert.ToInt32(dtgCargos.CurrentRow.Cells[2].Value.ToString());
            IdCargo = Convert.ToInt32(dtgCargos.CurrentRow.Cells[0].Value.ToString());
            btnRegistrar.Text = "Actualizar";
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

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }

    public class LlenarGridCargos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Departamento_Id { get; set; }
        public string Departamento { get; set; }
    }
}

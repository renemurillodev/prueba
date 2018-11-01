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
    public partial class TiposDeTelefono : Form
    {
        private TiposTelefonos tiposTel = new TiposTelefonos();
        public TiposDeTelefono()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else
            {
                tiposTel.Nombre = txtNombre.Text.Trim();
                using (DBEntities db = new DBEntities())
                {
                    db.TiposTelefonos.Add(tiposTel);
                    db.SaveChanges();
                }
                MessageBox.Show("Tipo de teléfono almacenado con éxito");
                txtNombre.Text = "";
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

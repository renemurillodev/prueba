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
    public partial class RegistroCategoriaPlanilla : Form
    {
        CategoriasPlanillas catPlanillas = new CategoriasPlanillas();
        public RegistroCategoriaPlanilla()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar ambos campos");
            }
            else
            {
                catPlanillas.Nombre = txtNombre.Text.Trim();
                catPlanillas.Descripcion = txtDescripcion.Text.Trim();
                using (DBEntities db = new DBEntities())
                {
                    try
                    {
                        db.CategoriasPlanillas.Add(catPlanillas);
                        db.SaveChanges();
                        MessageBox.Show("Categoría registrada con éxito");
                        txtNombre.Text = txtDescripcion.Text = "";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Algo salió mal");
                    }
                    

                }
            }
        }
    }
}

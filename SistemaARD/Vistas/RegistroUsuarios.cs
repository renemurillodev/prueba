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
    public partial class RegistroUsuarios : Form
    {
        SqlConnection cnn = new SqlConnection(Clases.Connection.ObtenerConexion());
        string idUser = "0";
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        void CargarRoles()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxRoles.DataSource = db.Roles.ToList();
                cbxRoles.DisplayMember = "Nombre";
                cbxRoles.ValueMember = "Id";
            }
        }

        void CargarUsuarios()
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("ListarUsuarios", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dtgUsuarios.DataSource = dt;
                cnn.Close();

                dtgUsuarios.Columns[0].Visible = false;
                dtgUsuarios.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtRepetirPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int res;
                    using (DBEntities db = new DBEntities())
                    {
                        db.Database.Connection.Open();
                        System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                        cmd.CommandText = "InsertarUsuarios";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("Username", txtUsername.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("Password", txtPassword.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("Rol_Id", cbxRoles.SelectedValue));
                        res = (int)cmd.ExecuteScalar();
                        db.Database.Connection.Close();
                    }
                    if (res == 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario registrado con éxito", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Text = txtPassword.Text = txtRepetirPass.Text = "";
                        CargarUsuarios();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarUsuarios();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Visible = true;
            idUser = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("¿Está seguro de que desea eliminar a este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    if(idUser != "0")
                    {
                        try
                        {
                            int idUsuario = int.Parse(idUser);
                            Usuarios user = db.Usuarios.Find(idUsuario);
                            db.Usuarios.Remove(user);
                            db.SaveChanges();

                            MessageBox.Show("Usuario eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnEliminar.Visible = false;
                            idUser = "0";
                            CargarUsuarios();
                        }
                        catch (Exception)
                        {

                            throw;
                        }  
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningún usuario");
                    }
                    
                }
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

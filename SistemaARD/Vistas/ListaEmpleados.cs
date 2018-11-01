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
    public partial class ListaEmpleados : Form
    {
        private Empleados empleados = new Empleados();
        string idEmpleado = "";
        public ListaEmpleados()
        {
            InitializeComponent();
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        void CargarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Empleados.ToList<Empleados>();
            }
        }

        int VerificarPagoVacacion()
        {
            int res;
            using (DBEntities db = new DBEntities())
            {
                db.Database.Connection.Open();
                System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "VerificarPagoVacacion";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Fecha", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("IdEmpleado", int.Parse(idEmpleado)));
                res = (int)cmd.ExecuteScalar();
                db.Database.Connection.Close();
            }
            return res;
        }

        decimal SalarioQuincenalAdministracion()
        {
            decimal sal = 0;
            using (DBEntities db = new DBEntities())
            {
                int empleado = int.Parse(idEmpleado);
                var ultimoMes = db.Planillas_Jefes.OrderByDescending(j => j.Id).Where(p => p.Empleado_Id == empleado).Take(1);
                var pagos = ultimoMes.FirstOrDefault();
                sal = pagos.Salario_quincenal;
            }
            return sal;
        }

        decimal SalarioQuincenalVentas()
        {
            decimal sal = 0;
            using (DBEntities db = new DBEntities())
            {
                int empleado = int.Parse(idEmpleado);
                var ultimoMes = db.PlanillasVentas.OrderByDescending(j => j.Id).Where(p => p.Empleado_Id == empleado).Take(1);
                var pagos = ultimoMes.FirstOrDefault();
                decimal diario = pagos.Pago_diario;
                sal = diario * 15;
            }
            return sal;
        }

        decimal SalarioQuincenalProduccion()
        {
            decimal sal = 0;
            using (DBEntities db = new DBEntities())
            {
                int empleado = int.Parse(idEmpleado);
                var ultimoMes = db.PlanillasProduccion.OrderByDescending(j => j.Id).Where(p => p.Empleado_Id == empleado).Take(1);
                var pagos = ultimoMes.FirstOrDefault();
                decimal hora = pagos.Pago_hora;
                decimal hlaboradas = pagos.Horas_laboradas;
                sal = Math.Round(hora * hlaboradas, 2);
            }
            return sal;
        }

        int DeterminarDepto()
        {
            int depto;
            using (DBEntities db = new DBEntities())
            {
                db.Database.Connection.Open();
                System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "DeterminarDepartamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idEmpleado", int.Parse(idEmpleado)));
                depto = (int)cmd.ExecuteScalar();
                db.Database.Connection.Close();
            }

            return depto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            string apellido = txtApellido.Text.Trim();
            using (DBEntities db = new DBEntities())
            {

                IQueryable<Empleados> obj = from q in db.Empleados
                                            where q.Apellidos.Contains(apellido)
                                            select q;
                List<Empleados> employee = obj.ToList();

                if (employee == null)
                {
                    MessageBox.Show("El empleado que intenta buscar no existe");
                }
                else
                {
                    
                    dataGridView1.DataSource = employee;
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroEmpleados registro = new RegistroEmpleados();
            if(dataGridView1.CurrentRow.Index != -1)
            {
                registro.texto = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);

                
                registro.Show();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.CurrentRow.Index != -1)
            {
                idEmpleado = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                btnEditar.Visible = true;
                btnDetalle.Visible = true;
                btnContrato.Visible = true;
                btnVacaciones.Visible = true;
            }
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            //AgregarCargos cargos = new AgregarCargos();
            //cargos.idEmpl = idEmpleado;
            //cargos.Show();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de cerrar?", "ALERTA!!", MessageBoxButtons.YesNo) == DialogResult.Yes){
                this.Close();
            }
        }

        private void btnRegistroEmp_Click(object sender, EventArgs e)
        {
            RegistroEmpleados REmpleados = new RegistroEmpleados();
            AddOwnedForm(REmpleados);
            REmpleados.TopLevel = false;
            REmpleados.Dock = DockStyle.Fill;
            this.Controls.Add(REmpleados);
            this.Tag = REmpleados;
            REmpleados.BringToFront();
            REmpleados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RegistroEmpleados registro = new RegistroEmpleados();
            if (dataGridView1.CurrentRow.Index != -1)
            {
                registro.texto = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);


                AddOwnedForm(registro);
                registro.TopLevel = false;
                registro.Dock = DockStyle.Fill;
                this.Controls.Add(registro);
                this.Tag = registro;
                registro.BringToFront();
                registro.Show();

                
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            RegistroEmpleados registro = new RegistroEmpleados();



            if (dataGridView1.CurrentRow.Index != -1)
            {
                registro.texto = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);

                registro.detalle = "true";
                registro.Show();
            }

            
            AddOwnedForm(registro);
            registro.TopLevel = false;
            registro.Dock = DockStyle.Fill;
            this.Controls.Add(registro);
            this.Tag = registro;
            registro.BringToFront();
            registro.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnContrato_Click(object sender, EventArgs e)
        {
            GenerarContratos contrato = new GenerarContratos();
            contrato.Id = Convert.ToInt32(idEmpleado);
            contrato.Show();
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("¿Está seguro de que desea asignar pago por vacaciones para este empleado?", "Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                int resultado = VerificarPagoVacacion();
                if(resultado == 0)
                {
                    MessageBox.Show("Este empleado ya tiene un pago de vacación registrado en el corriente año", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            PagoVacaciones pagoVacacion = new PagoVacaciones();
                            decimal pagoQuincenal = 0;
                            int departamento = DeterminarDepto();
                            if(departamento == 1)
                            {
                                pagoQuincenal = SalarioQuincenalAdministracion();
                            }else if(departamento == 2)
                            {
                                pagoQuincenal = SalarioQuincenalVentas();
                            }else if(departamento == 3)
                            {
                                pagoQuincenal = SalarioQuincenalProduccion();
                            }else if(departamento == 4)
                            {
                                pagoQuincenal = SalarioQuincenalVentas();
                            }else if(departamento == 5)
                            {
                                pagoQuincenal = SalarioQuincenalVentas();
                            }

                            int emp = int.Parse(idEmpleado);
                            decimal montoPagar = (pagoQuincenal * Convert.ToDecimal(0.3) + pagoQuincenal);
                            pagoVacacion.Empleado_Id = emp;
                            pagoVacacion.Monto = Math.Round(montoPagar, 2);
                            pagoVacacion.Fecha = DateTime.Now;

                            db.PagoVacaciones.Add(pagoVacacion);
                            db.SaveChanges();
                        }
                        MessageBox.Show("El pago se ha registrado correctamente", "Pago de vacación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                } 
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }
    }
}

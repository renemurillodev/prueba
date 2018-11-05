using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SistemaARD.Vistas
{
    public partial class AdministracionPlanilla : Form
    {
        public string idDepto = "";
        string nDepto = "";
        string idEmpleado = "";
        PlanillasVentas planillaVentas = new PlanillasVentas();
        PlanillasProduccion planillaProduccion = new PlanillasProduccion();
        Planillas_Jefes planillaAdmon = new Planillas_Jefes();
        Reportes reporte = new Reportes();
        Clases.CalculoPlanilla calculoSalario = new Clases.CalculoPlanilla();
        public AdministracionPlanilla()
        {
            InitializeComponent();
        }

        int VerificarPlanillaJefes()
        {
            int res;
            using (DBEntities db = new DBEntities())
            {
                db.Database.Connection.Open();
                System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "VerificarPlanillaJefes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Fecha", dtpFechaInicio.Value));
                cmd.Parameters.Add(new SqlParameter("IdEmpleado", int.Parse(idEmpleado)));
                res = (int)cmd.ExecuteScalar();
                db.Database.Connection.Close();
            }
            return res;
        }

        int VerificarPlanillaProduccion()
        {
            int res;
            using (DBEntities db = new DBEntities())
            {
                db.Database.Connection.Open();
                System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "VerificarPlanillaProduccion";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Fecha_Inicio", dtpFechaInicio.Value));
                cmd.Parameters.Add(new SqlParameter("Fecha_Final", dtpFechaFinal.Value));
                cmd.Parameters.Add(new SqlParameter("IdEmpleado", int.Parse(idEmpleado)));
                res = (int)cmd.ExecuteScalar();
                db.Database.Connection.Close();
            }
            return res;
        }

        int VerificarPlanillaVentas()
        {
            int res;
            using (DBEntities db = new DBEntities())
            {
                db.Database.Connection.Open();
                System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "VerificarPlanillaVentas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Fecha_Inicio", dtpFechaInicio.Value));
                cmd.Parameters.Add(new SqlParameter("Fecha_Final", dtpFechaFinal.Value));
                cmd.Parameters.Add(new SqlParameter("IdEmpleado", int.Parse(idEmpleado)));
                res = (int)cmd.ExecuteScalar();
                db.Database.Connection.Close();
            }
            return res;
        }

        private void AdministracionPlanilla_Load(object sender, EventArgs e)
        {
            
            BuscarDepto();
            CargarDataGrid();
            CargarPagos();
            txtAnticipos.Text = "0";
            txtHorasExtra.Text = "0";
            chbAfp.Checked = true;
            chbIsss.Checked = true;
            if(textBox1.Text == "Ventas" || textBox1.Text == "Transporte")
            {
                lblDiasLaborados.Visible = true;
                lblPagoDiario.Visible = true;
                txtDiasLaborados.Visible = true;
                txtPagoDiario.Visible = true;
                txtPagoHora.Visible = false;
                txtHorasLaboradas.Visible = false;
                lblPagoHora.Visible = false;
                lblHorasLaboradas.Visible = false;
                lblHorasExtra.Visible = false;
                txtHorasExtra.Visible = false;
            }else if (textBox1.Text == "Mantenimiento")
            {
                lblDiasLaborados.Visible = true;
                lblPagoDiario.Visible = true;
                txtDiasLaborados.Visible = true;
                txtPagoDiario.Visible = true;
                txtPagoHora.Visible = false;
                txtHorasLaboradas.Visible = false;
                lblPagoHora.Visible = false;
                lblHorasLaboradas.Visible = false;
                lblHorasExtra.Visible = true;
                txtHorasExtra.Visible = true;
            }
            else if (textBox1.Text == "Administración")
            {
                lblDiasLaborados.Visible = false;
                lblPagoDiario.Visible = false;
                txtDiasLaborados.Visible = false;
                txtPagoDiario.Visible = false;
                txtPagoHora.Visible = false;
                txtHorasLaboradas.Visible = false;
                lblPagoHora.Visible = false;
                lblHorasLaboradas.Visible = false;
                lblHorasExtra.Visible = false;
                txtHorasExtra.Visible = false;
                lblAnticipos.Visible = true;
                txtAnticipos.Visible = true;
            }
            else
            {
                lblHorasExtra.Visible = false;
                txtHorasExtra.Visible = false;
            }
            if(DateTime.Now.Month == 12)
            {
                btnAguinaldo.Visible = true;
            }
        }

        void CargarPagos()
        {
            using (DBEntities db = new DBEntities())
            {
                decimal pagodiario = (from p in db.Pagos
                              where p.Modalidad == "Día"
                              select p.Cantidad).FirstOrDefault();

                decimal pagohora = (from p in db.Pagos
                                    where p.Modalidad == "Hora"
                                    select p.Cantidad).FirstOrDefault();
                txtPagoDiario.Text = Convert.ToString(Math.Round(pagodiario, 2));
                txtPagoHora.Text = Convert.ToString(pagohora);
            }

        }


        void BuscarDepto()
        {
            var id = int.Parse(idDepto);
            if(idDepto != "")
            {
                using (DBEntities db = new DBEntities())
                {
                    var nombreDepto = db.Departamentos.Where(x => x.Id == id).FirstOrDefault();
                    textBox1.Text = nombreDepto.Nombre;
                    nDepto = nombreDepto.Nombre;
                }
            }
            else
            {
                textBox1.Text = "Sin Depto";
            }
        }

        void CargarDataGrid()
        {
            if(nDepto == "")
            {
                MessageBox.Show("No existen empleados registrados en el departamento solicitado");
            }
            else
            { 
                using (DBEntities db = new DBEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    var empleados = db.Database.SqlQuery<LlenarPlanilla>(string.Format("SELECT dbo.Empleados.Id as Id, dbo.Empleados.Nombres as Nombres, dbo.Empleados.Apellidos as Apellidos, dbo.Empleados.Cargo_Id as Cargo_Id, dbo.Cargos.Nombre as Cargo FROM dbo.Empleados INNER JOIN dbo.Cargos ON dbo.Empleados.Cargo_Id = dbo.Cargos.Id INNER JOIN dbo.Departamentos ON dbo.Departamentos.Id = dbo.Cargos.Departamento_Id WHERE dbo.Departamentos.Nombre = '{0}'", nDepto)).ToList();
                    
                    dataGridView1.DataSource = empleados;
                }
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAnticipos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                idEmpleado = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                string nombres = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombres"].Value);
                string apellidos = Convert.ToString(dataGridView1.CurrentRow.Cells["Apellidos"].Value);
                txtEmpleado.Text = string.Format("{0} {1}", nombres, apellidos);
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Ventas")
            {
                int resultado = VerificarPlanillaVentas();
                if(resultado == 0)
                {
                    MessageBox.Show("Este empleado ya ha alcanzado el número máximo de registros por mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                    chbAfp.Checked = true;
                    chbIsss.Checked = true;
                }
                else
                {
                    //Registrar en tabla PlanillaVentas
                    planillaVentas.Empleado_Id = Convert.ToInt32(idEmpleado);
                    planillaVentas.Pago_diario = Convert.ToDecimal(txtPagoDiario.Text);
                    planillaVentas.Dias_laborados = Convert.ToInt32(txtDiasLaborados.Text);
                    planillaVentas.Dias_asueto = Convert.ToInt32(txtDiasAsuetos.Text);
                    planillaVentas.Anticipos = Convert.ToDecimal(txtAnticipos.Text);
                    planillaVentas.Fecha_Final = dtpFechaFinal.Value;
                    planillaVentas.Fecha_Inicio = dtpFechaInicio.Value;
                    planillaVentas.Dias_vacaciones = Convert.ToInt32(txtVacaciones.Text);
                    planillaVentas.Dias_incapacitado = Convert.ToInt32(txtIncapacitado.Text);
                    planillaVentas.Dias_perdidos = Convert.ToInt32(txtDiasPerdidos.Text);
                    planillaVentas.Viaticos = Convert.ToDecimal(txtViaticos.Text);
                    planillaVentas.Categoria_Id = 1;

                    //Registrar en tabla Reportes 

                    var sueldo = Convert.ToDecimal(txtPagoDiario.Text) * Convert.ToDecimal(txtDiasLaborados.Text);
                    var afp = sueldo * Convert.ToDecimal(0.0725);
                    var isss = sueldo * Convert.ToDecimal(0.03);
                    var sueldoPostRetenciones = sueldo - (afp + isss);
                    reporte.Empleado_Id = Convert.ToInt32(idEmpleado);
                    reporte.Sueldo = sueldo;
                    if (chbAfp.Checked)
                    {
                        reporte.Pago_Afp = afp;
                    }
                    else
                    {
                        reporte.Pago_Afp = 0;
                    }

                    if (chbIsss.Checked)
                    {
                        reporte.Pago_Isss = isss;
                    }
                    else
                    {
                        reporte.Pago_Isss = 0;
                    }


                    reporte.Pago_Renta = 0;
                    reporte.Fecha_Inicio = dtpFechaInicio.Value;
                    reporte.Fecha_Final = dtpFechaFinal.Value;

                    using (DBEntities db = new DBEntities())
                    {
                        try
                        {
                            db.PlanillasVentas.Add(planillaVentas);
                            db.Reportes.Add(reporte);
                            db.SaveChanges();
                            MessageBox.Show("Pago registrado");
                            txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                            chbAfp.Checked = true;
                            chbIsss.Checked = true;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Algo salió mal");
                        }
                    }
                }
                
            }else if (textBox1.Text == "Transporte")
            {
                int resultado = VerificarPlanillaVentas();
                if (resultado == 0)
                {
                    MessageBox.Show("Este empleado ya ha alcanzado el número máximo de registros por mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                    chbAfp.Checked = true;
                    chbIsss.Checked = true;
                    txtAnticipos.Text = "0";
                }
                else
                {
                    //Registrar en tabla PlanillaVenta
                    planillaVentas.Empleado_Id = Convert.ToInt32(idEmpleado);
                    planillaVentas.Pago_diario = Convert.ToDecimal(txtPagoDiario.Text);
                    planillaVentas.Dias_laborados = Convert.ToInt32(txtDiasLaborados.Text);
                    planillaVentas.Dias_asueto = Convert.ToInt32(txtDiasAsuetos.Text);
                    planillaVentas.Anticipos = Convert.ToDecimal(txtAnticipos.Text);
                    planillaVentas.Fecha_Final = dtpFechaFinal.Value;
                    planillaVentas.Fecha_Inicio = dtpFechaInicio.Value;
                    planillaVentas.Dias_vacaciones = Convert.ToInt32(txtVacaciones.Text);
                    planillaVentas.Dias_incapacitado = Convert.ToInt32(txtIncapacitado.Text);
                    planillaVentas.Dias_perdidos = Convert.ToInt32(txtDiasPerdidos.Text);
                    planillaVentas.Viaticos = Convert.ToDecimal(txtViaticos.Text);
                    planillaVentas.Categoria_Id = 3;

                    //Registrar en tabla Reportes 

                    var sueldo = Convert.ToDecimal(txtPagoDiario.Text) * Convert.ToDecimal(txtDiasLaborados.Text);
                    var afp = sueldo * Convert.ToDecimal(0.0725);
                    var isss = sueldo * Convert.ToDecimal(0.03);
                    var sueldoPostRetenciones = sueldo - (afp + isss);
                    reporte.Empleado_Id = Convert.ToInt32(idEmpleado);
                    reporte.Sueldo = sueldo;
                    if (chbAfp.Checked)
                    {
                        reporte.Pago_Afp = afp;
                    }
                    else
                    {
                        reporte.Pago_Afp = 0;
                    }

                    if (chbIsss.Checked)
                    {
                        reporte.Pago_Isss = isss;
                    }
                    else
                    {
                        reporte.Pago_Isss = 0;
                    }


                    reporte.Pago_Renta = 0;
                    reporte.Fecha_Inicio = dtpFechaInicio.Value;
                    reporte.Fecha_Final = dtpFechaFinal.Value;

                    using (DBEntities db = new DBEntities())
                    {
                        try
                        {
                            db.PlanillasVentas.Add(planillaVentas);
                            db.Reportes.Add(reporte);
                            db.SaveChanges();
                            MessageBox.Show("Pago registrado");
                            txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                            chbAfp.Checked = true;
                            chbIsss.Checked = true;
                            txtAnticipos.Text = "0";
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }                   
            }else if (textBox1.Text == "Mantenimiento")
            {
                int resultado = VerificarPlanillaVentas();
                if (resultado == 0)
                {
                    MessageBox.Show("Este empleado ya ha alcanzado el número máximo de registros por mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                    chbAfp.Checked = true;
                    chbIsss.Checked = true;
                    txtAnticipos.Text = "0";
                }
                else
                {
                    //Registrar en tabla PlanillaVentas
                    planillaVentas.Empleado_Id = Convert.ToInt32(idEmpleado);
                    planillaVentas.Pago_diario = Convert.ToDecimal(txtPagoDiario.Text);
                    planillaVentas.Dias_laborados = Convert.ToInt32(txtDiasLaborados.Text);
                    planillaVentas.Dias_asueto = Convert.ToInt32(txtDiasAsuetos.Text);
                    planillaVentas.Horas_extra = Convert.ToInt32(txtHorasExtra.Text);
                    planillaVentas.Anticipos = Convert.ToDecimal(txtAnticipos.Text);
                    planillaVentas.Fecha_Final = dtpFechaFinal.Value;
                    planillaVentas.Fecha_Inicio = dtpFechaInicio.Value;
                    planillaVentas.Dias_vacaciones = Convert.ToInt32(txtVacaciones.Text);
                    planillaVentas.Dias_incapacitado = Convert.ToInt32(txtIncapacitado.Text);
                    planillaVentas.Dias_perdidos = Convert.ToInt32(txtDiasPerdidos.Text);
                    planillaVentas.Viaticos = Convert.ToDecimal(txtViaticos.Text);
                    planillaVentas.Categoria_Id = 2;

                    //Registrar en tabla Reportes 

                    var sueldo = Convert.ToDecimal(txtPagoDiario.Text) * Convert.ToDecimal(txtDiasLaborados.Text);
                    var afp = sueldo * Convert.ToDecimal(0.0725);
                    var isss = sueldo * Convert.ToDecimal(0.03);
                    var sueldoPostRetenciones = sueldo - (afp + isss);
                    reporte.Empleado_Id = Convert.ToInt32(idEmpleado);
                    reporte.Sueldo = sueldo;
                    if (chbAfp.Checked)
                    {
                        reporte.Pago_Afp = afp;
                    }
                    else
                    {
                        reporte.Pago_Afp = 0;
                    }

                    if (chbIsss.Checked)
                    {
                        reporte.Pago_Isss = isss;
                    }
                    else
                    {
                        reporte.Pago_Isss = 0;
                    }


                    reporte.Pago_Renta = 0;
                    reporte.Fecha_Inicio = dtpFechaInicio.Value;
                    reporte.Fecha_Final = dtpFechaFinal.Value;

                    using (DBEntities db = new DBEntities())
                    {
                        try
                        {
                            db.PlanillasVentas.Add(planillaVentas);
                            db.Reportes.Add(reporte);
                            db.SaveChanges();
                            MessageBox.Show("Pago registrado");
                            txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                            chbAfp.Checked = true;
                            chbIsss.Checked = true;
                            txtAnticipos.Text = "0";
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Algo salió mal");
                        }
                    }
                }                   
            }else if (textBox1.Text == "Producción")
            {
                int resultado = VerificarPlanillaProduccion();
                if(resultado == 0)
                {
                    MessageBox.Show("Este empleado ya ha alcanzado el número máximo de registros por mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                    chbAfp.Checked = true;
                    chbIsss.Checked = true;
                    txtAnticipos.Text = "0";
                }
                else
                {
                    //Registrar en tabla PlanillaProduccion
                    planillaProduccion.Empleado_Id = Convert.ToInt32(idEmpleado);
                    planillaProduccion.Pago_hora = Convert.ToDecimal(txtPagoHora.Text);
                    planillaProduccion.Horas_laboradas = Convert.ToInt32(txtHorasLaboradas.Text);
                    planillaProduccion.Anticipos = Convert.ToDecimal(txtAnticipos.Text);
                    planillaProduccion.Fecha_Final = dtpFechaFinal.Value;
                    planillaProduccion.Fecha_Inicio = dtpFechaInicio.Value;
                    planillaProduccion.Dias_vacaciones = Convert.ToInt32(txtVacaciones.Text);
                    planillaProduccion.Dias_incapacitado = Convert.ToInt32(txtIncapacitado.Text);
                    planillaProduccion.Dias_perdidos = Convert.ToInt32(txtDiasPerdidos.Text);
                    planillaProduccion.Horas_extras = Convert.ToDouble(txtHorasExtra.Text);
                    planillaProduccion.Horas_dias_incompletos = Convert.ToDouble(txtHorasDiasIncompletos.Text);
                    planillaProduccion.Horas_dias_asueto = Convert.ToDouble(txtDiasAsuetos.Text);
                    planillaProduccion.Dias_perdidos = Convert.ToInt32(txtDiasPerdidos.Text);
                    planillaProduccion.Categoria_Id = 4;


                    //Registrar en tabla Reportes 

                    var sueldo = Convert.ToDecimal(txtPagoHora.Text) * Convert.ToDecimal(txtHorasLaboradas.Text);
                    var afp = sueldo * Convert.ToDecimal(0.0725);
                    var isss = sueldo * Convert.ToDecimal(0.03);
                    var sueldoPostRetenciones = sueldo - (afp + isss);
                    reporte.Empleado_Id = Convert.ToInt32(idEmpleado);
                    reporte.Sueldo = sueldo;
                    if (chbAfp.Checked)
                    {
                        reporte.Pago_Afp = afp;
                    }
                    else
                    {
                        reporte.Pago_Afp = 0;
                    }

                    if (chbIsss.Checked)
                    {
                        reporte.Pago_Isss = isss;
                    }
                    else
                    {
                        reporte.Pago_Isss = 0;
                    }


                    reporte.Pago_Renta = 0;
                    reporte.Fecha_Inicio = dtpFechaInicio.Value;
                    reporte.Fecha_Final = dtpFechaFinal.Value;

                    using (DBEntities db = new DBEntities())
                    {
                        try
                        {
                            db.PlanillasProduccion.Add(planillaProduccion);
                            db.Reportes.Add(reporte);
                            db.SaveChanges();
                            MessageBox.Show("Pago registrado");
                            txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                            chbAfp.Checked = true;
                            chbIsss.Checked = true;
                            txtAnticipos.Text = "0";
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Algo salió mal");
                        }
                    }
                }
                
            }else if (textBox1.Text == "Administración")
            {
                int resultado = VerificarPlanillaJefes();
                if(resultado == 0)
                {
                    MessageBox.Show("Este empleado ya ha alcanzado el número máximo de registros por mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                    chbAfp.Checked = true;
                    chbIsss.Checked = true;
                    txtAnticipos.Text = "0";
                }
                else
                {
                    //Registrar en tabla PlanillaJefes
                    planillaAdmon.Empleado_Id = Convert.ToInt32(idEmpleado);

                    planillaAdmon.Anticipos = Convert.ToDecimal(txtAnticipos.Text);
                    planillaAdmon.Fecha = dtpFechaInicio.Value;
                    decimal salarioMensual = 0;
                    int idEmp = int.Parse(idEmpleado);
                    using (DBEntities db = new DBEntities())
                    {
                        salarioMensual = (from em in db.Empleados
                                          where em.Id == idEmp
                                          select em.Salario).FirstOrDefault();
                    }
                    planillaAdmon.Salario_quincenal = Math.Round(salarioMensual / 2, 2);

                    //Registrar en tabla Reportes 

                    var sueldo = planillaAdmon.Salario_quincenal;
                    var afp = sueldo * Convert.ToDecimal(0.0725);
                    var isss = sueldo * Convert.ToDecimal(0.03);
                    var sueldoPostRetenciones = sueldo - (afp + isss);
                    reporte.Empleado_Id = Convert.ToInt32(idEmpleado);
                    reporte.Sueldo = sueldo;
                    if (chbAfp.Checked)
                    {
                        reporte.Pago_Afp = afp;
                    }
                    else
                    {
                        reporte.Pago_Afp = 0;
                    }

                    if (chbIsss.Checked)
                    {
                        reporte.Pago_Isss = isss;
                    }
                    else
                    {
                        reporte.Pago_Isss = 0;
                    }


                    reporte.Pago_Renta = 0;
                    reporte.Fecha_Inicio = dtpFechaInicio.Value;
                    reporte.Fecha_Final = dtpFechaFinal.Value;

                    using (DBEntities db = new DBEntities())
                    {
                        try
                        {
                            db.Planillas_Jefes.Add(planillaAdmon);
                            db.Reportes.Add(reporte);
                            db.SaveChanges();
                            MessageBox.Show("Pago registrado");
                            txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = "";
                            chbAfp.Checked = true;
                            chbIsss.Checked = true;
                            txtAnticipos.Text = "0";
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                        {
                            Exception raise = dbEx;
                            foreach (var validationErrors in dbEx.EntityValidationErrors)
                            {
                                foreach (var validationError in validationErrors.ValidationErrors)
                                {
                                    string message = string.Format("{0}:{1}",
                                        validationErrors.Entry.Entity.ToString(),
                                        validationError.ErrorMessage);
                                    // raise a new exception nesting
                                    // the current instance as InnerException
                                    raise = new InvalidOperationException(message, raise);
                                }
                            }
                            throw raise;
                        }
                    }
                }
                
            }
        }

        private void txtAnticipos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorasLaboradas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPagoHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAguinaldo_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("¿Seguro que desea generar aguinaldo para este departamento?", "Generar aguinaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (textBox1.Text == "Ventas")
                {
                    try
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            db.Database.Connection.Open();
                            System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                            cmd.CommandText = "InsertarAguinaldoVentas";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteScalar();
                            db.Database.Connection.Close();
                        }
                        MessageBox.Show(String.Format("Aguinaldo generado correctamente para el departamento de {0}", textBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "Transporte")
                {
                    try
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            db.Database.Connection.Open();
                            System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                            cmd.CommandText = "InsertarAguinaldoTransporte";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteScalar();
                            db.Database.Connection.Close();
                        }
                        
                        MessageBox.Show(String.Format("Aguinaldo generado correctamente para el departamento de {0}", textBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "Producción")
                {
                    try
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            db.Database.Connection.Open();
                            System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                            cmd.CommandText = "InsertarAguinaldoProduccion";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteScalar();
                            db.Database.Connection.Close();
                        }
                        MessageBox.Show(String.Format("Aguinaldo generado correctamente para el departamento de {0}", textBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "Mantenimiento")
                {
                    try
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            db.Database.Connection.Open();
                            System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                            cmd.CommandText = "InsertarAguinaldoMantenimiento";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteScalar();
                            db.Database.Connection.Close();
                        }
                        MessageBox.Show(String.Format("Aguinaldo generado correctamente para el departamento de {0}", textBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "Administración")
                {
                    try
                    {
                        using (DBEntities db = new DBEntities())
                        {
                            db.Database.Connection.Open();
                            System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                            cmd.CommandText = "InsertarAguinaldoAdministracion";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteScalar();
                            db.Database.Connection.Close();
                        }
                        MessageBox.Show(String.Format("Aguinaldo generado correctamente para el departamento de {0}", textBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        private void txtPagoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))/*Cambiar IsNumber a IsDigit, en caso de que de eror al guardar los datos*/
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
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtHorasLaboradas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtHorasLaboradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPagoDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))/*Cambiar IsNumber a IsDigit, en caso de que de eror al guardar los datos*/
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
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtDiasLaborados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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

        private void txtAnticipos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))/*Cambiar IsNumber a IsDigit, en caso de que de eror al guardar los datos*/
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
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtHorasExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))/*Cambiar IsNumber a IsDigit, en caso de que de eror al guardar los datos*/
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
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtHorasExtra_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class LlenarPlanilla
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cargo_Id { get; set; }
        public string Cargo { get; set; }
    }
}

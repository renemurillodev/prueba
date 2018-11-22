using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace SistemaARD.Vistas
{
    public partial class GenerarContratos : Form
    {
        public int Id;
        public string nombreDepto;

        public GenerarContratos()
        {
            InitializeComponent();
        }

        private void EditarDocumento()
        {
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();

            string ruta = "";
            if (nombreDepto == "Mantenimiento")
            {

            }
            else if (nombreDepto == "Transporte")
            {
                ruta = @"C:\Contratos\contrato-motorista.docx";
            }
            else if (nombreDepto == "Ventas")
            {
                ruta = @"C:\Contratos\contrato-vendedor.docx";
            }
            else if (nombreDepto == "Producción")
            {
                ruta = @"C:\Contratos\contrato-plantaproduccion.docx";
            }
            else if (nombreDepto == "Administración")
            {

            }
            object parametro = ruta;
            object nombre = "nombre";
            object nombre1 = "nombre1";
            object sexo = "sexo";
            object edad = "edad";
            object estadocivil = "estadocivil";
            object profesion = "profesion";
            object direccion = "direccion";
            object nit = "nit";
            object dui = "dui";
            object lugarexpedicion = "expedicion";
            object isss = "isss";
            object afp = "afp";
            object cargo = "cargo";
            object salario = "salario";
            object periodo = "periodo";
            object dia = "dia"; 
            object mes = "mes"; 
            object anio = "anio"; 

            Word.Document ObjDoc = ObjWord.Documents.Open(parametro, ObjMiss);

            Word.Range nom = ObjDoc.Bookmarks.get_Item(ref nombre).Range;
            Word.Range nom1 = ObjDoc.Bookmarks.get_Item(ref nombre1).Range;
            Word.Range genero = ObjDoc.Bookmarks.get_Item(ref sexo).Range;
            Word.Range age = ObjDoc.Bookmarks.get_Item(ref edad).Range;
            Word.Range estcivil = ObjDoc.Bookmarks.get_Item(ref estadocivil).Range;
            Word.Range prof = ObjDoc.Bookmarks.get_Item(ref profesion).Range;
            Word.Range direc = ObjDoc.Bookmarks.get_Item(ref direccion).Range;
            Word.Range itributaria = ObjDoc.Bookmarks.get_Item(ref nit).Range;
            Word.Range dunico = ObjDoc.Bookmarks.get_Item(ref dui).Range;
            Word.Range exped = ObjDoc.Bookmarks.get_Item(ref lugarexpedicion).Range;
            Word.Range seguro = ObjDoc.Bookmarks.get_Item(ref isss).Range;
            Word.Range pension = ObjDoc.Bookmarks.get_Item(ref afp).Range;
            Word.Range carg = ObjDoc.Bookmarks.get_Item(ref cargo).Range;
            Word.Range sala = ObjDoc.Bookmarks.get_Item(ref salario).Range;
            Word.Range period = ObjDoc.Bookmarks.get_Item(ref periodo).Range;
            Word.Range day = ObjDoc.Bookmarks.get_Item(ref dia).Range; 
            Word.Range month = ObjDoc.Bookmarks.get_Item(ref mes).Range; 
            Word.Range year = ObjDoc.Bookmarks.get_Item(ref anio).Range; 



            nom.Text = txtNombreCompeto.Text;
            nom1.Text = txtNombreCompeto.Text;
            genero.Text = txtSexo.Text;
            age.Text = txtEdad.Text;
            estcivil.Text = txtEstadoCivil.Text;
            prof.Text = txtProfesion.Text;
            direc.Text = txtDomicilio.Text;
            itributaria.Text = txtNIT.Text;
            dunico.Text = txtDUI.Text;
            exped.Text = txtLugarFechaExpedicionDUI.Text;
            seguro.Text = txtIsss.Text;
            pension.Text = txtAFP.Text;
            carg.Text = txtCargo.Text;
            sala.Text = txtSalario.Text;
            period.Text = txtPeriodo.Text;
            day.Text = Convert.ToString(DateTime.Now.Day); 
            month.Text = nombreMes(DateTime.Now.Month); 
            year.Text = Convert.ToString(DateTime.Now.Year); 


            object rango1 = nom;
            object rango15 = nom1;
            object rango2 = genero;
            object rango3 = age;
            object rango4 = estcivil;
            object rango5 = prof;
            object rango6 = direc;
            object rango7 = itributaria;
            object rango8 = dunico;
            object rango9 = exped;
            object rango10 = seguro;
            object rango11 = pension;
            object rango12 = carg;
            object rango13 = sala;
            object rango14 = period;
            object rango16 = day; 
            object rango17 = month; 
            object rango18 = year; 

            ObjDoc.Bookmarks.Add("nombre", ref rango1);
            ObjDoc.Bookmarks.Add("nombre1", ref rango15);
            ObjDoc.Bookmarks.Add("sexo", ref rango2);
            ObjDoc.Bookmarks.Add("edad", ref rango3);
            ObjDoc.Bookmarks.Add("estadocivil", ref rango4);
            ObjDoc.Bookmarks.Add("profesion", ref rango5);
            ObjDoc.Bookmarks.Add("direccion", ref rango6);
            ObjDoc.Bookmarks.Add("nit", ref rango7);
            ObjDoc.Bookmarks.Add("dui", ref rango8);
            ObjDoc.Bookmarks.Add("expedicion", ref rango9);
            ObjDoc.Bookmarks.Add("isss", ref rango10);
            ObjDoc.Bookmarks.Add("afp", ref rango11);
            ObjDoc.Bookmarks.Add("cargo", ref rango12);
            ObjDoc.Bookmarks.Add("salario", ref rango13);
            ObjDoc.Bookmarks.Add("periodo", ref rango14);
            ObjDoc.Bookmarks.Add("dia", ref rango16); 
            ObjDoc.Bookmarks.Add("mes", ref rango17); 
            ObjDoc.Bookmarks.Add("anio", ref rango18); 

            ObjWord.Visible = true;
        }


        private string nombreMes(int numeroMes)
        {
            try
            {
                DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
                string nombreMes = formatoFecha.GetMonthName(numeroMes);
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombreMes);
            }
            catch
            {
                return "Desconocido";
            }
        }



        private void GenerarContratos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            using (DBEntities db = new DBEntities())
            {
                nombreDepto = (from emp in db.Empleados
                               join c in db.Cargos on emp.Cargo_Id equals c.Id
                               join d in db.Departamentos on c.Departamento_Id equals d.Id
                               where emp.Id == Id
                               select d.Nombre).FirstOrDefault();

                var empleado = db.Empleados.Find(Id);
                txtNombreCompeto.Text = empleado.NombreCompleto;
                txtSexo.Text = empleado.Generos.Nombre;
                txtEdad.Text = Convert.ToString(empleado.Edad);
                txtDomicilio.Text = empleado.Direccion;
                txtDUI.Text = empleado.N_Dui;
                txtNIT.Text = empleado.N_Nit;
                txtIsss.Text = empleado.N_Isss;
                txtAFP.Text = empleado.N_Afp;
                txtCargo.Text = empleado.Cargos.Nombre;
                txtSalario.Text = Convert.ToString(empleado.Salario);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            EditarDocumento();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLugarFechaDUI_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCompeto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEstadoCivil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNIT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIsss_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAFP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) //Al pulsar un numero
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (e.KeyChar.ToString().Equals("."))   //VALIDA CON PUNTO DECIMAL, IsDigit
            {
                e.Handled = false;
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

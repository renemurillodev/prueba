//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaARD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Indemnizaciones
    {
        public int Id { get; set; }
        public int Empleado_Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Categoria_Id { get; set; }
        public int Anios_Pendiente { get; set; }
        public int Dias_Pendiente { get; set; }
        public System.DateTime Desde { get; set; }
        public System.DateTime Hasta { get; set; }
    
        public virtual CategoriasIndemnizaciones CategoriasIndemnizaciones { get; set; }
        public virtual Empleados Empleados { get; set; }
    }
}
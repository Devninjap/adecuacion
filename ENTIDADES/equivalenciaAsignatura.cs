//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTIDADES
{
    using System;
    using System.Collections.Generic;
    
    public partial class equivalenciaAsignatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equivalenciaAsignatura()
        {
            this.detalleAdecuacion = new HashSet<detalleAdecuacion>();
        }
    
        public int idEquivalencia { get; set; }
        public string codAsignaturaA { get; set; }
        public string nomAsignaturaA { get; set; }
        public string horasTeoricasA { get; set; }
        public string horasPracticasA { get; set; }
        public string totalHorasA { get; set; }
        public string creditosAsignaturaA { get; set; }
        public string cicloAsignaturaA { get; set; }
        public string planAsignaturaA { get; set; }
        public string codAsignaturaB { get; set; }
        public string nomAsignaturaB { get; set; }
        public string horasTeoricasB { get; set; }
        public string horasPracticasB { get; set; }
        public string totalHorasB { get; set; }
        public string creditosAsignaturaB { get; set; }
        public string cicloAsignaturaB { get; set; }
        public string planAsignaturaB { get; set; }
        public Nullable<bool> condicion { get; set; }
        public Nullable<bool> tecnico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleAdecuacion> detalleAdecuacion { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tareas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class filesHomework
    {
        public int id { get; set; }
        public string url { get; set; }
        public string descripcion { get; set; }
        public int idHome { get; set; }
    
        public virtual homework homework { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eDostava_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StavkeNarudzbe
    {
        public int StavkaNarudzbeID { get; set; }
        public int NarudzbaID { get; set; }
        public int HranaID { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Hrana Hrana { get; set; }
        public virtual Narudzbe Narudzbe { get; set; }
    }
}

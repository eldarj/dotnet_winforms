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
    
    public partial class Zaposlenici
    {
        public int ZaposlenikID { get; set; }
        public int KorisnikID { get; set; }
        public int RestoranID { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Restorani Restorani { get; set; }
    }
}

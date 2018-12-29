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
    
    public partial class Narudzbe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzbe()
        {
            this.StavkeNarudzbe = new HashSet<StavkeNarudzbe>();
        }
    
        public int NarudzbaID { get; set; }
        public System.Guid Sifra { get; set; }
        public System.DateTime DatumVrijeme { get; set; }
        public double UkupnaCijena { get; set; }
        public Nullable<int> NarucilacID { get; set; }
        public Nullable<int> NarudzbaStatusID { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public string Adresa { get; set; }
        public Nullable<int> BlokID { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual NarudzbaStatusi NarudzbaStatusi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbe { get; set; }
        public virtual Blokovi Blokovi { get; set; }
    }
}

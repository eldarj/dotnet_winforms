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
    
    public partial class Hrana_Result
    {
        public int HranaID { get; set; }
        public Nullable<System.Guid> Sifra { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int TipKuhinjeID { get; set; }
        public string TipKuhinjeNaziv { get; set; }
        public Nullable<int> RestoranID { get; set; }
        public string RestoranNaziv { get; set; }
    }
}

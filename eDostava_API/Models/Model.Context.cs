﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EasyFoodEntities : DbContext
    {
        public EasyFoodEntities()
            : base("name=EasyFoodEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blokovi> Blokovi { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Hrana> Hrana { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<NarudzbaStatusi> NarudzbaStatusi { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<Recenzije> Recenzije { get; set; }
        public virtual DbSet<Restorani> Restorani { get; set; }
        public virtual DbSet<RestoranStatusi> RestoranStatusi { get; set; }
        public virtual DbSet<StavkeNarudzbe> StavkeNarudzbe { get; set; }
        public virtual DbSet<TipoviKuhinje> TipoviKuhinje { get; set; }
        public virtual DbSet<UlogaKorisnika> UlogaKorisnika { get; set; }
        public virtual DbSet<Zalbe> Zalbe { get; set; }
        public virtual DbSet<Vlasnici> Vlasnici { get; set; }
        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }
        public virtual DbSet<Omiljeni> Omiljeni { get; set; }
    
        public virtual ObjectResult<Blokovi_Result> esp_Blokovi_SelectAll(Nullable<int> gradId)
        {
            var gradIdParameter = gradId.HasValue ?
                new ObjectParameter("gradId", gradId) :
                new ObjectParameter("gradId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Blokovi_Result>("esp_Blokovi_SelectAll", gradIdParameter);
        }
    
        public virtual ObjectResult<Gradovi_Result> esp_Gradovi_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Gradovi_Result>("esp_Gradovi_SelectAll");
        }
    
        public virtual ObjectResult<Hrana_Result> esp_Hrana_Pretraga(Nullable<int> restoranId, string param)
        {
            var restoranIdParameter = restoranId.HasValue ?
                new ObjectParameter("restoranId", restoranId) :
                new ObjectParameter("restoranId", typeof(int));
    
            var paramParameter = param != null ?
                new ObjectParameter("param", param) :
                new ObjectParameter("param", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hrana_Result>("esp_Hrana_Pretraga", restoranIdParameter, paramParameter);
        }
    
        public virtual ObjectResult<Hrana_Result> esp_Hrana_SelectByRestoran(Nullable<int> restoranId)
        {
            var restoranIdParameter = restoranId.HasValue ?
                new ObjectParameter("restoranId", restoranId) :
                new ObjectParameter("restoranId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hrana_Result>("esp_Hrana_SelectByRestoran", restoranIdParameter);
        }
    
        public virtual ObjectResult<Korisnici_Result> esp_Korisnici_SelectByUlogaOrGrad(Nullable<int> ulogaId, Nullable<int> gradId)
        {
            var ulogaIdParameter = ulogaId.HasValue ?
                new ObjectParameter("ulogaId", ulogaId) :
                new ObjectParameter("ulogaId", typeof(int));
    
            var gradIdParameter = gradId.HasValue ?
                new ObjectParameter("gradId", gradId) :
                new ObjectParameter("gradId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici_Result>("esp_Korisnici_SelectByUlogaOrGrad", ulogaIdParameter, gradIdParameter);
        }
    
        public virtual ObjectResult<NarudzbeStatusi_Result> esp_NarudzbeStatusi_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NarudzbeStatusi_Result>("esp_NarudzbeStatusi_SelectAll");
        }
    
        public virtual ObjectResult<Recenzije_Result> esp_Recenzije_SelectByRestoranOrKorisnik(Nullable<int> filterRestoranID, Nullable<int> filterKorisnikID)
        {
            var filterRestoranIDParameter = filterRestoranID.HasValue ?
                new ObjectParameter("filterRestoranID", filterRestoranID) :
                new ObjectParameter("filterRestoranID", typeof(int));
    
            var filterKorisnikIDParameter = filterKorisnikID.HasValue ?
                new ObjectParameter("filterKorisnikID", filterKorisnikID) :
                new ObjectParameter("filterKorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Recenzije_Result>("esp_Recenzije_SelectByRestoranOrKorisnik", filterRestoranIDParameter, filterKorisnikIDParameter);
        }
    
        public virtual ObjectResult<Restorani_Result> esp_Restorani_FilterString(string filterString)
        {
            var filterStringParameter = filterString != null ?
                new ObjectParameter("filterString", filterString) :
                new ObjectParameter("filterString", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Restorani_Result>("esp_Restorani_FilterString", filterStringParameter);
        }
    
        public virtual ObjectResult<Restorani_Result> esp_Restorani_SelectAll(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Restorani_Result>("esp_Restorani_SelectAll", idParameter);
        }
    
        public virtual ObjectResult<RestoranStatusi_Result> esp_RestoranStatusi_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RestoranStatusi_Result>("esp_RestoranStatusi_SelectAll");
        }
    
        public virtual ObjectResult<TipoviKuhinje_Result> esp_TipoviKuhinje_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TipoviKuhinje_Result>("esp_TipoviKuhinje_SelectAll");
        }
    
        public virtual ObjectResult<UlogeKorisnika_Result> esp_UlogeKorisnika_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UlogeKorisnika_Result>("esp_UlogeKorisnika_SelectAll");
        }
    
        public virtual ObjectResult<Zalbe_Result> esp_Zalbe_SelectByRestoranOrNarucilac(Nullable<int> filterRestoranID, Nullable<int> filterNarucilacID)
        {
            var filterRestoranIDParameter = filterRestoranID.HasValue ?
                new ObjectParameter("filterRestoranID", filterRestoranID) :
                new ObjectParameter("filterRestoranID", typeof(int));
    
            var filterNarucilacIDParameter = filterNarucilacID.HasValue ?
                new ObjectParameter("filterNarucilacID", filterNarucilacID) :
                new ObjectParameter("filterNarucilacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Zalbe_Result>("esp_Zalbe_SelectByRestoranOrNarucilac", filterRestoranIDParameter, filterNarucilacIDParameter);
        }
    
        public virtual ObjectResult<Restorani_Result> esp_Restorani_FilterBlokGradStatus(Nullable<int> blokId, Nullable<int> gradId, Nullable<int> statusId)
        {
            var blokIdParameter = blokId.HasValue ?
                new ObjectParameter("blokId", blokId) :
                new ObjectParameter("blokId", typeof(int));
    
            var gradIdParameter = gradId.HasValue ?
                new ObjectParameter("gradId", gradId) :
                new ObjectParameter("gradId", typeof(int));
    
            var statusIdParameter = statusId.HasValue ?
                new ObjectParameter("statusId", statusId) :
                new ObjectParameter("statusId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Restorani_Result>("esp_Restorani_FilterBlokGradStatus", blokIdParameter, gradIdParameter, statusIdParameter);
        }
    
        public virtual ObjectResult<Restorani_Result> esp_Restorani_SelectAllByZaposlenikVlasnik(Nullable<int> zaposlenikId, Nullable<int> vlasnikId)
        {
            var zaposlenikIdParameter = zaposlenikId.HasValue ?
                new ObjectParameter("zaposlenikId", zaposlenikId) :
                new ObjectParameter("zaposlenikId", typeof(int));
    
            var vlasnikIdParameter = vlasnikId.HasValue ?
                new ObjectParameter("vlasnikId", vlasnikId) :
                new ObjectParameter("vlasnikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Restorani_Result>("esp_Restorani_SelectAllByZaposlenikVlasnik", zaposlenikIdParameter, vlasnikIdParameter);
        }
    
        public virtual ObjectResult<Narucioci_Result> esp_Narucioci_SelectAllOrByGrad(Nullable<int> gradId)
        {
            var gradIdParameter = gradId.HasValue ?
                new ObjectParameter("gradId", gradId) :
                new ObjectParameter("gradId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Narucioci_Result>("esp_Narucioci_SelectAllOrByGrad", gradIdParameter);
        }
    
        public virtual ObjectResult<Narudzbe_Result> esp_Narudzbe_SelectAllOrByNarucilacOrRestoran(Nullable<int> narucilacId, Nullable<int> restoranId, Nullable<int> statusId)
        {
            var narucilacIdParameter = narucilacId.HasValue ?
                new ObjectParameter("narucilacId", narucilacId) :
                new ObjectParameter("narucilacId", typeof(int));
    
            var restoranIdParameter = restoranId.HasValue ?
                new ObjectParameter("restoranId", restoranId) :
                new ObjectParameter("restoranId", typeof(int));
    
            var statusIdParameter = statusId.HasValue ?
                new ObjectParameter("statusId", statusId) :
                new ObjectParameter("statusId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Narudzbe_Result>("esp_Narudzbe_SelectAllOrByNarucilacOrRestoran", narucilacIdParameter, restoranIdParameter, statusIdParameter);
        }
    
        public virtual ObjectResult<Restorani_Result> esp_Restorani_Omiljeni(Nullable<int> korisnikId, Nullable<int> restoranId)
        {
            var korisnikIdParameter = korisnikId.HasValue ?
                new ObjectParameter("korisnikId", korisnikId) :
                new ObjectParameter("korisnikId", typeof(int));
    
            var restoranIdParameter = restoranId.HasValue ?
                new ObjectParameter("restoranId", restoranId) :
                new ObjectParameter("restoranId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Restorani_Result>("esp_Restorani_Omiljeni", korisnikIdParameter, restoranIdParameter);
        }
    }
}

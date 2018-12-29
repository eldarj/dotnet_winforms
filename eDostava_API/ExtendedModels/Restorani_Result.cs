﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace eDostava_API.Models
{
    public partial class Restorani_Result
    {
        #region SlikaHandlers
        public Image GetSlikaImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream(this.Slika);
                return Image.FromStream(ms);
            }
            catch (ArgumentNullException e)
            {
                return null;
            }
        }
        public void SetSlikaImage(Image img)
        {
            if (img == null)
            {
                this.Slika = null;
                return;
            }
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            this.Slika = ms.ToArray();
        }
        #endregion
        public override bool Equals(object obj)
        {
            Restorani_Result _obj = obj as Restorani_Result;
            return _obj != null && this.RestoranID == _obj.RestoranID;
        }

        public override string ToString()
        {
            return this.Naziv.ToString();
        }

        public static Restorani GetRestoraniInstance(Restorani_Result obj)
        {
            return new Restorani
            {
                RestoranID = obj.RestoranID,
                Sifra = obj.Sifra,
                Naziv = obj.Naziv,
                Opis = obj.Opis,
                Slika = obj.Slika,
                Adresa = obj.Adresa,
                BlokID = obj.BlokID,
                Email = obj.Email,
                KorisnikID = obj.PromStatusKorisnikID ?? 0,
                MinimalnaCijenaNarudzbe = obj.MinimalnaCijenaNarudzbe,
                RestoranStatusID = obj.RestoranStatusID,
                Telefon = obj.Telefon,
                WebUrl = obj.WebUrl
            };
        }
    }
}
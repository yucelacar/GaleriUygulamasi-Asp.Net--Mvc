using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GaleriUygulamasi.Extension;

namespace GaleriUygulamasi.Models
{
    public class Dosya
    {
        public int ID { get; set; }
        public byte[] Deger { get; set; }
        public string  DosyaAdi { get; set; }
        public string DosyaTipi { get; set; }
        public string Aciklama { get; set; }
        public string  Baslik { get; set; }
        public double DosyaBoyutu { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string  IkonBootstrap { get; set; }
        public string  IkonResim { get; set; }

        public string KisaBoyut {
            get {
                return UtilityManager.BytesToString((long)DosyaBoyutu);
            }
        }

    }
}
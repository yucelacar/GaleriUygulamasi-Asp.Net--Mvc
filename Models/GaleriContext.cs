using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GaleriUygulamasi.Models
{
    public class GaleriContext:DbContext
    {
        public GaleriContext():base("MyConnection")
        {

        }
        public DbSet<Dosya> Dosyalar { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.Data.Data
{
    public class KlinikaContext : DbContext
    {
        public KlinikaContext(DbContextOptions<KlinikaContext> options)
            : base(options)
        {
        }

        public DbSet<Klinika.Data.Data.CMS.Adres> Adres { get; set; }

        public DbSet<Klinika.Data.Data.CMS.GodzinyOtwarcia> GodzinyOtwarcia { get; set; }

        public DbSet<Klinika.Data.Data.CMS.Kontakt> Kontakt { get; set; }

        public DbSet<Klinika.Data.Data.CMS.Parametry> Parametry { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Klinika.Intranet.Models.CMS;

namespace Klinika.Intranet.Data
{
    public class KlinikaIntranetContext : DbContext
    {
        public KlinikaIntranetContext (DbContextOptions<KlinikaIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Klinika.Intranet.Models.CMS.Adres> Adres { get; set; }

        public DbSet<Klinika.Intranet.Models.CMS.GodzinyOtwarcia> GodzinyOtwarcia { get; set; }

        public DbSet<Klinika.Intranet.Models.CMS.Kontakt> Kontakt { get; set; }

        public DbSet<Klinika.Intranet.Models.CMS.Parametry> Parametry { get; set; }
    }
}

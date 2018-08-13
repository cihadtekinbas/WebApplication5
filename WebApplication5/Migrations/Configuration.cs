namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication5.Models.HaritaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication5.Models.HaritaContext context)
        {
            context.Mahalles.AddOrUpdate(x => x.Id,
                new Mahalle() { MahalleName = "Çankaya1", Koordinatlar = "POLYGON((34.4970703125 37.44869658591038,35.419921875 36.323977120112644,37.7490234375 37.431250501793556,34.4970703125 37.44869658591038))" },
            new Mahalle() { MahalleName = "Çankaya2", Koordinatlar = "POLYGON((26.71875 40.08647729380883,26.87255859375 39.03625295963661,28.322753906249996 39.08743603215885,28.015136718750003 40.38839687388361,26.71875 40.08647729380883))" },
             new Mahalle() { MahalleName = "Çankaya3", Koordinatlar = "POLYGON((28.45458984375 40.62229178309269,28.850097656249996 39.47860556892209,30.21240234375 39.90130858574736,30.366210937499996 41.28606238749825,28.45458984375 40.62229178309269))" },
             new Mahalle() { MahalleName = "Çankaya4", Koordinatlar = "POLYGON((26.762695312499996 38.48799460921481,26.38916015625 37.34395908944491,28.520507812499996 36.835668247244385,28.93798828125 38.43637960299998,27.531738281250003 37.53586597792038,26.762695312499996 38.48799460921481))" },
              new Mahalle() { MahalleName = "Çankaya5", Koordinatlar = "POLYGON((31.728515625 42.15525946577861,33.046875 40.03602652981172,36.76025390625 41.0047754222295,31.728515625 42.15525946577861))" }
            );

            context.Kapý.AddOrUpdate(x => x.Id,

                     new Kapý() { Id = 3, MahalleKodu = 1, Koordinatlar = "POINT(31.959228515625004 38.89103282648847)" },
                     new Kapý() { Id = 4, MahalleKodu = 1, Koordinatlar = "POINT(30.574951171875 40.59727063442023)" },
                     new Kapý() { Id = 5, MahalleKodu = 1, Koordinatlar = "POINT(33.958740234375 40.17887331434696)" },
                     new Kapý() { Id = 6, MahalleKodu = 1, Koordinatlar = "POINT(31.937255859375007 41.40977583200956)" }



                );
           


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

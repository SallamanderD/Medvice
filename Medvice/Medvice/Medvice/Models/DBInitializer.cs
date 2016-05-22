using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Medvice.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<MedviceContext>
    {
        protected override void Seed(MedviceContext context)
        {
            context.Diseases.Add(new Disease { DiseaseId = "1", Name = "ОРВИ", Description = "НАХУЯ ЛЕЧИТЬСЯ, ЕБОШ ПИВАС" });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "1", Name = "Температура", Content = "Температура тела выше 37" });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "1").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "1").First());
            context.SaveChanges();
            base.Seed(context);
        }

        public static void Create(MedviceContext context)
        {
            context.Database.Delete();
            context.Diseases.Add(new Disease { DiseaseId = "1", Name = "ОРВИ", Description = "НАХУЯ ЛЕЧИТЬСЯ, ЕБОШ ПИВАС" });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "1", Name = "Температура", Content = "Температура тела выше 37" });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "1").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "1").First());
            context.SaveChanges();
        }
    }
}
using SklepInternetowy.Migrations;
using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace SklepInternetowy.DAL
{
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext, Configuration>
    {
        //protected override void Seed(KursyContext context)
        //{
        //    SeedKursyData(context);
        //    base.Seed(context);
        //}
       

        public static void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaId=1,NazwaKategorii="asp",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis asp net mvc"},
                new Kategoria(){KategoriaId=2,NazwaKategorii="java",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis java"},
                new Kategoria(){KategoriaId=3,NazwaKategorii="php",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis php"},
                new Kategoria(){KategoriaId=4,NazwaKategorii="html",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis html"},
                new Kategoria(){KategoriaId=5,NazwaKategorii="css",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis css"},
                new Kategoria(){KategoriaId=6,NazwaKategorii="xml",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis xml"},
                new Kategoria(){KategoriaId=7,NazwaKategorii="c#",NazwaPlikuIkony="punktor.jpg",OpisKategorii="opis c#"},
                
           
            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs(){AutorKusrsu="tomek",NazwaKursu="asp.net mvc",KategoriaId=1,CenaKursu=99,Bestseller=true,NazwaPlikuObrazka="asp.jpg",
                DataDodania=DateTime.Now,OpisKursu="opis 1"},
                 new Kurs(){AutorKusrsu="jacek",NazwaKursu="asp.net mvc3",KategoriaId=1,CenaKursu=120,Bestseller=true,NazwaPlikuObrazka="asp-net-mvc-3.gif",
                DataDodania=DateTime.Now,OpisKursu="opis 3"},
                 new Kurs(){AutorKusrsu="irek",NazwaKursu="asp.net mvc4",KategoriaId=1,CenaKursu=120,Bestseller=true,NazwaPlikuObrazka="aspmvc.jpg",
                DataDodania=DateTime.Now,OpisKursu="opis 4"},
                 new Kurs(){AutorKusrsu="romek",NazwaKursu="asp.net mvc5",KategoriaId=1,CenaKursu=140,Bestseller=true,NazwaPlikuObrazka="asp.png",
                DataDodania=DateTime.Now,OpisKursu="opis 5"},

            };
            kursy.ForEach(k => context.Kursy.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}
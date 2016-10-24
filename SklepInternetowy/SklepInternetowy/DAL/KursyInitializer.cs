using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepInternetowy.DAL
{
    public class KursyInitializer:DropCreateDatabaseAlways<KursyContext>
    {
        protected override void Seed(KursyContext context)
        {
            SeedKursyData(context);
            base.Seed(context);
        }
       

        private void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaId=1,NazwaKategorii="asp",NazwaPlikuIkony="asp.png",OpisKategorii="opis asp net mvc"},
                new Kategoria(){KategoriaId=2,NazwaKategorii="java",NazwaPlikuIkony="java.png",OpisKategorii="opis java"},
                new Kategoria(){KategoriaId=3,NazwaKategorii="php",NazwaPlikuIkony="php.png",OpisKategorii="opis php"},
                new Kategoria(){KategoriaId=4,NazwaKategorii="html",NazwaPlikuIkony="html.png",OpisKategorii="opis html"},
                new Kategoria(){KategoriaId=5,NazwaKategorii="css",NazwaPlikuIkony="css.png",OpisKategorii="opis css"},
                new Kategoria(){KategoriaId=6,NazwaKategorii="xml",NazwaPlikuIkony="xml.png",OpisKategorii="opis xml"},
                new Kategoria(){KategoriaId=7,NazwaKategorii="c#",NazwaPlikuIkony="c#.png",OpisKategorii="opis c#"},
                
           
            };
            kategorie.ForEach(k=>context.Kategorie.Add(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs(){AutorKusrsu="tomek",NazwaKursu="asp.net mvc",KategoriaId=1,CenaKursu=99,Bestseller=true,NazwaPlikuObrazka="asp.png",
                DataDodania=DateTime.Now,OpisKursu="opis 1"},
                 new Kurs(){AutorKusrsu="jacek",NazwaKursu="asp.net mvc3",KategoriaId=1,CenaKursu=120,Bestseller=true,NazwaPlikuObrazka="aspmvc3.png",
                DataDodania=DateTime.Now,OpisKursu="opis 3"},
                 new Kurs(){AutorKusrsu="irek",NazwaKursu="asp.net mvc4",KategoriaId=1,CenaKursu=120,Bestseller=true,NazwaPlikuObrazka="aspmvc4.png",
                DataDodania=DateTime.Now,OpisKursu="opis 4"},
                 new Kurs(){AutorKusrsu="romek",NazwaKursu="asp.net mvc5",KategoriaId=1,CenaKursu=140,Bestseller=true,NazwaPlikuObrazka="aspmvc5.png",
                DataDodania=DateTime.Now,OpisKursu="opis 5"},

            };
            kursy.ForEach(k => context.Kursy.Add(k));
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Kurs
    {
        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage="Wprowadź nazwę kursu")]
        [StringLength(100)]
        public string NazwaKursu { get; set; }
        [Required(ErrorMessage="Wprowadź nazwę autora")]
        [StringLength(100)]
        public string AutorKusrsu { get; set; }
        public DateTime DataDodania { get; set; }
        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisKursu { get; set; }
        public decimal CenaKursu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrucony { get; set; }

        public virtual Kategoria kategoria { get; set; }
    }
}
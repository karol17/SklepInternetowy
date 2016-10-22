using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SklepInternetowy.Models
{
   public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage="Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage="Wprowadź opis kategorii")]
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}

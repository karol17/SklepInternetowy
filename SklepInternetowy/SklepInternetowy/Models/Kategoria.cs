using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SklepInternetowy.Models
{
    class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}

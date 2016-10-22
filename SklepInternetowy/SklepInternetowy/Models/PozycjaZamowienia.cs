using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SklepInternetowy.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamowieniaId { get; set; }
        public int KursId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }

        public virtual Kurs kurs { get; set; }
        public virtual Zamowienie zamowienie { get; set; }
    }
}

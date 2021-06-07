using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.MVVM.Model
{
    class Proslava
    {
        private Korisnik _klijent { get; set; }
        private Korisnik _organizator { get; set; }//nije u konst
        private Saradnik _saradnik { get; set; }
        private string _tema { get; set; }
        private DateTime _datum { get; set; }
        private double _budzet { get; set; }
        private int _kapacitet { get; set; }
        private string _komentar { get; set; }
        private List<Sto> _stolovi { get; set; }//nije u konst


        public Proslava(Korisnik klijent, Saradnik saradnik, string tema, DateTime datum, double budzet, int kapacitet, string komentar)
        {
            _klijent = klijent;
            _saradnik = saradnik;
            _tema = tema;
            _datum = datum;
            _budzet = budzet;
            _kapacitet = kapacitet;
            _komentar = komentar;
        }
    }
}

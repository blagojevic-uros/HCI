using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.MVVM.Model
{
    class Saradnik
    {
        private int _pib { get; set; }
        private string _ime;
        private string _adresa;
        private int _kapacitet;
        private int _br_stolova;
        private string _slika;


        public Saradnik(int pib, string ime, string adresa, int kapacitet, int br_stolova, string slika)
        {
            _pib = pib;
            _ime = ime;
            _adresa = adresa;
            _kapacitet = kapacitet;
            _br_stolova = br_stolova;
            _slika = slika;
        }

        public Saradnik() { }
    }
}

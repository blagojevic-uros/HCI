using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.MVVM.Model
{
    class Korisnik
    {
        private string _ime { get; set; }
        private string _prezime { get; set; }
        private string _email { get; set; }
        private string _sifra { get; set; }
        private string _pol { get; set; }
        private DateTime _datumRodjenja { get; set; }
        private string _role { get; set; }


        public Korisnik(string ime, string prezime, string email, string sifra, string pol ,DateTime datumRodj,string role)
        {
            _ime = ime;
            _prezime = prezime;
            _email = email;
            _sifra = sifra;
            _pol = pol;
            _datumRodjenja = datumRodj;
            _role = role;
        }
        public Korisnik() { }
    }
}

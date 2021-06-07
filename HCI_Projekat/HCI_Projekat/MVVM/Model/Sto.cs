using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.MVVM.Model
{
    class Sto
    {
        private int _br_stola;
        private int _br_mesta;
        private List<string> _imena;
        public Sto(int br_stola, int br_mesta, List<string> imena)
        {
            _br_stola = br_stola;
            _br_mesta = br_mesta;
            _imena = imena;
        }
    }
}
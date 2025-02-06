using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace kres
{
    class Kres
    {
        public string nazwa {  get; set; }
        public string opis { get; set; }
        public int liczbaOfiar { get; set; }
        public int rok {  get; set; }

        public Kres(string nazwa, string opis, int liczbaOfiar, int rok)
        {
            this.nazwa = nazwa;
            this.opis = opis;
            this.liczbaOfiar = liczbaOfiar;
            this.rok = rok;
        }
    }
}

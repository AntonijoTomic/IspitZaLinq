using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Classes
{
    internal class Proizvod
    {

        public int ProizvodID { get; set; }
        public string Naziv { get; set; }

        public Proizvod(int proizvodID, string naziv)
        {
            ProizvodID = proizvodID;
            Naziv = naziv;
        }
    }
}

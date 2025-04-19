using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kliens_alkalmazas
{
    internal class Termek
    {
        public string Név { get; set; }

        public decimal BeszerzésiÁr { get; set; }

        public int Raktáron { get; set; }

        public int MinimálisMennyiség { get; set; }

        public int OptimálisMennyiség { get; set; }

        public  decimal OptimálishozSzükségesFt  { get; set; }
    }
}

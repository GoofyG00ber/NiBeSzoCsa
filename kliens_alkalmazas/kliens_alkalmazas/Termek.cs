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

        public string Bvin { get; set; }

        private decimal beszerzésiÁr;
        public decimal BeszerzésiÁr 
        { 
            get => beszerzésiÁr;
            set
            {
                beszerzésiÁr = value;
                SzámolOptimalisMennyiseg();
            }
        }

        private int raktáron;
        public int Raktáron 
        { 
            get => raktáron;
            set
            {
                raktáron = value;
                SzámolOptimalisMennyiseg();
            }
        }

        private int minimálisMennyiség;
        public int MinimálisMennyiség 
        { 
            get => minimálisMennyiség;
            set
            {
                minimálisMennyiség = value;
                SzámolOptimalisMennyiseg();
            }
        }

        public int OptimálisMennyiség { get; internal set; }

        public decimal OptimálishozSzükségesFt { get; internal set; }

        public int OptimálishozSzükségesDb { get; internal set; }

        public string Beszállító { get; set; }

        private void SzámolOptimalisMennyiseg()
        {
            if (MinimálisMennyiség == 1)
            {
                OptimálisMennyiség = 3;
            }
            else if (MinimálisMennyiség == 5)
            {
                OptimálisMennyiség = 10;
            }
            else if (MinimálisMennyiség == 15)
            {
                OptimálisMennyiség = 30;
            }
            else if (MinimálisMennyiség == 50)
            {
                OptimálisMennyiség = 100;
            }
            else
            {
                OptimálisMennyiség = 300;
            }

            OptimálishozSzükségesDb = OptimálisMennyiség - Raktáron;
            OptimálishozSzükségesFt = OptimálishozSzükségesDb * BeszerzésiÁr;
        }
    }
}

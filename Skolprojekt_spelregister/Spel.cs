using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolprojekt_spelregister
{
    class Spel
    {
        private string titel;
        private string genre;
        private double betyg;

        public Spel(string titel, string genre, double betyg)
        {
            Titel = titel;
            Genre = genre;
            Betyg = betyg;
        }

        public string Titel
        {
            set
            {
                if (value != "") titel = value;
                else titel = "Pong!";
            }
            get
            {
                return titel;
            }
        }
        public string Genre
        {
            set
            {
                if (value != "") genre = value;
                else genre = "Arkad";
            }
            get
            {
                return genre;
            }
        }
        public double Betyg
        {
            set
            {
                if (value >= 0.0) betyg = value;
                else betyg = 5.5;
            }
            get
            {
                return betyg;
            }
        }
    }
}

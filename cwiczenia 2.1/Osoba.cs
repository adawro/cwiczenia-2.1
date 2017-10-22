using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_2._1
{
    class Osoba
    {
        internal string imie;
        internal string nazwisko;
        internal int rokUrodzenia;
        public int waga;
        public double wzrost;
        public bool okulary;
        public string plec;
        public double BMI;

        public int ObliczWiek()
        {
            return 2017 - rokUrodzenia;
        }
        public string Info()
        {
            if(plec=="K")
            {
                return "Dyrektorem jest Pani " + imie + " " + nazwisko;

            }
            else
            {
                return "Dyrektorem jest Pan " + imie + " " + nazwisko;
            }
        }
        public double BMIi ()
        {
            BMI = waga / (wzrost * wzrost);
            return BMI;
            
        }
       

    }
    
}

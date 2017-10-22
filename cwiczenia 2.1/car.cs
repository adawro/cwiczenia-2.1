using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_2._1
{
     class Car
    {
         public string marka;
         private int rokProdukcji;
         private string model;
         private int iloscDrzwi;
         private int pojemnoscSilnika;
         public double srednieSpalanie;

         public void ustawRokProdukcji (int rok)
         {
             rokProdukcji = rok;
         }
         public string Info ()
         {
             return marka + " " + rokProdukcji;

         }
         private double ObliczSpalanie (double dlugoscTrasy)
         {
             return srednieSpalanie *  dlugoscTrasy;
         }
         public double ObliczKosztPaliwa (double dlugoscTrasy, double cenaPaliwa)
         {
             return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
         }

    }
}

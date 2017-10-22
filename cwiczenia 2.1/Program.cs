using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1*/
            //string carName = "Mój samochód";
            //Car car1 = new Car();
            //car1.marka = "Ford";
            //car1.ustawRokProdukcji(2013);
           
            
            //car1.srednieSpalanie = 4;
            //Console.WriteLine(car1.ObliczKosztPaliwa(500.0, 4.2));
            //Console.WriteLine(Info);
            //Console.ReadKey();
            //Car car2 = new Car();
            //car2.marka = "Skoda";
            //car2.ustawRokProdukcji(2000);

            /***********************************************************************/
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Adam";
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1970;
            dyrektor.waga = 90;
            dyrektor.wzrost = 1.75;
            
            //dyrektor.okulary = true;
            //dyrektor.plec = "M";
            //Console.WriteLine(dyrektor.imie+"\n"+dyrektor.nazwisko +"\n"+dyrektor.rokUrodzenia+"\n"+dyrektor.waga+"\n"+dyrektor.wzrost+"\n");
            //Console.WriteLine(dyrektor.ObliczWiek());
            //Console.WriteLine(dyrektor.Info());
            /**************************************************************************************/
            Console.WriteLine("BMI "+dyrektor.imie+ " " + dyrektor.nazwisko + " Wynosi "+ dyrektor.BMIi());

            Console.ReadKey();
        }
    }

}

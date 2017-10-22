using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_2._1
{
    class Koszyk
    {
        public List<Produkt> lista = new
        List<Produkt>();

        public void DodajeProduktDoKoszyka (string nazwaProduktu, int cenaProduktu)
        {
            Produkt temp = new Produkt();
            temp.cena = cenaProduktu;
            temp.nazwa = nazwaProduktu;
            lista.Add(temp);
            Console.WriteLine("Dodano Produkt: {0} ", nazwaProduktu)
        }

    }
}

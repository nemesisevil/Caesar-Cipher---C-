using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfr
{
    class KonwerterCezar
    {
        private string _szyfr = "null";
        string poszyfr = null;
        int _przesun;

        public KonwerterCezar(string Szyfr, int Przes)  //konstruktor
        {
            _szyfr = Szyfr;
            _przesun = Przes;

        }

        public void Szyfruj()  // szyfruje
        {

            for(int i=0; i<_szyfr.Length; i++)
            {
                int index = _szyfr.ElementAt(i);  // nr znaku aktualnie pobranego
                int x = 0;
                x = 93 + (index + _przesun - 93) % 26;
                poszyfr += Convert.ToString((char)x);

            }
        }

        public string Konwersja()
        {
            Szyfruj();
            return poszyfr;
        }
    }
}

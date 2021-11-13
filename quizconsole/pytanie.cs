using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizconsole
{
    class Pytanie
    {
        public int ID { get; set; }
        public int Kategoria { get; set; }
        public string Tresc { get; set; }
        public string Odp1 { get; set; }
        public string Odp2 { get; set; }
        public string Odp3 { get; set; }
        public string Odp4 { get; set; }
    }
    public void WyswietlNaEkranie()
    {
        Console.WriteLine("X");
    }

    public int Dodaj(int x, int y)
    {
        return x + y;
    }


}

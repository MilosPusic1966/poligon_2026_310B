using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_310B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            tacka A = new tacka(2, 3);
            tacka B = new tacka(4, 5);
            tacka C = new tacka(6, 7);
            tacka D = new tacka(8, 9);
            vektor AB = new vektor(A, B);
            AB.stampaj();
            */
/*poligon prvi = poligon.unos();
prvi.stampa();
prvi.snimi();
*/
// poligon drugi = poligon.ucitaj();
// drugi.stampa();
/*
    tacka A = new tacka(1, 1);
    tacka B = new tacka(5, 1);
    tacka C = new tacka(2, 0.1);
    tacka D = new tacka(2, 0);
    vektor AB = new vektor(A, B);
    vektor CD = new vektor(C, D);
    Console.WriteLine(AB.sece(CD));
       */
        poligon prvi = poligon.unos();
        Console.WriteLine(prvi.konveksan());
        }
    }
}

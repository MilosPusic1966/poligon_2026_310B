using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_310B
{
    class poligon
    {
        int br_temena;
        tacka[] teme;
        public poligon(int n) 
        { 
            br_temena= n;
            teme = new tacka[n];
        }
        public static poligon unos()
        {
            Console.WriteLine("Unesite broj temena=");
            int br=Convert.ToInt32(Console.ReadLine());
            poligon novi = new poligon(br);
            for (int i = 0; i < br; i++)
            {
                Console.Write("Teme({0}).x=", i+1);
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Teme({0}).y=", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());
                novi.teme[i]=new tacka(x, y);
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon sa "+br_temena+" temena:");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("x={0} y={1}", teme[i].x, teme[i].y);
            }
        }

    }
}

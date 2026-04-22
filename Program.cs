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
            /*
            poligon prvi = poligon.unos();
            if (prvi.prost()) 
               Console.WriteLine(prvi.povrsina());
            else Console.WriteLine("nije prost");
            */
            tacka A = new tacka(1, 3);
            tacka B = new tacka(1, 1);
            tacka C = new tacka(5, 1);
            tacka D = new tacka(5, 3);
            vektor ab = new vektor(A, B);
            vektor bc = new vektor(B, C);
            vektor cd = new vektor(C, D);
            vektor da = new vektor(D, A);
            double ab_len = ab.duzina();
            double bc_len = bc.duzina();
            double cd_len = cd.duzina();
            double da_len = da.duzina();

            // kvadrat:
            // ab = bc = cd = da
            // ab L bc
            if ((ab_len == bc_len) && (bc_len == cd_len) && (cd_len == da_len))
                if (vektor.SP(ab, bc) == 0)
                    Console.WriteLine("jeste kvadrat");
                else Console.WriteLine("nije kvadrat");
            else Console.WriteLine("nije kvadrat");
            // pravougaonik:
            // ab = cd, bc = da
            // ab L bc
            if ((ab_len == cd_len) && (bc_len==da_len))
            {
                if (vektor.SP(ab, bc) == 0)
                {
                    Console.WriteLine("jeste pravougaonik");
                }
                else Console.WriteLine("nije pravougaonik");
            }
            else Console.WriteLine("nije pravougaonik");
            // deltoid:
            // ab = da & bc = cd
            // ab = bc & cd = da
            if ((ab_len == da_len)&& (bc_len == cd_len))
            {
                Console.WriteLine("jeste deltoid: ab=da");
            }
            else
            if ((ab_len == bc_len) && (cd_len==da_len))
            {
                Console.WriteLine("Jeste deltoid AB=BC");
            }
            else Console.WriteLine("nije deltoid"); ;
        }
    }
}

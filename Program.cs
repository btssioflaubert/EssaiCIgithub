using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssaiCIGitHub
{
    public class Program
    {
      
        public static void saisiedonnees( ref int a,ref int b,ref int c)
        {
           
                Console.WriteLine("entrez le premier nombre");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("entrez le deuxiéme nombre");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("entrez le troisième  nombre");
                c = Int32.Parse(Console.ReadLine());
          
        }
        public static int somme( int a, int b)
        {
            return a + b;
        }
      
        public static void affichage( int a,int b,int c)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
        static void Main(string[] args)
        {
            int A, B, C;
            A = 0;B = 0;C = 0;
            Console.WriteLine("Bonjour GitHub");
            Console.WriteLine(" je rajoute une ligne pour un premier commit");
            Console.WriteLine(" je rajoute une ligne pour un premier commit");
            saisiedonnees(ref A, ref B, ref C);
            C = somme(A, B);
            affichage(A, B, C);
            Console.ReadLine();
        }
    }
}

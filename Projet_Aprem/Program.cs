using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Aprem
{
    class Program
    {
        private void methodeTest(int nombre)
        {
            Console.WriteLine("fonctionTest : le nombre vaut " + nombre);
            nombre = 100;
            Console.WriteLine("fonctionTest : le nombre vaut " + nombre);
        }

        private void testAppel()
        {
            int n = 5;
            Console.WriteLine("testAppel : le nombre vaut " + n);

            methodeTest(n); // Appel à la méthode

            Console.WriteLine("testAppel : le nombre vaut " + n);   // la valeur de 'n' n'a été modifiée que dans la fonction (n vaut toujours 5)

            // On peut passer une expression ou une constante
            methodeTest(25 + 5); // Appel à la méthode
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine();
            // je pete ma bierre MA LIBELLULE

           
        }

    }
}

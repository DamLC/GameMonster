using System;
using TPjeu.Monstres;

namespace TPjeu.Monstres
{
    public class FabriqueMonstre
    {
        private static  Random random = new Random(); 
        
        public static MonstreFacile creerMonstre()
        {
            
            int nb = random.Next(2);

            if (nb == 0)
            {
                Console.WriteLine("Un monstre facile vient d'être créé");
                Narration.enter();
                return new MonstreFacile();
            }
            Console.WriteLine("Un monstre difficile vient d'être créé");
            Narration.enter();
            return new MonstreDifficile();
        }
    }
}
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
                return new MonstreFacile();
            }
            return new MonstreFacile();
        }
    }
}
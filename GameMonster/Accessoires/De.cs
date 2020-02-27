using System;

namespace TPjeu.Accessoire
{
    public class De
    {
        private static Random random;

        public De()
        { 
            random = new Random();
             
        }
        
        public static int lancerDe(int valeur)
        {
            return random.Next(1, valeur);
        }
        
    }
}
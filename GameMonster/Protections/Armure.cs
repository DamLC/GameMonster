using System;

namespace TPjeu.Protections
{
    public class Armure
    {
        public static int durabilité;
        
        public static bool estEntiere
        {
            get {return durabilité > 0;}
            
        }

        public int Durabilité
        {
            get => durabilité;
            private set => durabilité = value;
        }
        
        public Armure( int durabilité)
        {
            this.Durabilité = durabilité;
            
        }
        public void encaisserDegats(int degats, Armure armure)
        {
            if (estEntiere == true)
            {
                durabilité -= degats;
                Console.WriteLine("Votre armure encaisse "+degats+ " degats");
                Console.WriteLine("Il reste "+durabilité + " Pts de durabilité a ton armure");

            }
            if(durabilité == 0 || durabilité <0)
            {
                Console.WriteLine("BRING!! Votre armure est cassée");
            }
        }
    }
}
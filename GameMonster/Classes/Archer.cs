using System;
using System.Security.Permissions;
using TPjeu.Accessoire;
using TPjeu.Personnages;

namespace TPjeu.Classe
{
    public class Archer : Joueur
    {
        public static int degats;

        public Archer(int pointVie, int plastron, int epee, int rouge) : base(pointVie, plastron, epee, rouge)
        {

        }

        public static int skill()
        {
            int recharge = De.lancerDe(10);
            int competence = De.lancerDe(6);
            
            if (recharge > 5)
            {
                Narration.recharge();
                Console.WriteLine("Vous avez fait " + competence);

                if (competence >= 4)
                {
                    Narration.competenceArcher();
                    degats = De.lancerDe(26) + 100;
                }
                else
                {
                    Console.WriteLine("Ah c'est dommage la compêtence a échoué");
                    degats = De.lancerDe(26) + arme.degatsCAC;
                }
            }

            return degats;
        }
        
       

        
    }
}
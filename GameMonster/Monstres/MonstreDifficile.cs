using System;
using TPjeu.Accessoire;
using TPjeu.Personnages;

namespace TPjeu.Monstres
{
    public class MonstreDifficile : MonstreFacile
    {
        private int degatsMagique = 5;

       public override void attaque(Joueur joueur)
        {
            base.attaque(joueur);
            joueur.subirDegats(sortMagique());
        }
        
        public int sortMagique()
        {
            int lancerJoueur = De.lancerDe(26);
            if ( lancerJoueur == 6)
            {
                return 0;
            }            
            Console.WriteLine("le mosntre difficile vous inflige "+  lancerJoueur * degatsMagique +" de degats magique");
            return lancerJoueur * degatsMagique;                           
        }
    }
}
using TPjeu.Monstres;
using TPjeu.Personnages;

namespace TPjeu.Monstres
{
    public class MonstreDifficile : MonstreFacile
    {
        private int degatsMagique = 5;
        
        public void sortMagique(Joueur joueur)
        {
            int lancerJoueur = joueur.lancerDe(26);
            if ( lancerJoueur< 6)
            {
                 joueur.subirDegats(lancerJoueur * degatsMagique);
            }                            
        }
    }
   
}
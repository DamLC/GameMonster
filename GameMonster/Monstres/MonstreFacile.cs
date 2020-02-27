using TPjeu.Accessoire;
using TPjeu.Personnages;

namespace TPjeu.Monstres
{
    public class MonstreFacile
    {
        private De de;
        public bool estVivant { get; private set; }
        private int degats = 10;

        public MonstreFacile()
        {
            de= new De();
            this.estVivant = true;
        }

        public int lancerDe(int valeur )
        {
            return De.lancerDe(valeur);
        }
        
        public void attaque(Joueur joueur)
        {
            int lancerJoueur = joueur.lancerDe(26);
            int LancerMonstre =  lancerDe(26);
            if (lancerJoueur < LancerMonstre)
            {
                joueur.subirDegats(degats);
            }
        }

        public void  subitDegats()
        {
            estVivant = false;
        }
    }
}
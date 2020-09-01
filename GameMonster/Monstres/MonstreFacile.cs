using System;
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
        
        public virtual void attaque(Joueur joueur)
        {
            int lancerJoueur = joueur.lancerDe(26);
            int LancerMonstre =  lancerDe(26);
            if (lancerJoueur < LancerMonstre)
            {
                joueur.subirDegats(degats);
                Console.WriteLine("le mosntre vous inflige "+ LancerMonstre +" de degats");
            }
        }

        public void  subitDegats()
        {
            estVivant = false;
            Console.WriteLine(" vous avez vaincu le monstre");
        }
    }
}
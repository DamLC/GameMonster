using System;
using TPjeu.Accessoire;
using TPjeu.Armes;
using TPjeu.Protections;

namespace TPjeu.Personnages
{
    public class Boss
    {
        private De de;
        public int pointVie;
        public int sortSoins = 1;
        private Arme epee;

        public bool estVivant
        {
            get {return pointVie > 0;}
            
        }

        public int PointVie
        {
            get => pointVie;
            private set => pointVie = value;
        }

     
        public Boss( int pointVie, int espadon)
        {
            de = new De();
            this.pointVie = pointVie;
             epee = new Arme(espadon); 
        }

        public int lancerDe( int valeur)
        {
            return De.lancerDe(valeur);
        }

        public void attaque(Joueur joueur)
        {

            int degats = lancerDe(26);

            if (pointVie == 150)
            {
                Narration.changeArme();
                degats = lancerDe(26) + epee.frappe;
            }
            if (pointVie < 50 && sortSoins == 1)
            {
                Narration.soins();
                pointVie += 100;
                sortSoins--;
            }
            
            Console.WriteLine("Il  reste "+ pointVie + " PV au boss");
            DialogueBoss.effetDegatsBoss(degats);
            Console.WriteLine("Le boss vous infige "+degats+" dégats\n");
            joueur.subitDegats(degats);
        }

        public int subitDegats(int degats)
        {
            return pointVie -= degats;
            
        }

       
    }
}
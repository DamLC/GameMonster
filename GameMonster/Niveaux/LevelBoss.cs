using TPjeu.Personnages;

namespace TPjeu
{
    public class LevelBoss
    {
        public static Joueur hero ;
        public static Boss gontrand ;
        
        public static void lastStage()
        {
            Narration.boss();
            hero = CreationPersonnages.creationHero();
            Narration.enter();
            gontrand = CreationPersonnages.creationBoss();
             
            while (hero.estVivant == true && gontrand.estVivant == true)
            {
                hero.attaque(gontrand);

                if (gontrand.estVivant)
                {
                    gontrand.attaque(hero);
                }
                Narration.attaque();
            }
            if( gontrand.estVivant)
            {
                DialogueJoueur.deuxiemeMort();
                DialogueBoss.tueJoueur();
                Narration.fin3();
            }
            else
            {
                DialogueJoueur.tueBoss();
                Narration.fin2();
            }
        }
    }
}
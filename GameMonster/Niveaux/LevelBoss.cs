using System;
using TPjeu.Armes;
using TPjeu.Personnages;
using TPjeu.Protections;

namespace TPjeu
{
    public class LevelBoss
    {
        public static void lastStage()
        {
            Narration.boss();
            Narration.creationJoueur();
            Joueur hero = new Joueur(CreationPersonnages.creePV(),CreationPersonnages.creePA(), CreationPersonnages.creeDegats(), 50 );
            Narration.creationBoss();
            Boss gontrand = new Boss(CreationPersonnages.creePV(), CreationPersonnages.creeDegats());
         
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
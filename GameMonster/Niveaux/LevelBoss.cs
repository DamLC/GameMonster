using System;
using TPjeu.Armes;
using TPjeu.Classe;
using TPjeu.Personnages;
using TPjeu.Protections;

namespace TPjeu
{
    public class LevelBoss
    {
        public static Joueur hero ;
        
        public static void lastStage()
        {  
            string classe;
            
                     
                     
            Narration.boss();
          
            Console.WriteLine("Choisissez votre classe :\n" +
                              "1 > Guerrier\n" +
                              "2 > Mage\n" +
                              "3 > Archer\n" +
                              "Attention une réponse de 0 ou plus grand que 3 est à vos risques et périls");
            classe = Console.ReadLine();
            
            switch (classe)
            {
                case "1":
                {
                    Console.WriteLine("Vous avez choisi guerriers votre arme sera donc l'épée\n");
                    Narration.creationGuerrier();
                    hero = new Guerrier(CreationPersonnages.creePV(),CreationPersonnages.creePA(),CreationPersonnages.creeDegats(),CreationPersonnages.potionPv());
                    Narration.nom();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Vous avez choisi mages votre arme sera donc le baton\n");
                    Narration.creationMage();
                    hero = new Mage(CreationPersonnages.creePV(),CreationPersonnages.creePA(),CreationPersonnages.creeDegats(),CreationPersonnages.potionPv());
                    Narration.nom();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("Vous avez choisi archers votre arme sera donc l'arc\n");
                    Narration.creationArcher();
                    hero = new Archer(CreationPersonnages.creePV(),CreationPersonnages.creePA(),CreationPersonnages.creeDegats(),CreationPersonnages.potionPv());
                    Narration.nom();
                    break;
                }
                default:
                {
                    Console.WriteLine("Vous avez choisi un hero banal sans compêtence particulière\n");
                    Narration.creationJoueur();
                    hero = new Joueur(CreationPersonnages.creePVLambda(),CreationPersonnages.creePALambda(), CreationPersonnages.creeDegatsLambda());
                    Narration.nom();
                    break;
                }
            }      
            Narration.enter();
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
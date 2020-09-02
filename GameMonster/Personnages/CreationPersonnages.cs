using System;
using TPjeu.Classes;
using TPjeu.Personnages;

namespace TPjeu
{
    public class CreationPersonnages
    {
        static Joueur hero; 
         static Boss gontrand;
        
        public static Joueur creationHero()
        {
            string classe;
            
            Console.WriteLine("Choisissez votre classe :\n" +
                                          "1 > Guerrier\n" +
                                          "2 > Mage\n" +
                                          "3 > Archer\n" +
                                          "Attention toute autre reponse est à vos risques et périls");
                        classe = Console.ReadLine();

                        
                        switch (classe)
                        {
                            case "1":
                            {
                                Console.WriteLine("Vous avez choisi guerriers votre arme sera donc l'épée\n");
                                Titre.creationGuerrier();
                                hero = new Guerrier(CreationCaracteristiquePersonnage.creePV(),CreationCaracteristiquePersonnage.creePA(),CreationCaracteristiquePersonnage.creeDegats(),CreationCaracteristiquePersonnage.potionPv());
                                CreationCaracteristiquePersonnage.nom();
                                return hero;
                            }
                            case "2":
                            {
                                Console.WriteLine("Vous avez choisi mages votre arme sera donc le baton\n");
                                Titre.creationMage();
                                hero = new Mage(CreationCaracteristiquePersonnage.creePV(),CreationCaracteristiquePersonnage.creePA(),CreationCaracteristiquePersonnage.creeDegats(),CreationCaracteristiquePersonnage.potionPv());
                                CreationCaracteristiquePersonnage.nom();
                                return hero;
                            }
                            case "3":
                            {
                                Console.WriteLine("Vous avez choisi archers votre arme sera donc l'arc\n");
                                Titre.creationArcher();
                                hero = new Archer(CreationCaracteristiquePersonnage.creePV(),CreationCaracteristiquePersonnage.creePA(),CreationCaracteristiquePersonnage.creeDegats(),CreationCaracteristiquePersonnage.potionPv());
                                CreationCaracteristiquePersonnage.nom();
                                return hero;
                            }
                            default:
                            {
                                Console.WriteLine("Vous avez choisi un hero banal sans compêtence particulière\n");
                                Titre.creationJoueur();
                                hero = new Joueur(CreationCaracteristiquePersonnage.creePVLambda(),CreationCaracteristiquePersonnage.creePALambda(), CreationCaracteristiquePersonnage.creeDegatsLambda());
                                CreationCaracteristiquePersonnage.nom();
                                return hero;
                            }
                        }      
        }

        public static Boss creationBoss()
        {
             Titre.creationBoss();
              gontrand = new Boss(CreationCaracteristiquePersonnage.creePV(), CreationCaracteristiquePersonnage.creeDegats());
             return gontrand;
        }
           
    }
}
using System;
using TPjeu.Monstres;
using TPjeu.Personnages;

namespace TPjeu.Niveaux
{
    public class Level1
    {
       
         public static void stage1()
        {
            //crée le joueur 
            Joueur hero = new Joueur(150);
            int xp = 0;
            int cptFacile = 0;
            int cptDifficile = 0;

            Narration.debut();
            Narration.enter();
            
            Narration.arrivee(); 
            Narration.enter();
            
            Narration.niveau();
            Narration.enter();
            
            Narration.combat();
            Narration.enter();

            //boucle tant que le joueur est vivant
            while (hero.estVivant == true)
            {
                //creer un monstre 
                MonstreFacile monstre = FabriqueMonstre.creerMonstre();

                //boucle tant que le joueur et  le monstre est vivant 
                while (monstre.estVivant == true && hero.estVivant == true)
                {
                    hero.attaque(monstre);

                    if (monstre.estVivant)
                    {
                        monstre.attaque(hero);

                        if (hero.estVivant)
                        {
                            if (monstre is MonstreFacile)
                            {
                                cptFacile++;
                                xp += 1 ;
                            }
                            if(monstre is MonstreDifficile)
                            {
                                cptDifficile++;
                                xp += 2;
                            }
                        }
                        else
                        {
                            DialogueJoueur.mortMonstre();
                        }
                    }
                }
            }

            Console.WriteLine("Bravo! tu as tué {0} monstres faciles " +
                              " et {1} monstres difficiles. tu as gagné {2} xp.\n" 
                              , cptFacile, cptDifficile, xp);
            Joueur.levelUp(xp);
            
            Narration.enter();
            Menu.RetourMenu();
        }
    }
}
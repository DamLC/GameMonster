using System;

namespace TPjeu
{
    public class Menu
    {
        public static void choixNiveaux()
        {
            string rep = "";

            Titre.menu();
            while (rep != "1" || rep != "2" || rep != "3")
            {
                Console.WriteLine("Choississez votre niveaux \n" +
                                  "1- Combattre les monstres\n" +
                                  "2- Combattre le boss\n" +
                                  "3- prendre la fuite");
                rep = Console.ReadLine();

                if (rep == "1")
                {
                    Niveaux.Level1.stage1();

                }

                if (rep == "2")
                {
                    LevelBoss.lastStage();
                    break;
                }

                if (rep == "3")
                {
                    Console.WriteLine("Ne désespère pas!\nTu auras plus de chance la prochaine fois.");
                    Narration.fuite();
                    break;
                }
                else
                {
                    Console.WriteLine("Ce n'est pas ce qu'on ta demander '\n");
                }
            }
        }
        public static void RetourMenu()
        {
            var rep = "";
            while (rep != "o" || rep != "n")
            {
                Console.WriteLine("Souhaitez vous retourner au choix des niveaux ? o/n");
                rep = Console.ReadLine();
                if (rep == "o")
                {
                    Narration.deuxiemeChance();
                    Narration.enter();
                    choixNiveaux();
                }
                if( rep == "n")
                {
                    Narration.fin();
                    
                }
                else 
                {
                    Console.WriteLine("Ce n'est pas la bonne réponse");
                }
            }
        }
    }
}
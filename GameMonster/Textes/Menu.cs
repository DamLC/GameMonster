using System;

namespace TPjeu
{
    public class Menu
    {
        public static void choixMode()
        {
            string rep = "";

            Console.WriteLine("----------MENU-----------");

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
    }
}
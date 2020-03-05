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
                                  "1- Combattre les monstres\n " +
                                  "2- Combattre le boss\n" +
                                  "3- Quitter");
                rep = Console.ReadLine();

                if (rep == "1")
                {
                    Niveaux.Level1.stage1();
                    
                }

                if (rep == "2")
                {
                    Narration.choix();
                    break;
                }

                if (rep == "3")
                {
                    Console.WriteLine("Ne désespère pas!\nTu auras plus de chance la prochaine fois.");
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
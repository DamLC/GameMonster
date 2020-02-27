using System;

namespace TPjeu
{
    public class DialogueBoss
    {
        public static void tueJoueur()
        {
            Console.WriteLine("Boss -> Ahah^^ tu ne fais pas le poids contre moi! \n");
        }
        
         public static void effetDegatsBoss(int degats)
        {
            switch (degats)
            {
                case 1:
                {
                    Console.WriteLine("Boss -> un pas de plus et tu es mort!");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Boss -> tu vas tatter de mes poings.");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Boss -> Hmm, j'en ai mal pour toi . ");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Boss -> il va laissé des traces ce coup. ");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Boss -> Temps mort! Mon lacer est défais....et tiens, t'es trop naîf^^");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Boss -> Celui la il va faire mal. ");
                    break;
                }
                case 7:
                {
                    Console.WriteLine("Boss -> Attention ca va peut être faire un peu mal!");
                    break;
                }
                case 8:
                {
                    Console.WriteLine("Boss -> Tiens! un coup de pied bien placé.");
                    break;
                }
                case 9:
                {
                    Console.WriteLine("Boss -> Ahah! tu fais moins le malin là! ");
                    break;
                }
                case 10:
                {
                    Console.WriteLine("Boss -> Ah tu l'as pas vu venir.");
                    break;
                }
                case 11:
                {
                    Console.WriteLine("Boss -> Temps mort! Je fatigue la ....et tiens, t'es trop naîf^^");
                    break;
                }
                case 12:
                {
                    Console.WriteLine("Boss -> ... ");
                    break;
                }
                case 13:
                {
                    Console.WriteLine("Boss -> Tu vas souffrir!");
                    break;
                }
                case 14:
                {
                    Console.WriteLine("Boss -> Heu! tu as essayer de me tappé.");
                    break;
                }
                case 15:
                {
                    Console.WriteLine("Boss -> tiens, un petit coup d'élair pour la forme. ");
                    break;
                }
                case 16:
                {
                    Console.WriteLine("Boss -> Ah tu l'as senti passé celle la.");
                    break;
                }
                case 17:
                {
                    Console.WriteLine("Boss -> MDR! ca fais presque mal.");
                    break;
                }
                case 18:
                {
                    Console.WriteLine("Boss -> Celui la il va faire mal .");
                    break;
                }
                case 19:
                {
                    Console.WriteLine("Boss -> Ca piquotte un peu mais ca va!");
                    break;
                }
                case 20:
                {
                    Console.WriteLine("Boss -> Tiens! tu vas tatter de ma force.");
                    break;
                }
                case 21:
                {
                    Console.WriteLine("Boss -> Rentre chez toi tu vas te faire mal. ");
                    break;
                }
                case 22:
                {
                    Console.WriteLine("Boss -> Ah tu l'as pas vu venir.");
                    break;
                }
                case 23:
                {
                    Console.WriteLine("Boss -> Voila  avec ça, .tu pourras plus jamais macher une salade..");
                    break;
                }
                case 24:
                {
                    Console.WriteLine("Boss -> ... ");
                    break;
                }
                case 25:
                {
                    Console.WriteLine("Boss -> Tu vas souffrir!");
                    break;
                }
                case 26:
                {
                    Console.WriteLine("Boss -> Rentre chez toi tu vas te faire mal. ");
                    break;
                }
            }
        }
    }
}
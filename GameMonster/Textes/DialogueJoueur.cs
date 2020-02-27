using System;

namespace TPjeu
{
    public class DialogueJoueur
    {
        public static void esquive()
        {
            Console.WriteLine("Joueur -> Et hop! esquive!");
        }
        public static void tueBoss()
        {
            Console.WriteLine("Joueur -> Meurs donc !! Créature infame. \n");
        }
        public static void mortMonstre()
        {
            Console.WriteLine("Joueur -> Il sont trop nombreux.\n Oh mais non je vais mourir tuer par des zombies puant!\n la honte.");
        }

        public static void deuxiemeMort()
        {
            Console.WriteLine("Joueur -> AH NON MAIS C'EST PAS VRAI JE VAIS ENCORE MOURRIR !! \n ");
        }
        
         public static void effetDegatsJoueur(int degats)
        {
            switch (degats)
            {
                case 1:
                {
                    Console.WriteLine("Joueur -> Ca piquotte un peu mais ca va!"); 
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Joueur -> Ah! tu l'as pas volé celle la."); 
                    break;
                } case 3:
                {
                    Console.WriteLine("Joueur -> tiens, un petit coup de hache pour la route ."); 
                    break;
                } case 4:
                {
                    Console.WriteLine("Joueur -> Ah tu l'as senti passé celle la."); 
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Joueur -> Et BIM dans les dents."); 
                    break;
                } case 6:
                {
                    Console.WriteLine("Joueur -> Celui la il va faire mal. "); 
                    break;
                } 
                case 7:
                {
                    Console.WriteLine("Joueur -> Ca piquotte un peu mais ca va!"); 
                    break;
                }
                case 8:
                {
                    Console.WriteLine("Joueur -> Tiens! un coup de pied bien placé."); 
                    break;
                } case 9:
                {
                    Console.WriteLine("Joueur -> Arrete ou tu vas prendre une torgnolle. "); 
                    break;
                } case 10:
                {
                    Console.WriteLine("Joueur -> Ah tu l'as pas vu venir."); 
                    break;
                }
                case 11:
                {
                    Console.WriteLine("Joueur -> Temps mort! Je fatigue la ....et tiens, t'es trop naîf^^."); 
                    break;
                } case 12:
                {
                    Console.WriteLine("Joueur -> ... "); 
                    break;
                } case 13:
                {
                    Console.WriteLine("Joueur -> Tu vas souffrir!"); 
                    break;
                }  case 14:
                {
                    Console.WriteLine("Joueur -> Un coup d'épée tu m'en diras des nouvelles."); 
                    break;
                }  case 15:
                {
                    Console.WriteLine("Joueur -> tiens, un petit coup de hache pour la route ."); 
                    break;
                } case 16:
                {
                    Console.WriteLine("Joueur -> Ah tu l'as senti passé celle la."); 
                    break;
                }
                case 17:
                {
                    Console.WriteLine("Joueur -> Et BIM dans les dents."); 
                    break;
                } case 18:
                {
                    Console.WriteLine("Joueur -> Celui la il va faire mal ."); 
                    break;
                } 
                case 19:
                {
                    Console.WriteLine("Joueur -> Ah ! mais c'est dégeulasse tu pisse le sang.!"); 
                    break;
                }
                case 20:
                {
                    Console.WriteLine("Joueur -> Tiens! un coup de pied bien placé."); 
                    break;
                } case 21:
                {
                    Console.WriteLine("Joueur -> Arrete ou tu vas prendre une torgnolle. "); 
                    break;
                } case 22:
                {
                    Console.WriteLine("Joueur -> Ah tu l'as pas vu venir."); 
                    break;
                }
                case 23:
                {
                    Console.WriteLine("Joueur -> Ah ! mais c'est dégeulasse tu pisse le sang."); 
                    break;
                } case 24:
                {
                    Console.WriteLine("Joueur -> ... "); 
                    break;
                } case 25:
                {
                    Console.WriteLine("Joueur -> Tu vas souffrir!"); 
                    break;
                }  case 26:
                {
                    Console.WriteLine("Joueur -> Un coup d'épée tu m'en diras des nouvelles."); 
                    break;
                }
            }
        
        }
        
    }
}
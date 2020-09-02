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
            
                if(degats >=10 && degats <15)
                {
                    Console.WriteLine("Joueur -> Ca va piquer un peu  !"); 
                    
                }
                if(degats >=15 && degats <20)
                {
                    Console.WriteLine("Joueur -> Ah! tu l'as pas volé celle la."); 
                    
                }
                if(degats >=25 && degats <30)
                {
                    Console.WriteLine("Joueur -> tiens, un petit coup de hache pour la route ."); 
                    
                }
                if(degats >=35 && degats <40)
                {
                    Console.WriteLine("Joueur -> Ah tu l'as senti passé celle la."); 
                    
                }
                if(degats >=40 && degats <45)
                {
                    Console.WriteLine("Joueur -> Et BIM dans les dents."); 
                    
                }
                if(degats >=45 && degats <50)
                {
                    Console.WriteLine("Joueur -> Celui la il va faire mal. "); 
                    
                } 
                if(degats >=50 && degats <55)
                {
                    Console.WriteLine("Joueur -> Ca piquotte un peu mais ca va!"); 
                    
                }
                if(degats >=55 && degats <60)
                {
                    Console.WriteLine("Joueur -> Tiens! un coup de pied bien placé."); 
                    
                }
                if(degats >=60 && degats <65)
                {
                    Console.WriteLine("Joueur -> Arrete ou tu vas prendre une torgnolle. "); 
                    
                }
                if(degats >=65 && degats <70)
                {
                    Console.WriteLine("Joueur -> Tiens! un coup de pied bien placé."); 
                    
                }
                if(degats >=70 && degats <75)
                {
                    Console.WriteLine("Joueur -> Arrete ou tu vas prendre une torgnolle. "); 
                    
                }
                if(degats >=75 && degats <80)
                {
                    Console.WriteLine("Joueur -> Ah tu l'as pas vu venir."); 
                    
                }
                if(degats >=80 && degats <85)
                {
                    Console.WriteLine("Joueur -> Ah ! mais c'est dégeulasse tu pisse le sang."); 
                    
                }
                if(degats >=85 && degats <90)
                {
                    Console.WriteLine("Joueur -> ... "); 
                    
                }
                if(degats >=90 && degats <95)
                {
                    Console.WriteLine("Joueur -> Tu vas souffrir!"); 
                    
                }
                if(degats >=95 && degats <100)
                {
                    Console.WriteLine("Joueur -> Un coup d'épée tu m'en diras des nouvelles.");

                }
               
                if(degats >100)
                {
                    Console.WriteLine("Joueur -> Ah ! mais c'est dégeulasse tu pisse le sang.!"); 
                    
                }
            
        }
    }
}
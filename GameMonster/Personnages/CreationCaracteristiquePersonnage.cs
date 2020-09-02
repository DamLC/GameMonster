using System;

namespace TPjeu.Personnages
{
    public class CreationCaracteristiquePersonnage
    {
         #region Creation PV, PA et Pdegats joueur et boss
        public  static int creePV()
               {
                   int pv = 0;
                   string rep ;
                   
                   while (pv == 0 || pv < 150)
                   {
                       Console.WriteLine("Saisissez le nombre de PV ");
                       rep = Console.ReadLine();
                       Console.WriteLine("\n");
                       try
                       {
                           pv = Int32.Parse(rep);
                           if (pv == 0)
                           {
                               Console.WriteLine("impossible de mettre 0 PV\n");
                           }
                           if (pv < 150)
                           {
                               Console.WriteLine("Vous devez mettre au minimum 150PV\n");
                           }
                       }
                       catch (Exception )
                       {
                           Console.WriteLine("ce n'est pas un nombre\n");
                       }
                   }
                   return pv;
               }
       
               public static int creePA()
               {
                   int pa = 0;
                   string rep ;
                   
                   while (pa == 0 )
                   {
                       Console.WriteLine("Saisissez les points de durabilité de l'armure");
                       rep = Console.ReadLine();
                       Console.WriteLine("\n");
                       try
                       {
                           pa = Int32.Parse(rep);
                           if (pa == 0)
                           {
                               Console.WriteLine("Une armure ne peut pas avoir 0 de durabilité\n");
                           }
                       }
                       catch (Exception)
                       {
                           Console.WriteLine("ce n'est pas un nombre\n");
                       }
                   }
                   return pa;
               }
       
               public static int creeDegats()
               {
                   int deg = 0;
                   string rep ;
                               
                   while (deg == 0 || deg >= 1000)
                   {
                       Console.WriteLine("Saisissez le nombre de degats d'arme");
                       rep = Console.ReadLine();
                       Console.WriteLine("\n");
                       try
                       {
                           deg = Int32.Parse(rep);
                           if (deg == 0)
                           {
                               Console.WriteLine("une arme ne peut pas faire 0 dégats\n");
                           }
       
                           if (deg >= 1000)
                           {
                               Console.WriteLine("CHEATER !!! \n");
                           }
                       }
                       catch (Exception)
                       {
                           Console.WriteLine("ce n'est pas un nombre\n");
                       }
                   }
                   return deg;
               }
        #endregion
        
        #region Nom du personnage
        
        public static void nom()
        { string nom;
            
            Console.WriteLine("Quelle est votre nom héro ?");
            nom = Console.ReadLine();
            if (nom == " ")
            {
                Console.WriteLine("Ceci n'est pas un nom");
            }
            Console.WriteLine(value: "Création en cours ........\n" +
                                     "...........................\n" +
                                     "Ok ! Le joueur  "+ nom + " a été crée\n" +
                                     "Bonne chance, tu vas en avoir besoin\n");
        }
        #endregion
        
        #region Creation PV, PA et Pdegats mec lambda
                public  static int creePVLambda()
               {
                   int pv = 0;
                   string rep ;
                   
                   while (pv == 0 || pv > 150)
                   {
                       Console.WriteLine("Saisissez le nombre de PV ");
                       rep = Console.ReadLine();
                       Console.WriteLine("\n");
                       try
                       {
                           pv = Int32.Parse(rep);
                           if (pv == 0)
                           {
                               Console.WriteLine("impossible de mettre 0 PV\n");
                           }
                           if (pv > 150)
                           {
                               Console.WriteLine("Vous ête de santé fragile, vous ne pouvez avoir plus de 150PV\n");
                           }
                       }
                       catch (Exception )
                       {
                           Console.WriteLine("ce n'est pas un nombre\n");
                       }
                   }
                   return pv;
               }
       
               public static int creePALambda()
               {
                   int pa = 0;
                   string rep ;
                   
                   while (pa == 0 || pa >15 )
                   {
                       Console.WriteLine("Saisissez les points de durabilité de l'armure");
                       rep = Console.ReadLine();
                       Console.WriteLine("\n");
                       try
                       {
                           pa = Int32.Parse(rep);
                           if (pa == 0)
                           {
                               Console.WriteLine("Une armure ne peut pas avoir 0 de durabilité\n");
                           }
                           if (pa > 15)
                           {
                               Console.WriteLine("Votre armure est toute abimé vous ne pouvez avoir plus de 15PA\n");
                           }
                       }
                       catch (Exception)
                       {
                           Console.WriteLine("ce n'est pas un nombre\n");
                       }
                   }
                   return pa;
               }
       
               public static int creeDegatsLambda()
               {
                   int deg = 0;
                   string rep ;
                               
                   while (deg == 0 || deg >= 10)
                   {
                       Console.WriteLine("Saisissez le nombre de degats d'arme");
                       rep = Console.ReadLine();
                       Console.WriteLine("\n");
                       try
                       {
                           deg = Int32.Parse(rep);
                           if (deg == 0)
                           {
                               Console.WriteLine("une arme ne peut pas faire 0 dégats\n");
                           }
       
                           if (deg > 10)
                           {
                               Console.WriteLine("Votre épée est toute emoussé vous ne pouvez pas faire plus de 10 de dégats !!! \n");
                           }
                       }
                       catch (Exception)
                       {
                           Console.WriteLine("ce n'est pas un nombre\n");
                       }
                   }
                   return deg;
               }
        

        #endregion

        #region potion

        public static int potionPv()
        {
            int pv = 0;
            string rep ;
                   
            while (pv == 0 || pv > 50)
            {
                Console.WriteLine("Saisissez le nombre de PV de votre potion ");
                rep = Console.ReadLine();
                Console.WriteLine("\n");
                try
                {
                    pv = Int32.Parse(rep);
                    if (pv == 0)
                    {
                        Console.WriteLine("impossible de mettre 0 PV\n");
                    }
                    if (pv > 50)
                    {
                        Console.WriteLine("Nos alchimiste n'ont pas encore découvert une tel potion\n" +
                                          "potion 50 PV maximum\n");
                    }
                }
                catch (Exception )
                {
                    Console.WriteLine("ce n'est pas un nombre\n");
                }
            }
            return pv;
        }

        #endregion
    }
}
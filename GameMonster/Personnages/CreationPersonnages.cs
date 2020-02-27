using System;

namespace TPjeu
{
    public class CreationPersonnages
    {

        public  static int creePV()
        {
            int pv = 0;
            string rep ;
            
            while (pv == 0)
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
                        
            while (deg == 0)
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
                }
                catch (Exception)
                {
                    Console.WriteLine("ce n'est pas un nombre\n");
                }
            }
            return deg;
        }
    }
}
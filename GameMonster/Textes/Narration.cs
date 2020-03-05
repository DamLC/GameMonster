using System;

namespace TPjeu
{
    public class Narration
    {
        public static void creationJoueur()
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("        Création du héro\n");
            Console.WriteLine("**********************************\n");
        }
        
        public static void creationBoss()
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("        Création du boss\n");
            Console.WriteLine("**********************************\n");
        }
        
        public static void debut()
        {
            Console.WriteLine("Aprés avoir écouter les histoires d'aventure de tonton Norbert,\n " +
                              "vous décidez de partir a l'aventure a votre tour ...");
        }
        public static void arrivee()
        {
            Console.WriteLine("Aprés avoir marcher 4km vous apperçever un donjon au bout du chemin. ");
            Console.WriteLine(" Et comme un gros noob, vous décidez d'y aller TOUS seul avec un équipements\n... des plus déplorable.");
            
            
        }public static void niveau()
        {
            Console.WriteLine("Par chance vous arrivez a survivre jusqu au 3ème étages.");
            Console.WriteLine("Malheureusement ce niveau est un cimetière et dans votre malheur " +
                              "tout au fond de la salle se trouve  un nécromancien." +
                              "Il s'apprète a ramenner ces potes monstre a la vie .");
        }
        public static void combat()
        {
            Console.WriteLine("Vous saississez  votre épée semi rouillé et vous préparez au pire .");
        }
        public static void fin()
        {
            Console.WriteLine("\nTu fera mieux la prochaine fois");
            Console.WriteLine("Sponsorisé par 'MERCUROCHROME' XD");
        }
        
        public static void deuxiemeChance()
        {
            Console.WriteLine("Grace a l'amulette du couard de tonton Norbert vous ressussitez au 1er étage  \n" );
        }

        public static void boss()
        {
            Console.WriteLine("Un boss térrifiant vous fait face....");
        }
        public static void enter()
        {
            Console.WriteLine("appuyer sur 'entrer' pour continuer");
            Console.ReadLine();
        }
        public static void choix()
        {
            string choix ="";
            
            while (choix != "lancer" || choix != "ciao")
            {
                Console.WriteLine("Saisissez 'lancer' pour lancer le dé de dégats \n " +
                                  "ou 'ciao' pour prendre la fuite   ");
                choix = Console.ReadLine();

                if (choix == "lancer")
                {
                    LevelBoss.lastStage();
                    break;
                }

                if (choix == "ciao")
                {
                    fuite();
                    break;
                }
                else
                {
                    Console.WriteLine("Tu as tapper "+ choix +"\n tu sais lire on a dit 'lancer' ou 'ciao'\n");
                }
            }
        }
            
        public static void attaque()
        {
            Console.WriteLine(" 'entrer' lancer le dé de dégats  ");
            Console.ReadLine();
        }

        public static void fuite()
        {
            Console.WriteLine("Ah non! j'ai pas envie d'être poutrer par un autre monstre débile \n" +
                              "je me casse.J'aurais mieux fais de me peter une jambe ce matin.");
        }
        public static void changeArme()
        {
           
            Console.WriteLine("Enervé le boss saisie une arme pour vous frapper");
        }
        public static void fin2()
        {
            Console.WriteLine("Après un dur combat notre  hero rentre chez lui, pace que  ...");
            Console.WriteLine("c'est l'heure de la soupe faut pas déconé!");
        }
        public static void fin3()
        {
            Console.WriteLine("n'ayant  pas réussi a tuer le boss");
            Console.WriteLine("Notre hero s'envole pour le paradis des noobs");
        }


    }
    
}
using System;

namespace TPjeu
{
    public class Narration
    {
        public static void nom()
        {
            string nom;
            
            Console.WriteLine("Quelle est votre nom héro ?");
            nom = Console.ReadLine();
            Console.WriteLine(value: "Création en cours ........\n" +
                                     "...........................\n" +
                                     "Ok ! Le joueur  "+ nom + " a été crée\n" +
                                     "Bonne chance, tu vas en avoir besoin\n");
        }
        public static void creationGuerrier()
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("        Création d'un guerrier\n");
            Console.WriteLine("**********************************\n");
        }
        
        public static void creationMage()
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("        Création d'un Mage\n");
            Console.WriteLine("**********************************\n");
        }
        
        public static void creationArcher()
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("        Création d'un archer\n");
            Console.WriteLine("**********************************\n");
        }
        
        public static void creationJoueur()
        {
            Console.WriteLine("*********************************\n");
            Console.WriteLine("        Création d'un mec lambda\n");
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
       
            
        public static void attaque()
        {
            Console.WriteLine(" Appuyer sur 'entrer' pour lancer le dé de dégats  ");
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

        public static void recharge()
        {
            Console.WriteLine("Votre compêtence est rechargée " +
                              "lancer le dé de compêtence");
        }
        
        public static void competenceArcher()
        {
            Console.WriteLine("vous activez votre compêtence pluie de flêches");
            Console.WriteLine("vous bandez votre arc vers le ciel et tirez..." +
                              "Soudain une vingtaine de flêche tombe tel une pluie sur vos enemis. ");
        }

        public static void competenceMage()
        {
            Console.WriteLine("vous activez votre compêtence embrasement");
            Console.WriteLine("vous frapper le sol de votre baton..." +
                              "Soudain il se met a briller et un petit cercle de feu se forme au sol autour de votre baton " +
                              "qui s'élargie de plus en plus jusqu'a atteindre les parois de la salle en brulant tous les enemis au passage. ");
        }
        
        public static void competenceGuerrier()
        {
            Console.WriteLine("vous activez votre compêtence roue pourfendeuse ");
            Console.WriteLine("vous courrez jusqu au millieu de la salle ...et y restez immobile" +
                              "Soudain vous saisissez votre épée a deux main est commencer a tournoyer sur place," +
                              "la vitesse est tel que vous projettez des lames de vents qui blesse tous les enemis alentour ");
        }

        public static void soins()
        {
            Console.WriteLine("Le boss utilise sont sort de soins +100 PV");
        }
    }
    
}
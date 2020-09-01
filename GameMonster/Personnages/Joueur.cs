using System;
using TPjeu.Accessoire;
using TPjeu.Apptitudes;
using TPjeu.Armes;
using TPjeu.Classes;
using TPjeu.Monstres;
using TPjeu.Protections;

namespace TPjeu.Personnages
{
    public class Joueur
    {
        private De de;
        public  int pointVie;
        public int cptPopo = 1;
        
        protected Armure corps;
        protected static Arme arme;
        protected PotionVie popo;
       
        

        public bool estVivant
        {
            get {return pointVie > 0;}
            
        }

        public  int PointVie
        {
            get => pointVie;
            private set => pointVie = value;
        }

        public Joueur( int pointVie)
        {
            de = new De();
            this.pointVie = pointVie;
           
            
        }
       
        public Joueur( int pointVie, int plastron, int epee, int rouge)
        {
            de = new De();
            this.pointVie = pointVie;
            corps = new Armure(plastron);
            arme = new Arme(epee);
            popo = new PotionVie(rouge);
        }
        public Joueur(  int pointVie, int plastron, int epee)
        {
            de = new De();
            this.pointVie = pointVie;
            corps = new Armure(plastron);
            arme = new Arme(epee);
        }

       


        public int lancerDe(int valeur )
        {
            return De.lancerDe(valeur);
        }
        

        public void attaque(MonstreFacile monstre)
        {
            int lancerJoueur = lancerDe(26);
            int LancerMonstre =  monstre.lancerDe(26);
            
            Console.WriteLine("Vous avez " + PointVie + " PV");

            if (lancerJoueur >= LancerMonstre)
            {
                monstre.subitDegats();
            }
        }

        public void attaque(Boss boss)
        {
            var degats = 0;
            int deCompetence = lancerDe(10);
            
            potionDeSoins();
            Console.WriteLine("Vous avez " + PointVie + " PV");

            if (deCompetence < 5)
            {
               degats = Competences.frappeDeCompetence();
            }
            else
            {
                  degats = lancerDe(26) + arme.frappe;
            }
            Console.WriteLine("vous infigez au boss " + degats + " dégats d'arme\n");
            DialogueJoueur.effetDegatsJoueur(degats);
            boss.subitDegats(degats);
            
        }

        public void potionDeSoins()
        {
            var rep = "";

            if ( pointVie > 70 && pointVie < 100 )
            {
                switch (cptPopo)
                {
                    case 0:
                        Console.WriteLine("Domage vous n'aviez q'une potion");
                        break;
                    case 1:
                        Console.WriteLine("Vous avez " + PointVie + " PV");
                        Console.WriteLine("Vous disposez d'une potion.\nSouhaitez vous la prendre. o/n");
                        break;
                }

                rep = Console.ReadLine();
                if (rep == "o")
                {
                    soigner(pointVie);
                    Console.WriteLine("Vous prenez une potion de PV \n");
                    cptPopo--;
                }
            }
        }
        public  int subirDegats(int degats)
        {
            if (bouclier(degats) == true)
            {
                DialogueJoueur.esquive();
                return pointVie;
            }
            else
            {
                return pointVie -= degats;
            }
        }
        public int subitDegats(int degats)
        {
            if (bouclier(degats) == true)
            {
                DialogueJoueur.esquive();
                return pointVie;
            }

            if (Armure.estEntiere == true)
            {
                corps.encaisserDegats(degats, corps);
                return pointVie;
            }
            else
            {
                return pointVie -= degats;
            }
        }
        public  bool bouclier(int degats)
        {
            int score = lancerDe(6);

            if (score <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void levelUp( int xp)
        {
            if (xp < 50)
            {
                Console.WriteLine("Pas de chance tu reste lvl 1");
            }
            if (xp == 50)
            {
                Console.WriteLine("t'appelle ça combattre lvl 2 ");
            }
            if (xp > 50 && xp < 100)
            {
                Console.WriteLine(" Peut mieux faire  lvl 3");
            }
            if (xp > 100 && xp < 150)
            {
                Console.WriteLine("lvl 4 Potentiel vraiment tres caché alors! ");
            }
            if (xp > 150 && xp <200)
            {
                Console.WriteLine("C'est presque pas mal lvl 5");
            }
            if (xp > 200 && xp <250)   
            {
                Console.WriteLine(" En progrés lvl 6");
            }
            if (xp > 250 && xp <300) 
            {
                Console.WriteLine(" C'est pas grandiose tous ça  lvl 7");
            }
            if (xp > 300 && xp <350)  
            {
                Console.WriteLine(" Mouais lvl 8");
            }
            if (xp > 350 && xp <400)     
            {
                Console.WriteLine(" Au moins tu sais te servir d'un épée  lvl 9");
            }
            if (xp > 400 && xp <450)
            {
                Console.WriteLine(" A du potentiel lvl 10");
            }
            if (xp >450 && xp <500)
            {
                Console.WriteLine("  lvl 11");
            }
            if (xp > 500 && xp < 550)
            {
                Console.WriteLine("  lvl 12");
            }
            if (xp > 550 && xp < 600)
            {
                Console.WriteLine(" lvl 13");
            }
            if (xp > 600 && xp <650)
            {
                Console.WriteLine("  lvl 14");
            }
            if (xp > 650 && xp <700)   
            {
                Console.WriteLine("  lvl 15");
            }
            if (xp > 700 && xp <750) 
            {
                Console.WriteLine("  lvl 16");
            }
            if (xp > 750 && xp <800)  
            {
                Console.WriteLine("  lvl 17");
            }
            if (xp > 800 && xp <850)     
            {
                Console.WriteLine("  lvl 18");
            }
            if (xp > 850 && xp <900)
            {
                Console.WriteLine("  lvl 19");
            }
            if (xp > 900 && xp <950)     
            {
                Console.WriteLine("  lvl 20");
            }
            if (xp > 950 && xp <1000)
            {
                Console.WriteLine("  lvl 21");
            }
            if (xp > 1000)
            {
                Console.WriteLine("GG ! lvl 22");
            }
        }

        public  int soigner(int pointVie)
        {
            return this.pointVie += popo.soins;
        }
            
    }
}
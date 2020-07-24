
	Ø GameMonster 
C'est un projet en C# mode console dans un genre jeu de plateau .

		Ø Accessoires
			Ø De : la classe De contient un attribut random , un constructeur qui instancie un objet "De" avec cet attribut random Une fonction lancerDe(valeur) pour retourner un random entre 1 et cet valeur.
			
			Ø PotionVie : La classe contient un constructeur qui qui reçoit en paramètre un int qui correspond au nombre de point de vie que redonnera la potion au joueur.
			
		Ø Armes
			Ø ArmeBoss :Cet classe contient un constructeur qui reçoit en paramètre un int qui correspond au nombre de dégâts de l'arme du boss définit par l utilisateur.
			
			Ø ArmeJoueur :Cet classe contient un constructeur qui reçoit en paramètre un int qui correspond au nombre de dégâts de l'arme du joueur définit par l utilisateur.
			
	
		Ø Protections
			Ø Armure : Cet classe contient un attribut durabilité et un booléen estEntiere qui passe a false quand la durabilité de l'armure tombe a zéro. Un constructeur qui prend la durabilité en paramètre, ainsi qu'une fonction encaisserDegats qui encaisse les dégât a la place du joueur tant qu'il reste de la durabilité a l'armure.
	
		Ø Personnage :
			Ø Boss : Cet classe contient un objet De, une fonction boolean estVivant  qui passe a false quand les points de vie tombe a zéro, un constructeur  qui reçoit des point de vie et une arme en paramètre. Il a une fonction lancerDe(valeur) , une fonction attaque(Joueur joueur) qui une fois descendu a 100PV ajoute les dégâts de son arme au total du jet de dé lorsqu'il attaque le joueur, et bien sur une fonction subitDegat(int dégâts) qui soustrait les dégâts reçu a ses points de vie.
			
			Ø Joueur : Cet classe contient  un constructeur qui crée un joueur avec une épée, une armure, une potion, des point de vie et un dé.
			Il possède une fonction lancerDe(valeur), il a 2 fonction d'attaque une pour les monstre et une pour le boss. Il a également 2 fonction pour subir les dégâts, dans la deuxième qui sera utilisé contre le boss il peut activer un bouclier grâce a un booléen ou son armure peut encaisser les dégâts sinon il prendra lui-même les dégâts. Et une fonction pour utiliser la potion de soins.
			
			Ø CreationPersonnages : Cet classe contient les fonctions d'écoute saisi clavier nécessaire a la création du joueur et du boss.
	
		Ø Classes
			Ø Archer : Cet classe contient un constructeur hérité de la classe joueur permettant de créer un joueur de type archer, et une fonction skill() qui avec un lancer de dé détermine si la compétence de l’archer est utilisée.
			
			Ø Mage : : Cet classe contient un constructeur hérité de la classe joueur permettant de créer un joueur de type mage, et une fonction skill() qui avec un lancer de dé détermine si la compétence du mage est utilisée
			
			Ø Guerrier : Cet classe contient un constructeur hérité de la classe joueur permettant de créer un joueur de type guerrier, et une fonction skill() qui avec un lancer de dé détermine si la compétence du guerrier est utilisée.
			
		Ø Monstres
			Ø FabriqueMonstre : Cet classe contient une fonction creerMonstre() qui tire un random entre 0 et 2 pour déterminer la création d'un monstre facile ou difficile.
			
			Ø MonstreFacile :Cet classe contient un objet "de",un boolean "estVivant" et un int "degats" déjà défini. Le constructeur du monstre contient l'objet de et le boolean estVivant defini sur true. Il contient également un fonction attaque(Joueur joueur) qui compare le résultat du lancé de dé du joueur et du monstre, le score le plus faible reçoit les dégâts. Une fonction lancerDe()  et une fonction suibitDegats(degats) qui passe le boolean a false.  
			
			Ø MonstreDifficile : La classe hérite de monstreFacile et rajoute juste pour le monstreDifficile un fonction "sortMagique" en plus de l'attaque de base.  
			
		Ø Niveaux
			Ø Level1 : La classe  contient la fonction stage1() qui crée un nouveau joueur avec un nombre de point de vie, et 2 variable int qui serviront de compteur pour chaque monstre tué.
			Ensuite une boucle est lancée tant que le joueur est vivant on crée un monstre, a l'intérieur de cet boucle on en crée une autre tant que le joueur et le monstre sont vivant ils s'attaquent. Si le monstre est tué par le joueur son compteur est incrémenté 1 point par monstre facile 2 par difficile et on recommence tant que le joueur est vivant. Une fois mort on compte le nombre de monstre tué et le nombre de point gagné.
			
			Ø LevelBoss : La classe contient la fonction lastStage() on commence par la création de notre joueur en lui choisissant une classe cette fois on lui choisit nous même les points de vie il aura également des points d'armure, des points de dégât pour son arme est des potions de soins. Ensuite on passe a la création du boss qui a la différence du joueur n'a pas d'armure.
			Une fois nos combattant créé il vont s'affronter en lançant le dé chacun leur tour jusqu'à ce que l un des deux meurt.
			
		Ø Textes
			Ø DialogueBoss : Cet classe contient tous les dialogues du boss en fonction de sa mort, de sa victoire ou du résultat du dé lors du combat .
			
			Ø DialogueJoueur : Cet classe contient tous les dialogues du joueur en fonction de sa mort, de sa victoire ou du résultat du dé lors du combat .
			
			Ø Menu : Cet classe contient la fonction choixMode() qui permet au joueur de choisir son niveaux
			
			Ø Narration : Cet classe contient toute les fonctions de description de salle, de niveau, de déroulement de combat, etc.…
			
		Ø Program : Le programme principale contient la fonction main().

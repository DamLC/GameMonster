
## **Un projet en C# en mode console dans un genre jeu de plateau style RP.**![image](https://drive.google.com/uc?export=view&id=1XXs8drcpX371W4PCOpYW1FJXsVeAtcXd)



**Accessoires**
> - **De** : la classe De contient un attribut random, un constructeur qui instancie un objet "De" avec cet attribut random Une fonction
> lancerDe(valeur) pour retourner un random entre 1 et cette valeur.
> 
> - **PotionVie** : La classe contient un constructeur qui qui reçoit en paramètre un int qui correspond au nombre de point de vie que
> redonnera la potion au joueur.

**Armes**
> - **ArmeBoss** : Cet classe contient un constructeur qui reçoit en paramètre un int qui correspond au nombre de dégâts de l'arme du boss
> définit par l’utilisateur.
> 
> - **ArmeJoueur** : Cet classe contient un constructeur qui reçoit en paramètre un int qui correspond au nombre de dégâts de l'arme du
> joueur définit par l’utilisateur.

**Protections**
>- **Armure** : Cet classe contient un attribut durabilité et un booléen estEntiere qui passe à false quand la durabilité de l'armure tombe à zéro. Un constructeur qui prend la durabilité en paramètre, ainsi qu'une fonction encaisserDegats() qui encaisse les dégâts à la place du joueur tant qu'il reste de la durabilité a l'armure.

**Personnage** 
>- **Boss** : Cet classe contient un objet De, une fonction booléen estVivant qui passe à false quand les points de vie tombent à zéro, un constructeur qui reçoit des points de vie et une arme en paramètre. Il a une fonction lancerDe(valeur), une fonction attaque (Joueur joueur) qui une fois descendu a 100PV ajoute les dégâts de son arme au total du jet de dé lorsqu'il attaque le joueur, et bien sur une fonction subitDegat(int dégâts) qui soustrait les dégâts reçus à ses points de vie. Il possède également un sort de soins pour quand ses PV passent la barre de 50.
>
>- **Joueur** : Cet classe contient un constructeur qui crée un joueur avec une épée, une armure, une potion, des points de vie et un dé. Il possède une fonction lancerDe(valeur), il a 2 fonction d'attaque une pour les monstres et une pour le boss. Il a également 2 fonctions pour subir les dégâts, dans la deuxième qui sera utilisé contre le boss il peut activer un bouclier grâce à un booléen ou son armure pour encaisser les dégâts sinon il prendra lui-même les dégâts. Et une fonction pour utiliser la potion de soins.
>
>- **CreationPersonnages** : Cet classe contient les fonctions d'écoute saisi clavier nécessaire à la création du joueur et du boss.

**Classes**
> - **Archer** : Cet classe contient un constructeur hérité de la classe joueur permettant de créer un joueur de type archer, et une
> fonction skill() qui avec un lancer de dé détermine si la compétence
> de l’archer est utilisée.
> 
> - **Mage** : Cet classe contient un constructeur hérité de la classe joueur permettant de créer un joueur de type mage, et une fonction
> skill() qui avec un lancer de dé détermine si la compétence du mage
> est utilisée.
> 
> - **Guerrier** : Cet classe contient un constructeur hérité de la classe joueur permettant de créer un joueur de type guerrier, et une fonction skill() qui avec un lancer de dé détermine si la compétence du guerrier est utilisée.

**Monstres**
> - **FabriqueMonstre** : Cet classe contient une fonction creerMonstre() qui tire un random entre 0 et 2 pour déterminer la
> création d'un monstre facile ou difficile.
> 
> - **MonstreFacile** : Cet classe contient un objet "dé, un booléen "estVivant" et un int "dégâts" déjà défini. Le constructeur du monstre
> contient l'objet de et le booléen estVivant défini sur true. Il
> contient également une fonction attaque (Joueur joueur) qui compare le
> résultat du lancer de dé du joueur et du monstre, le score le plus
> faible reçoit les dégâts. Une fonction lancerDe() et une fonction
> suibitDegats(dégâts) qui passe le booléen a false.
> 
> - **MonstreDifficile** : La classe hérite de monstreFacile et rajoute juste pour le monstreDifficile un fonction "sortMagique" en plus de
> l'attaque de base.

**Niveaux**
> - **Level1** : La classe contient la fonction stage1() qui crée un nouveau joueur avec un nombre de point de vie, et 2 variable int qui
> serviront de compteur pour chaque monstre tué. Ensuite une boucle est
> lancée tant que le joueur est vivant on crée un monstre, à l'intérieur
> de cette boucle on en crée une autre tant que le joueur et le monstre
> sont vivant ils s'attaquent. Si le monstre est tué par le joueur son
> compteur est incrémenté 1 point par monstre facile 2 par difficile et
> on recommence tant que le joueur est vivant. Une fois mort on compte
> le nombre de monstre tué et le nombre de point gagné.
> 
> - **LevelBoss** : La classe contient la fonction lastStage() on commence par la création de notre joueur en lui choisissant une classe
> cette fois on défini nous même les points de vie il aura
> également des points d'armure, des points de dégât pour son arme et
> une potion de soin. Ensuite on passe à la création du boss a définir aussi, a la
> différence du joueur n'a pas d'armure. Une fois nos combattant créé
> ils vont s'affronter en lançant le dé chacun leur tour jusqu'à ce que
> l’un des deux meurt.

**Textes**
> - **DialogueBoss** : Cet classe contient tous les dialogues du boss en fonction de sa mort, de sa victoire ou du résultat du dé lors du   
> combat.
>    
>  - **DialogueJoueur** : Cet classe contient tous les dialogues du joueur en fonction de sa mort, de sa victoire ou du résultat du dé
> lors du combat.
>    
>  - **Menu** : Cet classe contient la fonction choixMode() qui permet au joueur de choisir son niveau    
>  
>  - **Narration** : Cet classe contient toute les fonctions de description de salle, de niveau, de déroulement de combat, etc.…

**Program** 
> Le programme principale contient la fonction main() qui exécutera le jeu.


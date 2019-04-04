# C# Classes et Objets

## Démarche d'apprentissage

**Problématique**

Utiliser le langage C# orienté objet pour créer des objets.

**Recherches d'informations**

Premièrement, il faudra aller rechercher des informations sur internet.
Pour ma part, j'ai choisi 2 sites différents :

- https://openclassrooms.com/fr/courses/2818931-programmez-en-oriente-objet-avec-c
- https://www.guru99.com/c-sharp-class-object.html

Ayant jetté un rapide coup d'oeil, ils me semblent assez complets.
(Bien entendu, cette liste n'est pas exhaustive et pourra être complétée selon les besoins)

**Création du projet**

Ensuite il faut créer le projet. Pour ma part, j'utilise Visual Studio 2017 et je
crée un projet en mode console où je créerais les différentes classes/objets.

Avec l'invite de commande, je créer un dossier git pour gérer le code et avec cela j'y
ajoute un fichier README.md ainsi qu'un .gitignore pour ne push que les dossiers souhaités.

Une fois cela fait, je vais mettre le repository à l'aide de l'invite de commande pour
pouvoir envoyer une première version de mon projet sur github.

Une fois cela fait, je vais commencer à créer mes objets ou classes.

**Création d'une classe pour créer un objet**

(A savoir que l'on crée un classe et que à partir de cette dernière, nous créons plusieurs objets
qui auront les caractéristiques de cette classe. Il est même possible des créer des sous-classes.)

Il faut aller sur le nom du projet, faire un clique droit et choisir : ajouter, classe...
et une classe liée à ce projet sera créée.

On va ensuite créer ce qu'il faut dans la classe à l'aide des méthodes get et set et en 
y ajoutant si c'est public ou private et le style de la classe (string, int,...).
Le tout se trouve dans le commit nommée "Ma première classe". Je vous laisse aller
y jetter un oeil. Des commentaires expliques le tout.

**Amélioration de la Classe**

Nous avons donc créer notre classe Personnage et dans le main de notre programme, nous avons
créé un Objet nommée "BlackJack" avec un ID 1, qui reprend donc la classe Personnage.

Il faudrait améliorer notre classe pour que cela donne quelque chose de plus joli et modifier
les variables pour gérer les accès public ou privé avec get et set.

J'ai donc mis le variable en public pour get et private pour set. A cet effet, on pourra
prendre la variable avec get même en dehors de la classe. Par contre avec le set, comme il
est en privé, il ne sera accessible que dans la classe et don modifiable qu'au sein de cette
dernière. Si on veut pouvoir le modifier en dehors de celle-ci il va alors falloir créer une 
fonction permettant de la modifier, comme dans l'initialisation du personnage.
Il existe néanmoins une troisième fonction qui est protected. Avec celle-ci on a la possiblité
de modifier la variable dans une autre classe.

**Création d'une seconde Classe**

Créons maintenant une autre classe nommée "Arme". Parce que pour le moment ils utilisent leurs
poings...
La classe est crée comme la Personnage et ensuite dans la création d'une classe Personnage j'y
intégre la classe Arme comme objet. Avec cela, notre personnage portera un objet arme !

Et je modifie l'attaque d'un personnage pour qu'il attaque avec une arme et je change aussi
le main (je crée une fonction qui retourne le nom et les dégâts de l'arme puisque les 
variables sont en privées).

Je crée une autre fonction car l'elfe va utliser la magie avec son bâton et ses dégâts
seront en conséquence de son intelligence, le nain au contraire va utiliser sa force.
Dorénavant nous pouvons les faire se combattre avec leur arme en modifiant encore un petit
peu le fichier main.

Et voilà ! Nous venons d'utiliser un objet à l'intérieur d'un objet ! Ce processus est
appelé une "association" !

# C# Classes et Objets

## D�marche d'apprentissage

**Probl�matique**

Utiliser le langage C# orient� objet pour cr�er des objets.

**Recherches d'informations**

Premi�rement, il faudra aller rechercher des informations sur internet.
Pour ma part, j'ai choisi 2 sites diff�rents :

- https://openclassrooms.com/fr/courses/2818931-programmez-en-oriente-objet-avec-c
- https://www.guru99.com/c-sharp-class-object.html

Ayant jett� un rapide coup d'oeil, ils me semblent assez complets.
(Bien entendu, cette liste n'est pas exhaustive et pourra �tre compl�t�e selon les besoins)

**Cr�ation du projet**

Ensuite il faut cr�er le projet. Pour ma part, j'utilise Visual Studio 2017 et je
cr�e un projet en mode console o� je cr�erais les diff�rentes classes/objets.

Avec l'invite de commande, je cr�er un dossier git pour g�rer le code et avec cela j'y
ajoute un fichier README.md ainsi qu'un .gitignore pour ne push que les dossiers souhait�s.

Une fois cela fait, je vais mettre le repository � l'aide de l'invite de commande pour
pouvoir envoyer une premi�re version de mon projet sur github.

Une fois cela fait, je vais commencer � cr�er mes objets ou classes.

**Cr�ation d'une classe pour cr�er un objet**

(A savoir que l'on cr�e un classe et que � partir de cette derni�re, nous cr�ons plusieurs objets
qui auront les caract�ristiques de cette classe. Il est m�me possible des cr�er des sous-classes.)

Il faut aller sur le nom du projet, faire un clique droit et choisir : ajouter, classe...
et une classe li�e � ce projet sera cr��e.

On va ensuite cr�er ce qu'il faut dans la classe � l'aide des m�thodes get et set et en 
y ajoutant si c'est public ou private et le style de la classe (string, int,...).
Le tout se trouve dans le commit nomm�e "Ma premi�re classe". Je vous laisse aller
y jetter un oeil. Des commentaires expliques le tout.

**Am�lioration de la Classe**

Nous avons donc cr�er notre classe Personnage et dans le main de notre programme, nous avons
cr�� un Objet nomm�e "BlackJack" avec un ID 1, qui reprend donc la classe Personnage.

Il faudrait am�liorer notre classe pour que cela donne quelque chose de plus joli et modifier
les variables pour g�rer les acc�s public ou priv� avec get et set.

J'ai donc mis le variable en public pour get et private pour set. A cet effet, on pourra
prendre la variable avec get m�me en dehors de la classe. Par contre avec le set, comme il
est en priv�, il ne sera accessible que dans la classe et don modifiable qu'au sein de cette
derni�re. Si on veut pouvoir le modifier en dehors de celle-ci il va alors falloir cr�er une 
fonction permettant de la modifier, comme dans l'initialisation du personnage.
Il existe n�anmoins une troisi�me fonction qui est protected. Avec celle-ci on a la possiblit�
de modifier la variable dans une autre classe.

**Cr�ation d'une seconde Classe**

Cr�ons maintenant une autre classe nomm�e "Arme". Parce que pour le moment ils utilisent leurs
poings...
La classe est cr�e comme la Personnage et ensuite dans la cr�ation d'une classe Personnage j'y
int�gre la classe Arme comme objet. Avec cela, notre personnage portera un objet arme !

Et je modifie l'attaque d'un personnage pour qu'il attaque avec une arme et je change aussi
le main (je cr�e une fonction qui retourne le nom et les d�g�ts de l'arme puisque les 
variables sont en priv�es).

Je cr�e une autre fonction car l'elfe va utliser la magie avec son b�ton et ses d�g�ts
seront en cons�quence de son intelligence, le nain au contraire va utiliser sa force.
Dor�navant nous pouvons les faire se combattre avec leur arme en modifiant encore un petit
peu le fichier main.

Et voil� ! Nous venons d'utiliser un objet � l'int�rieur d'un objet ! Ce processus est
appel� une "association" !

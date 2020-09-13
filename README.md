# Scriptable Objects Unity Demo
Ce répertoire GitHub est celui utilisé dans la vidéo réalisée par [TUTO UNITY FR](https://www.youtube.com/c/tutounityfr) :

*__Scriptable Objects (Unity) : Qu'est ce que c'est ? Comment les utiliser ?__*

[![Vidéo Scriptable Objects](https://www.tutounity.fr/upload/github/scriptable-objects/miniature.jpg "Miniature de la vidéo")](https://www.youtube.com/watch?v=pZ-iG4XUE7E)

Vous retrouverez dans ce repo deux exemples d'utilisation des Scriptable Objects sur Unity.

## Exemple 1 : Ennemis

![Demo Ennemis](https://www.tutounity.fr/upload/github/scriptable-objects/Demo01.jpg)

Dans ce premier exemple, on a un fichier par ennemi. Ce fichier (basé sur un scriptable object) contient toutes les données de chacun des ennemis (nom, description, dégâts, vitesse, etc.).

Nous avons un script générique présent sur tous nos ennemis. En passant un fichier d'ennemi (EnemyData) à ce script générique, ce dernier pourra faire apparaître le modèle 3D de l'ennemi, le configurer et lui assigner les bonnes caractéristiques.

Il suffit donc de créer un fichier EnemyData, lui assigner les informations de l'ennemi et de glisser ce scriptable object sur le template d'ennemi.

## Exemple 2 : Jeu de cartes

![Demo Ennemis](https://www.tutounity.fr/upload/github/scriptable-objects/Demo02.jpg)

Dans ce deuxième exemple, on a un fichier par carte. Ce fichier (basé sur un scriptable object) contient toutes les données de chacune des cartes (coût, nom, attaque, vie, etc.)

Nous avons un script générique présent sur tous nos templates de carte. En passant un fichier de carte (CardData) à ce script générique, ce dernier configurera automatiquement toutes les informations de la carte en les envoyant au UI.

Il suffit donc de créer un fichier CardData, lui assigner les caractéristiques de votre choix et de glisser ce fichier issu d'un scriptable object sur le template de carte.

## Différences avec la vidéo de présentation
Certaines ressources utilisées dans la vidéo originale sont protégées par le droit d'auteur (modèles 3D, images, police d'écriture, etc.)

C'est pourquoi j'ai dû remplacer certaines de ces ressources par d'autres, qui elles, sont libres de droits. (Voir section ci-dessous pour les liens)

## Crédits

#### Ressources utilisées
Photo Gandalf (barskefranck) : https://pixabay.com/fr/photos/gandalf-seigneur-des-anneaux-cosplay-4510395/

Photo Nain (Alexas_Fotos) : https://pixabay.com/fr/photos/imp-mignon-dr%C3%B4le-figure-douce-3698785/

Photo Chevalier Noir (Yuri_B) : https://pixabay.com/fr/photos/knight-moyen-%C3%A2ge-armure-crois%C3%A9-3002031/

Fond de carte HearthStone (Blizzard Ent.) : https://www.blizzard.com/

Modèles 3D et animation de marche : https://www.mixamo.com/

# Medical-office-management-system
## 1- Objectif :
La réalisation d’une application de la gestion des RDV d’un cabinet médical
## 2- Fonctionnement :
* Le patient cherche le médecin selon le nom, la spécialité ou la ville.
* La gestion des rendez-vous est une tâche essentielle du médecin, celle-ci vérifie la disponibilité
de la date demandée et par la suite il ajoute un rendez-vous en saisissant les renseignements
nécessaires.
* Le médecin contient toutes les fonctionnalités, il peut accéder à n'importe quelles tâches.
* Le patient peut prendre un rendez-vous après son authentification

## 3- Conception du système :

Médecin : gère les rendez-vous
Patient : Prendre des rendez-vous
Secrétaire : gère les rendez-vous

![image](https://user-images.githubusercontent.com/78508211/210516113-e3e48533-a044-4bdb-8280-28a69a00cf68.png)
Le modèle relationnel :

Un patient peut prendre rendez-vous chez un médecin spécifié à une date spécifiée.
Un médecin aura un ou plusieurs rendez-vous dans le même jour.
Un RDV peut être pris par un patient chez un médecin.
![image](https://user-images.githubusercontent.com/78508211/210516326-32ed4110-311c-4864-8b6b-744d072afd0a.png)

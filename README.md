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
  * Le modèle relationnel :

Un patient peut prendre rendez-vous chez un médecin spécifié à une date spécifiée.
Un médecin aura un ou plusieurs rendez-vous dans le même jour.
Un RDV peut être pris par un patient chez un médecin.
![image](https://user-images.githubusercontent.com/78508211/210516326-32ed4110-311c-4864-8b6b-744d072afd0a.png)  
  ## 4- Réalisations :
  Une fois l'application lancée elle affiche un écran d'accueil qui permet à l'utilisateur de selectionner de quel types d'utilisateurs il s'agit pour ensuite afficher les fonctinalité de gestion correspondante à chacun
  ![image](https://user-images.githubusercontent.com/78508211/210518499-8235215d-a2b4-49ff-bbd8-6541a9622960.png)  
  * Si je suis un medecin:
  je peux pas accéder aux fonctionalités avant de m'authentifier :  
  ![image](https://user-images.githubusercontent.com/78508211/210519633-9ca584e1-9766-4227-bd89-b99c2ad35997.png)  
  ![image](https://user-images.githubusercontent.com/78508211/210519898-71bfec37-7e2e-432a-9297-e640a823bd44.png)  
  ![image](https://user-images.githubusercontent.com/78508211/210520448-a212b5e9-a788-4511-ab60-396322d5a8c4.png)
J'accede par la suite à une liste de tous les rendez-vous programmé  
![image](https://user-images.githubusercontent.com/78508211/210521070-859f1391-7def-4894-9cde-b01550dc66b4.png)  
je peux chercher les rendez vous d'un patient par le code patient ou par son nom et prenom:
![image](https://user-images.githubusercontent.com/78508211/210520976-516b142b-0263-4580-94ff-991b9eb2687d.png)  
je peux aussi modifier un rendez vous.
si deux rdv s'interferent alors la modification est imposible:
![image](https://user-images.githubusercontent.com/78508211/210522191-e320eed0-7222-440b-ab80-2830f04f2094.png)
* Si je suis un medecin:
  je peux pas accéder aux fonctionalités avant de m'authentifier :
  ![image](https://user-images.githubusercontent.com/78508211/210523093-4d2a10e2-9e78-4bc4-b74e-b79409ac5cec.png)
  ![image](https://user-images.githubusercontent.com/78508211/210523368-abf85ac9-069c-423d-81dc-588e0070f950.png)  
  Ainsi j'aurai toute une liste de medecins avec leurs informations associés  
  ![image](https://user-images.githubusercontent.com/78508211/210523821-47484145-99b6-4f2d-b186-ab16f6c61b2e.png)  
  Je peux alors chercher un medecin par soit la ville, la spécialité, le nom ou le prénom :  
  ![image](https://user-images.githubusercontent.com/78508211/210524109-92a8b54d-ec4c-4ad7-909c-2461540a0f50.png)  
  Je peux par exemple chercher tous les medecins qui sont sur Agadir  
  ![image](https://user-images.githubusercontent.com/78508211/210524458-d2bf4882-2aed-4ec7-ad3e-e24028ea1063.png)  
  ou meme tous les medecins generalistes  
  ![image](https://user-images.githubusercontent.com/78508211/210524659-da1e2819-7c31-4396-a8b8-c0a6f2690134.png)  
Je peux sois fixer un rendez vous avec l'un de ses medecins:  
![image](https://user-images.githubusercontent.com/78508211/210530852-b745bf7b-f03a-4df8-b0d4-42cd1cb902cb.png)  
Si le medecin est disponible à cette datte le rdv sera crée sinon un message disant de choisir une autre date s'affichera:  
![image](https://user-images.githubusercontent.com/78508211/210531173-4db5c7e2-b9eb-4654-92bb-44006b029e20.png)  
Je peux aussi afficher tous mes rendez-vous:   
![image](https://user-images.githubusercontent.com/78508211/210530432-ba0e8d78-0ce6-4caf-83b4-77b8441d28a7.png)    
et chercher par date un rdv:  
![image](https://user-images.githubusercontent.com/78508211/210531354-1de28829-d0cf-46c1-a573-7124882b2433.png)








  






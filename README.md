Ce dev permet de tester l'authentification via Entra fourni par Microsoft en remplacement de Azure AD B2C.
Ce dev est en asp.net core 8

Pour tester:
- lancer le dev backend
- aller sur la page swagger : https://localhost:49225/swagger/index.html
- tester SecureData sans authorisation: Error: response status is 401
- Cliquer sur Authorize. Dans la fenêtre modale, cliquer sur api://08a8abe8-eabf... ouis Authorize
- Le bouton Logout apparaît, on peut alors fermer (Close) la fenêtre d'authorization.
- rééxécuter SecureData: "message": "Vous êtes authentifié via Entra !"


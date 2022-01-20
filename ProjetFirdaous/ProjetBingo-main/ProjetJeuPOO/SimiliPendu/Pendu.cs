using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class Pendu : IPendu
    {
        ListeDeMots listeMots = new ListeDeMots();
        public Pendu()
        {

        }

        public void AfficherGagnant()
        {
            throw new NotImplementedException();
        }

        public void Jouer()
        {
            throw new NotImplementedException();
        }

        public void Start2()
        {
            string temporaire = "";
            string mot = listeMots.GetMotauHasard();
            Console.WriteLine(mot);
            char[] motsChar = mot.ToCharArray();
            char[] motsChar2 = mot.ToCharArray();
            int i = 0;
            int k = 0;

            for (i = 0; i < motsChar2.Length; i++)
            {
                motsChar2[i] = '_';
            }
            do
            {
                Console.WriteLine(motsChar2);
                Console.WriteLine("veuillez entrer une lettre");
                char lettre = Convert.ToChar(Console.ReadLine());
               // string temporaire = new string(motOriginal);  je l'ai ajouté mais ilne marche pas 
                temporaire = motsChar.ToString();
                

                if (temporaire.Contains(lettre) == true)
                {

                    for (int j = 0; j < motsChar2.Length; j++)
                    {
                        if (motsChar[j] == lettre)
                        {
                            motsChar2[j] = lettre;                            
                        }
                    }
                    Console.WriteLine(motsChar2);
                }
                else if (motsChar.ToString().Contains(lettre) == false)
                {
                    k++;                    
                }
            }
              while (k <3);
            
        }
}   }
                
          
            // FAire un doublon de la variable mot *** v

                //Transformer le doublon en caractères - - - - - - v

                // Afficher le mot caché v

                // Demander à l'utilisateur de saisir une lettre v

                //vérifier si la lettre saisir est dans le mot 

                //Si la lettre est dans le mot alors on change le tiret par la lettre

                //Afficher le mot avec la lettre trouvé




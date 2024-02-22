namespace QuizzCapitales
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("QUIZZ sur les Capitales\n");

      // Définitions des pays
      string?[] pays =
      {
        "Albanie",
        "Allemagne",
        "Andorre",
        "Autriche",
        "Belgique",
        "Biélorussie",
        "Bosnie-Herségovine",
        "Bulgarie",
        "Chypre",
        "Croatie"
      };

      // Définitions des Captiales
      string?[] capitales =
      {
        "Tirana",
        "Berlin",
        "Andorre-la-Vieille",
        "Vienne",
        "Bruxelles",
        "Minsk",
        "Sarajevo",
        "Sofia",
        "Nicosie",
        "Zagreb"
      };

      // Initialisation de mes variables
      string? reponse = string.Empty;
      int score = 0;
      bool continuer = true;

      while (continuer)
      {
        // Boucle sur les pays
        for (int i = 0; i < pays.Length; i++)
        {
          // Demande à l'utilisateur de saisir le nom de la capitale selon le pays concerné
          Console.WriteLine($"Question n° {i + 1}/10");
          Console.WriteLine($"Quel est la capitale du pays suivant: {pays[i]}");

          reponse = Console.ReadLine(); // Stock ici le résultat de la saisie utilisateur

          if (reponse == capitales[i])
          {
            Console.WriteLine("Bravo !\n");
            score++;
          }
          else
          {
            Console.WriteLine($"Mauvaise réponse, la bonne réponse était: {capitales[i]}\n");
          }

        } // end for pays

        Console.WriteLine($"Votre score final est: {score}/{pays.Length}\n");
        Console.WriteLine("Souhaitez-vous rejouer une partie (O/N) ?");
        string? reponsePourContinuerLeJeu = Console.ReadLine();

        switch (reponsePourContinuerLeJeu)
        {
          case "n":
          case "N":
            continuer = false;
            Console.WriteLine("\nMerci d'avoir pris le temps de jouer !");
            break;

          default:
            continuer = true;
            score = 0;
            Console.Clear();
            break;
        }
      }
    }
  }
}
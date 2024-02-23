using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCapitales
{
  internal class Quizz
  {

    static string?[] pays = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie-Herségovine", "Bulgarie", "Chypre", "Croatie" }; // Définitions des pays    
    static string?[] capitales = { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb" }; // Définitions des Captiales

    /**
     * =====================================================================================================================================
     * METHODES UTILITAIRES
     * =====================================================================================================================================
     **/

    /// <summary>
    /// Permet de poser une question au joueur afin qu'il saisisse un indice qui sera une référence à la question posé.
    /// </summary>
    /// <param name="questionNumber"></param>
    /// <returns>boolean</returns>
    static bool PoserQuestion(int numQuestion)
    {
      Console.WriteLine($"\nQuelle est la capitale du pays suivant: {pays[numQuestion]} ?");
      string? reponseCapitale = Console.ReadLine();

      if (reponseCapitale == capitales[numQuestion])
      {
        Console.WriteLine("Bravo !");
        return true;
      }
      else
      {
        Console.WriteLine($"Mauvaise réponse, la bonne réponse était {capitales[numQuestion]}");
        return false;
      }
    }

    /// <summary>
    /// Permet de demander à un joueur de recommencer le jeu. En fonctione la réponse soit on recommence soit on quitte le jeu.
    /// </summary>
    /// <param name="continuer"></param>
    /// <returns></returns>
    static bool DemanderSiRejouer()
    {
      Console.WriteLine("Voulez-vous rejouer une partie (O/N) ?");
      string? reponseRejouer = Console.ReadLine();

      switch (reponseRejouer)
      {
        case "n":
        case "N":
          Console.WriteLine("\nMerci d'avoir joué, à bientôt");
          return false;

        default:
          Console.Clear();
          return true;
      }
    }

    /**
     * =====================================================================================================================================
     * METHODES - DIFFERENTS JEUX
     * =====================================================================================================================================
     **/

    /// <summary>
    /// Jouer normalement
    /// Permet de jouer au jeu avec la configuration d'origine
    /// </summary>
    public static void Jouer()
    {
      Console.WriteLine("QUIZZ sur les Capitales\n");

      bool continuer = true;
      int score = 0;
      while (continuer)
      {
        // Boucle sur les pays
        for (int i = pays.Length - 1; i >= 0; i--)
        {
          bool resultatQuestion = PoserQuestion(i);
          if (resultatQuestion) score++;
        }

        Console.WriteLine($"\nNombre de bonnes réponses : {score}/{pays.Length}");
        continuer = DemanderSiRejouer();
      }
    }

    /// <summary>
    /// Permet de jouer au jeu avec cette fois-ci des paramètres passé à la fonction
    /// </summary>
    /// <param name="numQuestions"></param>
    public static void Jouer(params int[] numQuestions)
    {
      Console.WriteLine("QUIZZ sur les Capitales - Mode personalisé\n");

      bool continuer = true;
      int score = 0;
      while (continuer)
      {
        foreach (int num in numQuestions)
        {
          if (num > 0 && num <= pays.Length)
          {
            bool resultatQuestion = PoserQuestion(num - 1);
            if (resultatQuestion) score++;
          }
        }
        Console.WriteLine($"\nNombre de bonnes réponses : {score}/{numQuestions.Length}");
        continuer = DemanderSiRejouer();
      }
    }
  }
}

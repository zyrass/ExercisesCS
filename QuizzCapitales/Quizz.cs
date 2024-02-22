using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCapitales
{
  internal class Quizz
  {

    // Compteur de bonnes réponses
    static int score = 0;

    // Définitions des pays
    static string?[] pays =
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
    static string?[] capitales =
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

    /// <summary>
    /// Permet de jouer au jeu
    /// </summary>
    public static void Jouer()
    {
      Console.WriteLine("QUIZZ sur les Capitales\n");



      // Initialisation de mes variables
      string? reponse = string.Empty;
      int score = 0;
      bool continuer = true;

      while (continuer)
      {

        // Boucle sur les pays
        for (byte i = 0; i < pays.Length; i++)
        {
          bool resultatQuestion = PoserQuestion(i);
          if (resultatQuestion) score++;
        }

        Console.WriteLine($"\nVotre score final est: {score}/{pays.Length}");
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

    static bool PoserQuestion(byte questionNumber)
    {
      Console.WriteLine("\nA choississez un indice entre 0 et 9 qui correspondra à une question ?");
      byte reponseNumeroQuestion = byte.Parse(Console.ReadLine());

      Console.WriteLine($"Question n°{questionNumber + 1}, vous avez choisi l'indice n°{reponseNumeroQuestion} - Quel est la capitale du pays suivant ({pays[reponseNumeroQuestion]})");
      string? reponseSaisitCapitale = Console.ReadLine();

      if (reponseSaisitCapitale == capitales[reponseNumeroQuestion])
      {
        Console.WriteLine("Bravo !");
        return true;
      }
      else
      {
        Console.WriteLine($"Mauvaise réponse, la bonne réponse était {capitales[reponseNumeroQuestion]}");
        return false;
      }
    }
  }
}

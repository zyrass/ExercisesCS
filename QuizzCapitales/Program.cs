namespace QuizzCapitales
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Première version du jeu : toutes les questions sont posés.
      // Quizz.Jouer();

      // Seconde version du jeu : N'est posé que les questions passé en paramètre.
      // Les numéros invalide seront ignoré dans le jeu
      // Quizz.Jouer(12, 5, 18, 31, 3);

      // Troisième version du jeu : Le seul changement est lié à la génération des trois nombre aléatoire
      // (int nombre1, int nombre2, int nombre3) = Quizz.Générer3Numéros();
      // Quizz.Jouer(nombre1, nombre2, nombre3);

      // Quatrième version du jeu : Demandé à un joueur de saisir 3 numéros
      (int num1, int num2, int num3) nombreSaisie = Quizz.Saisir3Numéros();
      Quizz.Jouer(nombreSaisie.num1, nombreSaisie.num2, nombreSaisie.num3);
    }
  }
}
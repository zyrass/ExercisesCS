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
      Quizz.Jouer(12, 5, 18, 31, 3);
    }
  }
}
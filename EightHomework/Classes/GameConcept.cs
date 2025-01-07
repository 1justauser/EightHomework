namespace EightHomework
{
    internal abstract class GameConcept : IGame
    {
        #region Fields
        static readonly Games game = Games.Sea;
        #endregion
        #region Game Methods
        public virtual void Play(Country country)
        {
            Console.WriteLine(country.ToString()+" is going to play " + ToString());
            int score = 0;
            for (int i = 0; i < country.Participants.Length; i++)
            {
                if (IsWon())
                {
                    Console.WriteLine(country.Participants[i].ToString() + " is won!");
                    score++;
                }
                else
                {
                    Console.WriteLine(country.Participants[i].ToString() + " is lost(((");
                }
            }
            Console.WriteLine(country.ToString()+"'s team "+"total score in " + game.ToString() + " is " + score);
            country.AddScore(score);
        }
        public static bool IsWon()
        {
            Random _random = new Random();
            return _random.Next(0, 2) == 0;
        }
        #endregion
        #region ToString override Method
        public override string ToString() 
        { 
            return game.ToString();
        }
        #endregion
    }
}

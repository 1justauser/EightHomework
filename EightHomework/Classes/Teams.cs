using System.Runtime.CompilerServices;

namespace EightHomework
{
    internal sealed class Teams
    {
        #region Fields
        private static Russia? _instanceRussia;
        private static France? _instanceFrance;
        private static China? _instanceChina;
        private static Kazakhstan? _instanceKazakhstan;
        private static readonly object _lockRussia = new object();
        private static readonly object _lockFrance = new object();
        private static readonly object _lockChina = new object();
        private static readonly object _lockKazakhstan = new object();
        private List<IGame> games;
        private List<Country> countries = new List<Country>();
        #endregion
        #region Constructor Methods
        private Teams() { }
        internal Teams(List<IGame> games)
        {
            this.games = games;
        }
        #endregion
        #region Properties
        internal static Russia InstanceRussia
        {
            get
            {
                lock (_lockRussia)
                {
                    if (_instanceRussia == null)
                    {
                        _instanceRussia = new Russia(Countries.Russia, IsAuto(Countries.Russia));
                    }
                    return _instanceRussia;
                }
            }
        }

        internal static France InstanceFrance
        {
            get
            {
                lock (_lockFrance)
                {
                    if (_instanceFrance == null)
                    {
                        _instanceFrance = new France(Countries.France, IsAuto(Countries.France));
                    }
                    return _instanceFrance;
                }
            }
        }

        internal static China InstanceChina
        {
            get
            {
                lock (_lockChina)
                {
                    if (_instanceChina == null)
                    {
                        _instanceChina = new China(Countries.China, IsAuto(Countries.China));
                    }
                    return _instanceChina;
                }
            }
        }

        internal static Kazakhstan InstanceKazakhstan
        {
            get
            {
                lock (_lockKazakhstan)
                {
                    if (_instanceKazakhstan == null)
                    {
                        _instanceKazakhstan = new Kazakhstan(Countries.Kazakhstan, IsAuto(Countries.Kazakhstan));
                    }
                    return _instanceKazakhstan;
                }
            }
        }
        #endregion
        #region Game Methods
        private static bool IsAuto(Countries country)
        {
            Console.WriteLine("Is Team creation for " + country.ToString() + " would be automatic?(Y/n)");
            if (Console.ReadLine()! == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void AddGame(IGame game)
        {
            games.Add(game);
        }
        private void SetTeams()
        {
            countries = new List<Country>();
            if (_instanceChina != null)
            {
                countries.Add(_instanceChina);
            }
            if (_instanceRussia != null)
            {
                countries.Add(_instanceRussia);
            }
            if (_instanceFrance != null)
            {
                countries.Add(_instanceFrance);
            }
            if (_instanceKazakhstan != null)
            {
                countries.Add(_instanceKazakhstan);
            }
        }
        internal void BigRaces()
        {
            SetTeams();
            if (games.Count == 0)
            {
                Console.WriteLine("There is no games to play!"); 
                return;
            }
            if (countries.Count == 0)
            {
                Console.WriteLine("This time there is no teams to play!");
                return;
            }
            if (countries.Count == 1)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine($"This time there is only one team {country.ToString()}");
                }
                return;
            }
            Console.WriteLine("Let's start Big races!");
            foreach (var game in games)
            {
                GameContext concept = new GameContext(game);
                Console.WriteLine($"Time to play {game.ToString()}!");
                foreach (Country country in countries)
                {
                    concept.PlayingProcess(country);
                }
            }
            Console.WriteLine("\n\n");
            foreach (Country country in countries)
            {
                Console.WriteLine(country.ToString() + "'s score is " + country.Score);
            }
            Country winner = countries.MaxBy(country => country.Score);
            Console.WriteLine($"As a result this time winner is {winner.ToString()}");
        }
        #endregion
    }

}

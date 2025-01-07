namespace EightHomework
{
    internal class GameContext
    {
        #region Fields
        private IGame? _game;
        #endregion
        #region Methods
        public GameContext(IGame game)
        {
            _game = game;
        }
        public void PlayingProcess(Country country)
        {
            if (_game != null)
            {
                _game.Play(country);
            }
        }
        #endregion
    }
}

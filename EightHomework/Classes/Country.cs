namespace EightHomework
{
    internal abstract class Country
    {
        #region Fields
        protected Countries country;
        protected Participant[] participants;
        protected int score = 0;
        #endregion
        #region Properties
        public int Score
        {
            get { return score; }
        }
        public Participant[] Participants
        {
            get { return participants; }
        }
        #endregion
        #region Constructor Methods
        protected Country(Countries country, bool autoCreation)
        {
            this.country = country;
            participants = new Participant[15];
            Console.WriteLine("Let's create Team for " + country.ToString());
            for (int i = 0; i < participants.Length; i++)
            {
                participants[i] = new Participant(autoCreation, country);
            }
        }
        #endregion
        #region ToString override Method
        public override string ToString()
        {
            return country.ToString();
        }
        #endregion
        #region Game Methods
        public void AddScore(int score)
        {
            this.score += score;
        }
        #endregion
    }
}

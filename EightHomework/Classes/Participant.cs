namespace EightHomework
{
    internal class Participant
    {
        #region Fields
        private readonly string firstName;
        private readonly string lastName;
        private Countries country;
        #endregion
        #region Methods
        public Participant(bool autoCreation, Countries country)
        {
            if (autoCreation)
            {
                this.firstName = "Victor";
                this.lastName = "Zaripov";
                this.country = country;
                Console.WriteLine(ToString());
            }
            else
            {
                Console.WriteLine("Write First name and Last name for Participant");
                this.firstName = Console.ReadLine();
                this.lastName = Console.ReadLine();
                this.country = country;
                Console.WriteLine(ToString());
            }
                
        }
        public override string ToString()
        {
            return "Participant" + " " + firstName + " " + lastName + " From " + country.ToString();
        }
        #endregion
    }
}

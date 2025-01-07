namespace Tumakov
{
    internal sealed class Circle : Point, IAreaValue
    {
        #region Fields
        private double radius;
        #endregion
        #region Constuctor Methods
        public Circle(double radius, double x, double y, Visability visability, Color color) : base(x, y, visability, color)
        {
            figureType = FigureType.circle;
            if (radius <= 0)
            {
                this.radius = -1;
                Console.WriteLine("Radius is undefined");
            }
            else
            {
                this.radius = radius;
            }
        }
        public Circle() : base()
        {
            figureType = FigureType.circle;
            radius = -1;
        }
        #endregion
        #region Circle Methods
        public double AreaValue() 
        {
            if (radius == -1)
            {
                return -1;
            }
            return Math.PI * Math.Pow(radius, 2);
        }
        public override void Output()
        {
            if (radius == -1)
            {
                Console.WriteLine("Radius is undefined, so is area value");
            }
            else
            {
                Console.WriteLine($"Figure radius: {radius}");
                Console.WriteLine($"Figure area value: {AreaValue()}");
            }
            base.Output();
        }
        #endregion
    }
}
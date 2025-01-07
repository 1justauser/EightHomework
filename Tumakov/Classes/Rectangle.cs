namespace Tumakov
{
    internal sealed class Rectangle : Point, IAreaValue
    {
        #region Fields
        private double width;
        private double height;
        #endregion
        #region Constuctor Methods
        public Rectangle(double height, double width, double x, 
            double y, Visability visability, Color color) : base(x, y, visability, color)
        {
            figureType = FigureType.rectangle;
            if (height <= 0)
            {
                this.height = -1;
                Console.WriteLine("Radius is undefined");
            }
            else
            {
                this.height = height;
            }
            if (width <= 0)
            {
                this.width = -1;
                Console.WriteLine("Radius is undefined");
            }
            else
            {
                this.width = width;
            }
        }
        public Rectangle() : base()
        {
            figureType = FigureType.rectangle;
            height = -1;
            width = -1;
        }
        #endregion
        #region Rectangle Methods
        public double AreaValue()
        {
            if (height == -1 || width == -1)
                return -1;
            return width * height;
        }
        public override void Output()
        {
            if (height == -1 || width == -1)
            {
                Console.WriteLine("Area value is undefined");
                if (height == -1)
                {
                    Console.WriteLine("height is undefined");
                }
                else
                {
                    Console.WriteLine($"height is {height}");
                }
                if (width == -1)
                {
                    Console.WriteLine("width is undefined");
                }
                else
                {
                    Console.WriteLine($"width is {width}");
                }
            }
            else
            {
                Console.WriteLine($"Figure height: {height}");
                Console.WriteLine($"Figure width: {width}");
                Console.WriteLine($"Figure area value: {AreaValue()}");
            }
            base.Output();
        }
        #endregion
    }
}

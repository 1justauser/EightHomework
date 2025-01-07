namespace Tumakov
{
    internal class Point : Figure
    {
        #region Constructor Methods
        public Point() : base()
        { figureType = FigureType.point; }
        public Point(double x, double y, Visability visability, Color color) : base(x, y, visability, color)
        { figureType = FigureType.point; }
        #endregion
    }
}
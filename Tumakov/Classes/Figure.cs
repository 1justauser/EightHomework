namespace Tumakov
{
    internal class Figure : DecartovSystemsObject, IOutput
    {
        //В качестве полей класса задаются цвет фигуры, состояние «видимое / невидимое». Реализовать
        //операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение
        //цвета, опрос состояния(видимый/ невидимый). Метод вывода на экран должен выводить
        //состояние всех полей объекта.
        #region Fields
        protected Visability visability;
        protected Color color;
        protected FigureType figureType;
        #endregion
        #region Constructor Methods
        public Figure() : base()
        {
            visability = Visability.undefined;
            color = Color.undefined;
            figureType = FigureType.undefined;
        }
        public Figure(double x, double y, Visability visability, Color color) : base(x, y)
        {
            this.visability = visability;
            this.color = color;
            this.figureType = FigureType.undefined;
        }

        #endregion
        #region Figue Methods
        public virtual void Output() 
        {
            Console.WriteLine($"Figure coordinates: ({x},{y})");
            Console.WriteLine($"Figure color: {color.ToString()}");
            Console.WriteLine($"Figure visability: {visability.ToString()}");
            Console.WriteLine($"Figure type: {figureType.ToString()}\n\n");  
        }
        public void ChangeColor(Color color)
        {
            if (color != Color.undefined)
            {
                this.color = color;
            }
        }
        public void VisabilityState()
        {
            Console.WriteLine("Visability state: " + visability.ToString() + "\n\n");
        }
        #endregion
    }
}

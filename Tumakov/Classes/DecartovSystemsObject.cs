namespace Tumakov
{
    internal abstract class DecartovSystemsObject
    {
        #region Fields
        protected double x;
        protected double y;
        #endregion
        #region Constructor Methods
        public DecartovSystemsObject()
        {
            x = 0;
            y = 0;
        }
        public DecartovSystemsObject(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion
        #region Decartov System Methods
        public void MoveX(double x) 
        {
            this.x += x;
            return;
        }
        public void MoveY(double y) 
        {
            this.y += y;
            return;
        }
        #endregion
    }
}
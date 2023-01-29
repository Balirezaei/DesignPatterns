namespace MultiDispatch
{
    public abstract class Board
    {
        public abstract string Draw(Circle circle);
        public abstract string Draw(Rectangle rectangle);
        public abstract string Draw(Square square);
    }

    public class WhiteBoard : Board
    {
        public override string Draw(Circle circle)
        {
            return "Circle";
        }

        public override string Draw(Rectangle rectangle)
        {
            return "Rectangle";
        }

        public override string Draw(Square square)
        {
            return "Draw";
        }
    }

}
namespace MultiDispatch
{
    public abstract class Shape
    {
        public abstract string DrawOn(Board board);
    }
    public class Circle : Shape
    {
        public override string DrawOn(Board board)
        {
            return board.Draw(this);
        }
    }

    public class Rectangle : Shape
    {
        public override string DrawOn(Board board)
        {
            return board.Draw(this);
        }
    }

    public class Square : Shape
    {
        public override string DrawOn(Board board)
        {
            return board.Draw(this);
        }

    }


}
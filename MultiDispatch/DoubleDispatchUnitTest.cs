namespace MultiDispatch
{
    public class DoubleDispatchUnitTest
    {
        [Fact]
        public void Test1()
        {
            var board = new WhiteBoard();
            Shape shape = CreateShape();
            //dynamic dispatch
            board.Draw(shape as dynamic);// Multiple Dispatch


            shape.DrawOn(board); //Double Dispatch


        }

        private Shape CreateShape()
        {
            var shape = new Circle();
            return shape;
        }
    }

  


     
}
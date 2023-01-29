namespace CompositObserver
{
    public class NumericDisplay : IMyObserver<int>
    {
        public List<int> AllTemperature { get; private set; } = new List<int>();

        public void Notify(int value)
        {
           // AllTemperature.Add(value);
           Console.WriteLine(value);

        }
    }

}
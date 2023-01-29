namespace CompositObserver
{
    public class SensorBatch : SimpleObserver<int>, IMyObserver<int>
    {
        public void Notify(int value)
        {
            NotifyAllObservers(value);
        }
    }

}
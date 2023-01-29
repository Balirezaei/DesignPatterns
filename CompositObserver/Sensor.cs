namespace CompositObserver
{
    public class SimpleObserver<T>:IMyObserveble<T>
    {
        private List<IMyObserver<T>> myObservers = new List<IMyObserver<T>>();

        public void Subscribe(IMyObserver<T> observer)
        {
            myObservers.Add(observer);
        }
        protected void NotifyAllObservers(T value)
        {
            foreach (var observer in myObservers)
            {
                observer.Notify(value);
            }
        }

    }
    public class Sensor : SimpleObserver<int>
    {
        public int CurrentTemperature { get; private set; }

        public Task StartDetection()
        {
            int counter = 1;
            return Task.Factory.StartNew(() =>
               {

                   while (counter < 10)
                   {
                       CurrentTemperature = new Random().Next(-20, 30);
                       NotifyAllObservers(CurrentTemperature);
                       counter++;
                       Thread.Sleep(1000);

                   }
               });
        }
      
    }

}
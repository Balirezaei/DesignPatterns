namespace ObserverPattern
{
    public class Sensor : IMyObserveble<int>
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
                       foreach (var observer in myObservers)
                       {
                           observer.Notify(CurrentTemperature);
                       }
                       counter++;
                       //Thread.Sleep(1000);

                   }
               });
        }
        private List<IMyObserver<int>> myObservers = new List<IMyObserver<int>>();

        public void Subscribe(IMyObserver<int> observer)
        {
            myObservers.Add(observer);
        }
    }

}
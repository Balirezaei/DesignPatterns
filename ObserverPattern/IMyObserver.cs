namespace ObserverPattern
{
    //Dotnet Class for this pattern = IObserver
    public interface IMyObserver<T>
    {
        void Notify(T value);
    }

}
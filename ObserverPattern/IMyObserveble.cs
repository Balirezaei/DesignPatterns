namespace ObserverPattern
{
    public interface IMyObserveble<T>
    {
        void Subscribe(IMyObserver<T> observer);
    }

}
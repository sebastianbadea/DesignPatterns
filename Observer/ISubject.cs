namespace Sample.Observer.Console
{
    public interface ISubject
    {
        Guid RegisterObserver(IObserver o);
        void RemoveObserver(Guid o);
        void NotifyObservers();
    }
}
namespace Ex_10__wf_
{
    public interface IObserver
    {
        string Name { get; set; }
        public int Time { get; set; }
        public DateTime ObserverTime { get; set; }
        void Update(string message);
    }
    public interface IObservable
    {
        void AddObserver(IObserver obs);
        void RemoveObserver(IObserver obs);
        void NotifyObservers();
    }
}

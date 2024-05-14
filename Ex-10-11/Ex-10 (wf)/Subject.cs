namespace Ex_10__wf_
{
    public class Subject : IObservable
    {
        public List<IObserver> _observers;
        public string _state = "disactivate";

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void ChangeState(string newState)
        {
            _state = newState;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }
}

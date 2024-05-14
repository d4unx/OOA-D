namespace Ex_10__wf_
{
    public class Observer1 : IObserver
    {
        public Observer1(string name)
        {
            Name = name;
        }
        public int Time { get; set; }
        public DateTime ObserverTime { get; set; }
        public string Name { get; set; }

        public void Update(string message)
        {
            Time = DateTime.Now.Subtract(ObserverTime).Milliseconds;
        }
    }
}
using System.Windows.Controls;
namespace Ex_10
{
    public class Observer1 : IObserver
    {
        public string Update(string message)
        {
            return "Observer 1 received message: " + message;
        }
    }

    public class Observer2 : IObserver
    {
        public string Update(string message)
        {
            return "Observer 2 received message: " + message;
        }
    }

    public class Observer3 : IObserver
    {
        public string Update(string message)
        {
            return "Observer 2 received message: " + message;
        }
    }
}

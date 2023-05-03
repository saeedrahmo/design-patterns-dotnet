namespace ConsoleApp.Observer_pattern
{
    /*     
    We use the Observer design pattern when we have a one-to-many relationship between objects, where changes in the state of one object need to be propagated to many other objects without tightly coupling the objects together. The Observer pattern provides a way to define a subscription mechanism to notify multiple objects about any state changes that occur in an object, without these objects needing to know about or tightly couple to each other.

For example, if you have a GUI application where a user can update some data that needs to be reflected in several different parts of the interface, you can use the Observer pattern. In this case, you can have a "subject" object that represents the data, and several "observer" objects that represent the different parts of the interface. The observers would subscribe to the subject, and when the subject's data changes, it would notify all the observers that the data has been updated, allowing them to update their own display as needed.

Another example where the Observer pattern can be used is in a stock market application where the price of a stock is updated frequently. The price updates can be published by the stock exchange as the "subject" and the applications that need to display the updated stock prices can be the "observers". When the stock price changes, the stock exchange notifies all the observers, and each observer can update its display accordingly.
     */

    // Subject interface
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    // Concrete subject
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string state;

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Observer interface
    public interface IObserver
    {
        void Update();
    }

    // Concrete observer
    public class ConcreteObserver : IObserver
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void Update()
        {
            observerState = subject.State;
            Console.WriteLine("Observer {0}'s new state is {1}", name, observerState);
        }
    }

    // Example usage
    //    ConcreteSubject subject = new ConcreteSubject();

    //    ConcreteObserver observer1 = new ConcreteObserver("Observer 1", subject);
    //    ConcreteObserver observer2 = new ConcreteObserver("Observer 2", subject);

    //    subject.Attach(observer1);
    //subject.Attach(observer2);

    //subject.State = "New state";
    // Output:
    // Observer 1's new state is New state
    // Observer 2's new state is New state

    //subject.Detach(observer2);

    //subject.State = "Another state";
    // Output:
    // Observer 1's new state is Another state

}

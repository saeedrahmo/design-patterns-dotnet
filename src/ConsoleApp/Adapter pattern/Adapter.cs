namespace ConsoleApp.Adapter_pattern
{
    /*
    We use the Adapter design pattern when we have two incompatible interfaces that need to work together, or when we need to convert the interface of an existing class to a new interface without changing its existing code. The Adapter pattern allows objects with incompatible interfaces to work together by creating a new object (the Adapter) that adapts one interface to another.

We typically use the Adapter pattern when we have:

    An existing class with a well-defined interface that cannot be modified, and we want to use it with another class that has a different interface.
    A third-party library or component that we want to use with our application, but its interface is not compatible with our existing codebase.

Some common examples of where the Adapter pattern is used include:

    Integrating third-party libraries: We can use the Adapter pattern to integrate third-party libraries with our application. This allows us to work with the third-party library using a common interface that is compatible with our existing codebase.

    Legacy code integration: We can use the Adapter pattern to integrate legacy code with modern systems. This allows us to adapt the legacy code's interface to the new system's interface, without modifying the legacy code itself.

    Cross-platform development: We can use the Adapter pattern to create platform-independent code. This allows us to write code once and adapt it to different platforms by creating different Adapters for each platform.
     */

    // Target interface
    public interface ITarget
    {
        void Request();
    }

    // Adaptee
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee method called");
        }
    }

    // Adapter
    public class Adapter : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    // Client
    public class Client
    {
        public void DoWork(ITarget target)
        {
            target.Request();
        }
    }

    // Example usage
    //Client client = new Client();
    //ITarget target = new Adapter();
    //client.DoWork(target); // Output: "Adaptee method called"

}

namespace ConsoleApp.Adapter_pattern
{
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

namespace ConsoleApp.Singleton_pattern
{
    /*
     The Singleton design pattern is used when we want to ensure that there is only one instance of a class created and that this instance is globally accessible throughout the application.

We typically use the Singleton pattern when we have a class that:

    Needs to be instantiated only once during the entire lifetime of the application.
    Needs to be easily accessible from multiple parts of the application.

Some common examples of where the Singleton pattern is used include:

    Database connection: In an application that needs to connect to a database, it is often useful to use a Singleton to ensure that there is only one instance of the database connection object. This allows multiple parts of the application to access the same database connection without the need to repeatedly create new connections.

    Logging: In a logging framework, we may use the Singleton pattern to ensure that there is only one instance of the logging object throughout the application.

    Configuration settings: We can use the Singleton pattern to ensure that there is only one instance of the configuration settings object throughout the application.
     */
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void SomeMethod()
        {
            // Method implementation
        }
    }

    //Singleton s1 = Singleton.Instance;
    //s1.SomeMethod();
}

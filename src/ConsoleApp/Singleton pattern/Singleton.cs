namespace ConsoleApp.Singleton_pattern
{
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

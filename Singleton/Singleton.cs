namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance = new Singleton();

        private Singleton()
        { }

        public static Singleton Instance() { return _instance; }

        public void SayHi() 
        {
            Console.WriteLine("Singleton Hi");
        }
    }
}
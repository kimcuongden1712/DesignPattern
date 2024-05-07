namespace SingletonSpaceMulti
{
    public sealed class SingletonMulti
    {
        //1 create private contructor
        //2 create private static instance
        //3 create public static method to get instance
        //Need use sealed to prevent inheritance, and thread safe, it cannot be extended or subclassed and create multiple instances of Singleton class
        private static SingletonMulti? _instance = null;

        /// <summary>
        /// Lock synchronization object
        /// </summary>
        private static readonly object _lock = new object();

        public string InitialMessage { get; set; }

        private SingletonMulti()
        { }

        public static SingletonMulti GetInstance(string value)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonMulti();
                    _instance.InitialMessage = value;
                }
                return _instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
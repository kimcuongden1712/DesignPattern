namespace SingletonSpace
{
    public sealed class Singleton
    {
        //1 create private contructor
        //2 create private static instance
        //3 create public static method to get instance
        //Need use sealed to prevent inheritance, and thread safe, it cannot be extended or subclassed and create multiple instances of Singleton class
        private static Singleton _instance;

        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
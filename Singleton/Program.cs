using SingletonSpace;
using SingletonSpaceMulti;

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();
if (s1 == s2)
{
    Console.WriteLine("Objects are the same instance");
}
else
{
    Console.WriteLine("Objects are different instances");
}

//String multil thread
Thread t1 = new Thread(() =>
{
    SingletonMulti s1 = SingletonMulti.GetInstance("Hello from thread 1");
    s1.PrintMessage(s1.InitialMessage);
});

Thread t2 = new Thread(() =>
{
    SingletonMulti s2 = SingletonMulti.GetInstance("Hello from thread 2");
    s2.PrintMessage(s2.InitialMessage);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();
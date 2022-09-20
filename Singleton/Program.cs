// See https://aka.ms/new-console-template for more information

using SingletonPattern;

Console.WriteLine("=======Single thread=============");
Singleton.Instance().SayHi();

Console.WriteLine("=======Thread=============");
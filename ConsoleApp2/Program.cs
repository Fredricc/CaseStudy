using System.Xml.Linq;

namespace ConsoleApp2
{
    class Person
    {
        int age;
        string name;
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
        }
    }
    }
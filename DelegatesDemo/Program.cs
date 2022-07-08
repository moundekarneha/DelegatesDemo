using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class Program
    {
        //define delegates

        public delegate void AddDelegate(int a, int b);
        public delegate string sayHelloDelegate(string s);
        public void AddNum(int a, int b)
        {
            Console.WriteLine("Addition = "+(a+b));
        }

        public static string sayHello(string str)
        {
            return "Hello " + str;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AddNum(1, 2);
            string s = Program.sayHello("Neha");
            Console.WriteLine(s);

            Console.WriteLine("\n\n\nDelegates----");
            //instantiation of delegates -create obj of delegate and pass method name as parameter
            AddDelegate ad = new AddDelegate(p.AddNum);

            Console.WriteLine("\n\n\nDelegates----");
            //instantiation of delegates -create obj of delegate and pass method name as parameter
            sayHelloDelegate ad1 = new sayHelloDelegate(sayHello);
            sayHelloDelegate ad2 = new sayHelloDelegate(Program.sayHello);

            Console.WriteLine("\n\n\nDelegates----");
            //calling method and passing para
            ad(20, 20);
            ad.Invoke(20, 80);
            string s1 = ad1("Neha");
            string s3 = ad2("Pranita");
            Console.WriteLine(s1);
            Console.WriteLine(s3);

            string s2 = ad1.Invoke("Neha");
            string s4= ad2.Invoke("Pranita");
            Console.WriteLine(s2);
            Console.WriteLine(s4);







            Console.ReadLine();

        }
    }
}

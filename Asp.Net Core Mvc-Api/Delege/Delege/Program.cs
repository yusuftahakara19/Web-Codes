using System;


delegate void MyDelege(int num1,int num2);

namespace Delege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelege myDelege = new MyDelege(Topla);
            myDelege += Carp;
            myDelege.Invoke(1, 19);
            Console.WriteLine("Hello World!");
        }

        static void Topla(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void Carp(int num1, int num2) {
            Console.WriteLine(num1 * num2);
        }
    }
}

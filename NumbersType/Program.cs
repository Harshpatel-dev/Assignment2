// See https://aka.ms/new-console-template for more information

using System;
using NumbersApp;

namespace Program
{
    class MainProgram{
        public static void Main(string []args)
        {
            NumbersApp.Numbers.IntDemo();
            NumbersApp.Numbers.DoubleDemo();
            NumbersApp.Numbers.DecimalDemo();
            NumbersApp.Numbers.findArea();
        }
    }
}


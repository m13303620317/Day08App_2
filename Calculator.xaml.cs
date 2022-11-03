using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Day08App
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Calculator : Page
    {
        public Calculator()
        {
            this.InitializeComponent();
        }

        // Add two numbers together
        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = " + (a + b));
        }

        // Subtract two numbers
        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = " + (a - b));
        }

        // Multiply two numbers
        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = " + (a * b));
        }

        // Divide two numbers by one
        public static void Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("The divisor can not be zero!");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = " + (a / b));
            }
        }

        // Radication
        public static void Radication(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("The radicand can not less than 0!");
            }
            else
            {
                Console.WriteLine($"The square root of {a} is " + Math.Sqrt(a));
            }
        }

        // Power
        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = " + Math.Pow(a, b));
        }
    }
}

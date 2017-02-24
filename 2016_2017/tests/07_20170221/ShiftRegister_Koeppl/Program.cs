using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using ShiftRegister;

namespace ShiftReg
{
    class Program
    {
        // Handles drop events sent by the Register.
        static void HandleDropEvent(object sender, IComparable droppedValue)
        {
            Console.WriteLine($"Register with value {droppedValue} has been dropped.");
        }

        static void Main(string[] args)
        {
            Register<IComparable> register = new Register<IComparable>(5);

            // Register the drop event listener.
            register.RaiseDropEventHandler += HandleDropEvent;

            // Loops forever and generates random values to add to the register.
            // The register does also work with other types implementing IComparable.
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                register.Add(rnd.Next());
                Console.WriteLine(register.ToString());
                Console.WriteLine($"First element: {register.First()}");
                Console.WriteLine($"Last element: {register.Last()}");
                Console.WriteLine($"Count: {register.Count}");
                Thread.Sleep(300);
            }

            register.Clear();
            Console.WriteLine(register.ToString());

            Console.ReadKey();

            /*register.Add(1);
            register.Add(1.2);
            register.Add(2.5f);
            register.Add(long.Parse("12"));
            register.Add("hallo");*/
        }
    }
}

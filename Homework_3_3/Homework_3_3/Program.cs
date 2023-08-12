using System;

namespace Homework_3_3
{
    /// <summary>
    /// Main class in program.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Enty point.
        /// </summary>
        /// <param name="args">Array of args.</param>
        public static void Main(string[] args)
        {
            FirstClass firstClass = new FirstClass();
            firstClass.ShowMethod = Show;
            firstClass.ShowMethod(new SecondClass().ResultMethod(3));
        }

        private static void Show(bool res)
        {
            Console.WriteLine(res);
        }
    }
}

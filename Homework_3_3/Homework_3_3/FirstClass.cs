using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_3
{
    /// <summary>
    /// The first class.
    /// </summary>
    internal class FirstClass
    {
        /// <summary>
        /// The delegate refers to the “Show” method.
        /// </summary>
        /// <param name="x">Taken boolean value.</param>
        public delegate void Print(bool x);

        /// <summary>
        /// Gets or sets delegate.
        /// </summary>
        public Print ShowMethod { get; set; }

        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        /// <param name="x">First number.</param>
        /// <param name="y">Second number.</param>
        /// <returns>Result.</returns>
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}

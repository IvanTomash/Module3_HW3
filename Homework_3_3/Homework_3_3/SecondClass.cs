using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_3
{
    /// <summary>
    /// The second class.
    /// </summary>
    internal class SecondClass
    {
        private double res;
        private Predicate<double> resultMethod;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecondClass"/> class.
        /// </summary>
        public SecondClass()
        {
            this.res = 0;
            this.resultMethod = this.Result;
        }

        /// <summary>
        /// Gets ResultMethod.
        /// </summary>
        public Predicate<double> ResultMethod
        {
            get
            {
                return this.resultMethod;
            }
        }

        /// <summary>
        /// Executes calculation.
        /// </summary>
        /// <param name="method">Taken action.</param>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>This delegate refers to the "Result" method.</returns>
        public Predicate<double> Calc(Func<double, double, double> method, double x, double y)
        {
            this.res = method.Invoke(x, y);
            return this.resultMethod;
        }

        /// <summary>
        /// The current method must calculate the remainder
        /// from the division of the result of calling the delegate to the “Multiply” method
        /// and the number that came to the method as a parameter.
        /// </summary>
        /// <param name="x">Taken value.</param>
        /// <returns>the remainder from the division of the result of calling the delegate
        /// to the “Multiply” method and the number that came to the method as a parameter.</returns>
        public bool Result(double x)
        {
            this.Calc(FirstClass.Multiply, 4, 5);
            return this.res % x == 0 ? true : false;
        }
    }
}

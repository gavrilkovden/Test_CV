using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CV
{
    class NumberReplacer
    {
        private List<int> numbers;

        public NumberReplacer(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public List<object> ReplaceNumbers()
        {
            List<object> result = new List<object>();
            foreach (int number in numbers)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    result.Add("fizz-buzz");
                }
                else if (number % 3 == 0)
                {
                    result.Add("fizz");
                }
                else if (number % 5 == 0)
                {
                    result.Add("buzz");
                }
                else
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}

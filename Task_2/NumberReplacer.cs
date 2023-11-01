using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
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
                string replacedValue = "";

                if (number % 3 == 0)
                replacedValue += "fizz";

                if (number % 5 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedValue))
                        replacedValue += "-";
                    replacedValue += "buzz";
                }

                if (number % 4 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedValue))
                        replacedValue += "-";
                    replacedValue += "muzz";
                }

                if (number % 7 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedValue))
                        replacedValue += "-";
                    replacedValue += "guzz";
                }

                if (string.IsNullOrEmpty(replacedValue))
                    replacedValue = number.ToString();

                result.Add(replacedValue);
            }
            return result;
        }
    }
}

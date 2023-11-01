using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
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
                {
                    replacedValue += "dog";
                }

                if (number % 4 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedValue))
                        replacedValue += "-";
                    replacedValue += "muzz";
                }

                if (number % 5 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedValue))
                        replacedValue += "-";
                    replacedValue += "cat";
                }

                if (number % 7 == 0)
                {
                    if (!string.IsNullOrEmpty(replacedValue))
                        replacedValue += "-";
                    replacedValue += "guzz";
                }

                if (number % 4 == 0 && number % 7 == 0)
                {
                    replacedValue = "muzz-guzz";
                }

                if (number % 3 == 0 && number % 5 == 0)
                {
                    replacedValue = "good-boy";
                    if (number % 4 == 0)
                    {
                        replacedValue += "-";
                        replacedValue += "muzz";
                    }
                    if (number % 7 == 0)
                    {
                        replacedValue += "-";
                        replacedValue += "guzz";
                    }
                    if (number % 4 == 0 && number % 7 == 0)
                    {
                        replacedValue = "good-boy-muzz-guzz";
                    }
                }

                if (string.IsNullOrEmpty(replacedValue))
                {
                    result.Add(number.ToString());
                }
                else
                {
                    result.Add(replacedValue);
                }
            }
            return result;
        }
    }
}

// число 12 по условию 3-й задачи делится на 3 и на 4. Вместо 3 - "dog", вместо 4 - "muzz"(по условию 2-й задачи). Получаем - dog-muzz:
namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        private readonly IFileIOWrapper systemIoWrapper;

        public Calculator()
        {
        }

        public Calculator(IFileIOWrapper systemIoWrapper)
        {
            this.systemIoWrapper = systemIoWrapper;
        }

        public int Add(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            var result = 0;
            foreach (var n in numbers)
            {
                result += n;
            }

            return result;
        }

        public int AddFromFile(string numbersFilePath)
        {
            var numbersCsv = this.systemIoWrapper.ReadAllText(numbersFilePath);

            return this.Add(numbersCsv.Split(',').Select(int.Parse));
        }
    }
}
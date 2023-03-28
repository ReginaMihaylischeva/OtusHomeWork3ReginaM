using OtusHomeWork3ReginaM.Dtos;
using OtusHomeWork3ReginaM.Interfaces;
using System;

namespace OtusHomeWork3ReginaM.Services
{
    public class GetSettingsService : IGetSettingsService
    {
        public AttemptCount GetAttemptCount()
        {
            Console.WriteLine("Введите количество попыток:");
            var countOfAttempts = Console.ReadLine();
            var count = UInt16.Parse(countOfAttempts);

            var attemptCount = new AttemptCount()
            {
                CountOfAttempts = count
            };

            return attemptCount;
        }

        public Range GetRange()
        {
            Console.WriteLine("Введите минимальное число:");
            var minString = Console.ReadLine();
            var min = UInt16.Parse(minString);

            Console.WriteLine("Введите максимальное число:");
            var maxString = Console.ReadLine();
            var max = UInt16.Parse(maxString);

            var range = new Range()
            {
                min = min,
                max = max
            };

            return range;
        }
    }
}

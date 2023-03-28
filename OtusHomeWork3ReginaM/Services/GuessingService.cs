using OtusHomeWork3ReginaM.Dtos;
using OtusHomeWork3ReginaM.Interfaces;
using System;

namespace OtusHomeWork3ReginaM.Services
{
    public class GuessingService : IGuessingService
    {
        public bool TryGuess(AttemptCount attemptCount, Range range)
        {
            var getSecretNumberService = new GetSecretNumberService();

            var secretNuber = getSecretNumberService.GetSecretNumberByRenge(range);

            var count = attemptCount.CountOfAttempts;

            while (count != 0)
            {
                Console.WriteLine("Введите число:");
                var numberString = Console.ReadLine();
                var number = int.Parse(numberString);

                if (number == secretNuber)
                {
                    return true;
                }

                if (number < secretNuber)
                {
                    Console.WriteLine("Введенное число меньше загаданного:");
                }

                if (number > secretNuber)
                {
                    Console.WriteLine("Введенное число больше загаданного:");
                }

                count--;
            }

            return false;

        }
    }
}

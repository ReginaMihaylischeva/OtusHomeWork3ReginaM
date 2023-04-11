using OtusHomeWork3ReginaM.Dtos;
using System;

namespace OtusHomeWork3ReginaM.Services
{
    class GuessingService2 : GuessingService
    {
        public override bool TryGuess(AttemptCount attemptCount, Range range)
        {
            var guessInfo = GetGuessInfo(attemptCount, range);

            while (guessInfo.AttemptCount != 0)
            {
                Console.WriteLine("Введите число:");
                var numberString = Console.ReadLine();
                var number = int.Parse(numberString);

                if (number == guessInfo.SecretNuber)
                {
                    return true;
                }

                var message = number < guessInfo.SecretNuber ? "меньше" : "больше";

                Console.WriteLine($"Введенное число {message} загаданного:");

                guessInfo.AttemptCount--;
            }

            return false;

        }

        private GuessDto GetGuessInfo(AttemptCount attemptCount, Range range)
        {
            var getSecretNumberService = new GetSecretNumberService();

            var secretNuber = getSecretNumberService.GetSecretNumberByRenge(range);

            var count = attemptCount.CountOfAttempts;

            return new GuessDto
            {
                SecretNuber = secretNuber,
                AttemptCount = count
            };

        }
    }
}

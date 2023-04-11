using OtusHomeWork3ReginaM.Interfaces;
using OtusHomeWork3ReginaM.Services;
using System;

namespace OtusHomeWork3ReginaM
{
    class Program
    {
        static void Main()
        {
            SimpleContainer.Register<IRegisterService, RegisterService>();
            var registerService = SimpleContainer.Create<IRegisterService>();
            registerService.RegisterServices();

            var settings = SimpleContainer.Create<IGetSettingsService>();
            var guessingService = SimpleContainer.Create<IGuessingService>();
            var processResultService = SimpleContainer.Create<IProcessResultService>();

            var attemptCount = settings.GetAttemptCount();
            var range = settings.GetRange();

            var result = guessingService.TryGuess(attemptCount, range);
            Console.WriteLine("Обработка результата, полученного первым сервисом");
            processResultService.ProcessResult(result);

            var guessingService2 = new GuessingService2();
            var result2 = guessingService2.TryGuess(attemptCount, range);
            Console.WriteLine("Обработка результата, полученного вторым сервисом");
            processResultService.ProcessResult(result2);
        }
    }
}

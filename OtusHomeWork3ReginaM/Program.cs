using OtusHomeWork3ReginaM.Services;

namespace OtusHomeWork3ReginaM
{
    class Program
    {
        static void Main()
        {
            var settings = new GetSettingsService();
            var guessingService = new GuessingService();
            var processResultService = new ProcessResultService();

            var attemptCount = settings.GetAttemptCount();
            var range = settings.GetRange();            

            var result = guessingService.TryGuess(attemptCount, range);

            processResultService.ProcessResult(result);
        }
    }
}

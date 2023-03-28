using OtusHomeWork3ReginaM.Dtos;

namespace OtusHomeWork3ReginaM.Interfaces
{
    interface IGuessingService
    {
        bool TryGuess(AttemptCount attemptCount, Range range);
    }
}

using OtusHomeWork3ReginaM.Dtos;
using OtusHomeWork3ReginaM.Interfaces;
using System;

namespace OtusHomeWork3ReginaM.Services
{
    public class GetSecretNumberService : IGetSecretNumberService
    {
        public int GetSecretNumberByRenge(Range range)
        {
            Random rnd = new Random();

            var value = rnd.Next(range.min, range.max);

            return value;
        }

    }
}

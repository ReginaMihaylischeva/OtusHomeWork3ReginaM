using OtusHomeWork3ReginaM.Interfaces;
using System;

namespace OtusHomeWork3ReginaM.Services
{
    public class ProcessResultService : IProcessResultService
    {
        public void ProcessResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Вы справились успешно!");
            }
            else
            {
                Console.WriteLine("В этот раз не повезло :(");
            }
            Console.ReadKey();
        }
    }
}

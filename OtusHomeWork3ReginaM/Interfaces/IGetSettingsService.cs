using OtusHomeWork3ReginaM.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork3ReginaM.Interfaces
{
    interface IGetSettingsService
    {
        Range GetRange();

        AttemptCount GetAttemptCount();
    }
}

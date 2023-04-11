using OtusHomeWork3ReginaM.Interfaces;

namespace OtusHomeWork3ReginaM.Services
{
    class RegisterService : IRegisterService
    {
        public void RegisterServices()
        {
            SimpleContainer.Register<IGetSettingsService, GetSettingsService>();
            SimpleContainer.Register<IGuessingService, GuessingService>();
            SimpleContainer.Register<IProcessResultService, ProcessResultService>();    
        }
    }
}

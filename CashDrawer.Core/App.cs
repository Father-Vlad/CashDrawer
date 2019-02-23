using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace CashDrawer.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsSingleton();

            RegisterCustomAppStart<AppStart>();
        }
    }
}
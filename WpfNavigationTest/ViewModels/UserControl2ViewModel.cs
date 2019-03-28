using System.Windows.Input;
using WpfNavigationTest.Commands;
using WpfNavigationTest.Helpers;

namespace WpfNavigationTest.ViewModels
{
    public class UserControl2ViewModel : IPageViewModel
    {
        private ICommand _goTo1;

        public ICommand GoTo1
        {
            get
            {
                return _goTo1 ?? (_goTo1 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo1Screen", "");
                }));
            }
        }
    }
}

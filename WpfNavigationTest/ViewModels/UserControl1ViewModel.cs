using System.Windows.Input;
using WpfNavigationTest.Commands;
using WpfNavigationTest.Helpers;

namespace WpfNavigationTest.ViewModels
{
    public class UserControl1ViewModel : IPageViewModel
    {
        private ICommand _goTo2;

        public ICommand GoTo2
        {
            get
            {
                return _goTo2 ?? (_goTo2 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo2Screen", "");
                }));
            }
        }
    }
}

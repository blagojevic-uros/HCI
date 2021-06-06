using HCI_Projekat.Core;
using System;

namespace HCI_Projekat.MVVM.ViewModel
{
    class UserViewModel : ObservableObject
    {
        public RelayCommand ProslavaCommand { get; set; }
        public RelayCommand NovaProslavaCommand { get; set; }
        public RelayCommand ExitSystemCommand { get; set; }

        public UserNovaProslavaViewModel NovaProslavaVM { get; set; }
        public UserProslavaViewModel ProslavaVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public UserViewModel()
        {
            ProslavaVM = new UserProslavaViewModel();
            NovaProslavaVM = new UserNovaProslavaViewModel();

            CurrentView = ProslavaVM;

            NovaProslavaCommand = new RelayCommand(o => {
                CurrentView = NovaProslavaVM;
            });
            ProslavaCommand = new RelayCommand(o => {
                CurrentView = ProslavaVM;
            });
            ExitSystemCommand = new RelayCommand(o => {
                //DA LI STE SIGURNI DA ZELITE DA SE IZLOGUJETE
                Environment.Exit(0);
            });
        }
    }
}

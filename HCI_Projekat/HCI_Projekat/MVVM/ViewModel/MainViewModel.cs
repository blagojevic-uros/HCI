using HCI_Projekat.Core;
using System;

namespace HCI_Projekat.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand RegisterViewCommand { get; set; }
        public RelayCommand ProslavaViewCommand { get; set; }
        public RelayCommand NovaProslavaViewCommand { get; set; }
        public RelayCommand ExitSystemCommand { get; set; }

        public LoginViewModel LoginVM { get; set; }
        public RegisterViewModel RegisterVM { get; set; }
        public UserNovaProslavaViewModel NovaProslavaVM { get; set; }
        public UserProslavaViewModel ProslavaVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            LoginVM = new LoginViewModel();
            RegisterVM = new RegisterViewModel();
            NovaProslavaVM = new UserNovaProslavaViewModel();
            ProslavaVM = new UserProslavaViewModel();
            
            CurrentView = LoginVM;

            LoginViewCommand = new RelayCommand(o => {
                CurrentView = LoginVM;
            });
            RegisterViewCommand = new RelayCommand(o => {
                CurrentView = RegisterVM;
            });
            NovaProslavaViewCommand = new RelayCommand(o => {
                CurrentView = NovaProslavaVM;
            });
            ProslavaViewCommand = new RelayCommand(o => {
                CurrentView = ProslavaVM;
            });
            ExitSystemCommand = new RelayCommand(o => {
                //DA LI STE SIGURNI DA ZELITE DA NAPUSTITE APLIKACIJU
                Environment.Exit(0);
            });
        }
    }
}

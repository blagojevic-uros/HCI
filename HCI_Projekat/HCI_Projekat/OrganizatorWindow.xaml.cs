using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HCI_Projekat
{
    /// <summary>
    /// Interaction logic for OrganizatorWindow.xaml
    /// </summary>
    public partial class OrganizatorWindow : Window
    {
        public OrganizatorWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da zelite da se odjavite ?","Potvrda Odjavljivanja", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MainWindow window = new MainWindow();
                    window.Show();
                    Hide();
                    break;
                case MessageBoxResult.No:
                    
                    break;
            }
        }
    }
}

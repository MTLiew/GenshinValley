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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GenshinArtifactFarmer
{
    /// <summary>
    /// Interaction logic for RegisterNewCharacter.xaml
    /// </summary>
    public partial class RegisterNewCharacterPage : Page
    {
        public RegisterNewCharacterPage()
        {
            InitializeComponent();
        }

        private void Home_Button(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}

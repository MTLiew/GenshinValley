using System;
using System.IO;
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
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GenshinArtifactFarmer
{
    /// <summary>
    /// Interaction logic for GenshinValleyHome.xaml
    /// </summary>
    /// 


    public partial class GenshinValleyHome : Page
    {
        public GenshinValleyHome()
        {
            InitializeComponent();
        }

        private void Register_New_Character_Button(object sender, RoutedEventArgs e)
        {
            RegisterNewCharacterPage registerNewCharacterPage = new RegisterNewCharacterPage();
            this.NavigationService.Navigate(registerNewCharacterPage);
        }

        private void Import_Artifacts_Button(object sender, RoutedEventArgs e)
        {
            string file = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName;
            }

            using (StreamReader r = new StreamReader(file))
            {
                string jsonTemp = r.ReadToEnd();
                List<Artifact> artifacts = JsonConvert.DeserializeObject<List<Artifact>>(jsonTemp);
            }
            

            openFileDialog = null;
        }
    }
}

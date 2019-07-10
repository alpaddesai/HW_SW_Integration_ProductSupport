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

namespace QualityAssurance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SixSigma_Click(object sender, RoutedEventArgs e)
        {
            SixSigma SixSigmaObject = new SixSigma();
            SixSigmaObject.Show();
        }

        private void Testing_Click(object sender, RoutedEventArgs e)
        {
            IntroductionToLinux IntroductionToLinuxObject = new IntroductionToLinux();
            IntroductionToLinuxObject.Show();
        }
    }
}

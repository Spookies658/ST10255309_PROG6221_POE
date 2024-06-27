using ST10255309_PROG6221_POE.Workings;
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

namespace RecipeUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WorkingClass workingClass = new WorkingClass();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateRecipe_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}

﻿using ST10255309_PROG6221_POE.Workings;
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
    /*Ethan Smyth
     *ST10255309
     *Group2
     * References
     * C#Corner. 2018. ScrollBar in WPF, [Online}. Available at: https://www.c-sharpcorner.com/UploadFile/mahesh/scrollbar-in-wpf/ [Accessed 26 June 2024].
     * Microsoft learn. 2023. Controls, [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/?view=netframeworkdesktop-4.8 [Accessed 26 June 2024].
     * Microsoft Learn. 2024. StackPanel Class, [Online]. Available at: https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-22621 [Accessed 26 June 2024].
     * Microsoft Learn. 2023. How to store Combobox selected Item in a Variable in WPF C#?, [Online]. Available at: https://learn.microsoft.com/en-gb/answers/questions/1188545/how-to-store-combobox-selected-item-in-a-variable [Accessed 26 June 2024].
     */
    public partial class MainWindow : Window
    {
        private WorkingClass workingClass = new WorkingClass();
        private List<TextBox> recName = new List<TextBox>();
        private List<TextBox> iNameInputs = new List<TextBox>();
        private List<ComboBox> imeasurementInputs = new List<ComboBox>();
        private List<TextBox> iAmountInputs = new List<TextBox>();
        private List<TextBox> iCaloriesInputs = new List<TextBox>();
        private List<ComboBox> iGroupInputs = new List<ComboBox>();
        private List<TextBox> iStepInputs = new List<TextBox>();
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void ContinueCreatingR_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = rName.Text;
            if(string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Please enter a recipe name");
            }
            else
            {
                MessageBox.Show("RecipeName successfully captured");
                recName.Add(rName);
            }

        }

        private void ContinueCreating_Click(object sender, RoutedEventArgs e)
        {
            
            if(int.TryParse(rIngredients.Text, out int ingredientNumber))
            {
                
                MessageBox.Show("Please enter the contents of each ingredient");
                for(int i = 0; i < ingredientNumber; i++)
                {
                    StackPanel Info = new StackPanel();

                    TextBlock Name = new TextBlock {Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Name {i + 1}:"};
                    TextBox iName = new TextBox { Width=200, FontSize=15};
                    
                        iNameInputs.Add(iName);
                    

                    TextBlock measurement = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Measurement {i + 1}:"};
                    ComboBox measurementU = new ComboBox { Width=200, FontSize=15};
                    measurementU.Items.Add("Cups");
                    measurementU.Items.Add("Tablespoons");
                    measurementU.Items.Add("Teaspoons");;
                    measurementU.Items.Add("Grams");
                    measurementU.Items.Add("Kilograms");
                    
                        imeasurementInputs.Add(measurementU);
                    

                    TextBlock Quantity = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Quantity {i + 1}:"};
                    TextBox quantity = new TextBox { Width=200, FontSize=15};
                    
                        iAmountInputs.Add(quantity);
                    

                    TextBlock Calories = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Calories {i + 1}:"};
                    TextBox calories = new TextBox { Width=200, FontSize=15};
                    
                        iCaloriesInputs.Add(calories);
                    

                    TextBlock Group = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Group {i + 1}:"};
                    ComboBox group = new ComboBox { Width=200, FontSize=15};
                    group.Items.Add("Dairy");
                    group.Items.Add("Fruit/Vegetables");
                    group.Items.Add("Starch");
                    group.Items.Add("Protein");
                    group.Items.Add("Liquids");
                    
                        iGroupInputs.Add(group);
                    


                    Info.Children.Add(Name);
                    Info.Children.Add(iName);
                    Info.Children.Add(measurement);
                    Info.Children.Add(measurementU);
                    Info.Children.Add(Quantity);
                    Info.Children.Add(quantity);
                    Info.Children.Add(Calories);
                    Info.Children.Add(calories);
                    Info.Children.Add(Group);
                    Info.Children.Add(group);

                    IngredientsInfo.Children.Add(Info);
                }
            }
            else
            {
                 MessageBox.Show("Please enter a valid number");
            }
        }

        private void ContinueSteps_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(rSteps.Text, out int stepNumber))
            {
                MessageBox.Show("Please enter the contents of each step");
                for(int i = 0; i < stepNumber; i++)
                {
                    StackPanel Info = new StackPanel();

                    TextBlock Step = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Step {i + 1}:"};
                    TextBox step = new TextBox { Width=200, FontSize=15};
                    Info.Children.Add(Step);
                    Info.Children.Add(step);

                    StepsInfo.Children.Add(Info);

                    iStepInputs.Add(step);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
        private void CreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Recipe successfully created");


        }
    }
}

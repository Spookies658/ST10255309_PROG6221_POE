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
    /*Ethan Smyth
     *ST10255309
     *Group2
     * References
     * Microsoft Learn. 2024. Panel.Children Propert, [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.panel.children?view=windowsdesktop-8.0 [Accessed 27 June 2024].
     * oreilly. 2024. Checking for null. [ONLINE] Available at:https://www.oreilly.com/library/view/c-71-and/9781788398077/daa9b00f-274a-4554-8287-4c303e9d2de3.xhtml#:~:text=If%20you%20are%20trying%20to,howManyLetters%20%3D%20authorName%3F. [Accessed 27 June 2024].
     * Microsoft Learn. 2024. How to add an event handler using code (WPF.Net), [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/events/how-to-add-an-event-handler-using-code?view=netdesktop-8.0 [Accessed 27 June 2024].
     * Microsoft Learn. 2024. UIElementCollection.Clear Method,[Online]. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.uielementcollection.clear?view=windowsdesktop-8.0 [Accessed 26 June 2024].
     * C#Corner. 2018. ScrollBar in WPF, [Online}. Available at: https://www.c-sharpcorner.com/UploadFile/mahesh/scrollbar-in-wpf/ [Accessed 26 June 2024].
     * Microsoft learn. 2023. Controls, [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/?view=netframeworkdesktop-4.8 [Accessed 26 June 2024].
     * Microsoft Learn. 2024. StackPanel Class, [Online]. Available at: https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-22621 [Accessed 26 June 2024].
     * Microsoft Learn. 2023. How to store Combobox selected Item in a Variable in WPF C#?, [Online]. Available at: https://learn.microsoft.com/en-gb/answers/questions/1188545/how-to-store-combobox-selected-item-in-a-variable [Accessed 26 June 2024].
     */
    public partial class MainWindow : Window
    {
        private WorkingClass workingClass = new WorkingClass();
        private List<string> recName = new List<string>();
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

        
        //Method which captures the recipe name after clicking the next button
        private void ContinueCreatingR_Click(object sender, RoutedEventArgs e)
        {
            //Adding a variable to the recipe name textbox
            string recipeName = rName.Text;
            //Checking if the recipe name is empty
            if(string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Please enter a recipe name");
            }
            else
            {
                MessageBox.Show("RecipeName successfully captured");
                recName.Add(recipeName);
            }

        }

        //Method which captures the ingredients after clicking the next button, outputs the number of ingredient requirements as inputted
        private void ContinueCreating_Click(object sender, RoutedEventArgs e)
        {
            
            if(int.TryParse(rIngredients.Text, out int ingredientNumber))
            {
                //For every number of ingredients inputted by the user, the following text blocks, text boxes and combo boxes are created
                for(int i = 0; i < ingredientNumber; i++)
                {
                    //Creating a stack panel to hold the text blocks, text boxes and combo boxes
                    StackPanel Info = new StackPanel();

                    //Text block, text box and checking if empty for ingredient name
                    TextBlock Name = new TextBlock {Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Name {i + 1}:"};
                    TextBox iName = new TextBox { Width=200, FontSize=15};
                    if (string.IsNullOrEmpty(iName.Text))
                    {
                        MessageBox.Show("Please enter an ingredient name");
                    }
                        iNameInputs.Add(iName);
                    
                    //Text block, combo box and checking if empty for measurement unit
                    TextBlock measurement = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Measurement {i + 1}:"};
                    ComboBox measurementU = new ComboBox { Width=200, FontSize=15};
                    measurementU.Items.Add("Cups");
                    measurementU.Items.Add("Tablespoons");
                    measurementU.Items.Add("Teaspoons");;
                    measurementU.Items.Add("Grams");
                    measurementU.Items.Add("Kilograms");
                    if (measurementU.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a measurement unit");
                    }
                        imeasurementInputs.Add(measurementU);
                    
                    //Text block, text box and checking if empty/not an int for ingredient quantity
                    TextBlock Quantity = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Quantity {i + 1}:"};
                    TextBox quantity = new TextBox { Width=200, FontSize=15};
                    if(!int.TryParse(quantity.Text, out int quantityInt))
                    {
                        MessageBox.Show("Please enter a Ingredient quantity");
                    }
                        iAmountInputs.Add(quantity);
                    
                    //Text block, text box and checking if empty/not an int for ingredient calories
                    TextBlock Calories = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Calories {i + 1}:"};
                    TextBox calories = new TextBox { Width=200, FontSize=15};
                    if (!int.TryParse(calories.Text, out int caloriesInt))
                    {
                        MessageBox.Show("Please enter a valid number");
                    }
                        iCaloriesInputs.Add(calories);
                    
                    //Text block, combo box and checking if empty for ingredient group
                    TextBlock Group = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Ingredient Group {i + 1}:"};
                    ComboBox group = new ComboBox { Width=200, FontSize=15};
                    group.Items.Add("Dairy");
                    group.Items.Add("Fruit/Vegetables");
                    group.Items.Add("Starch");
                    group.Items.Add("Protein");
                    group.Items.Add("Liquids");
                    if (group.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a Food group");
                    }
                        iGroupInputs.Add(group);
                    

                    //Adding each method to the created stackpanel in the .xaml.cs file
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

                    //Adding the created stackpanel in .xaml.cs to the ingredientsinfo stackpanel in the .xaml file so that they can be outputted
                    IngredientsInfo.Children.Add(Info);

                   
                }
                    
            }
            else
            {
                 MessageBox.Show("Please enter a valid number");
            }
        }

        //Method which captures the steps after clicking the next button 
        private void ContinueSteps_Click(object sender, RoutedEventArgs e)
        {
            //Checking if the number of steps is an integer
            if(int.TryParse(rSteps.Text, out int stepNumber))
            {
                //For every number of steps inputted by the user, the following text blocks and text boxes are created
                MessageBox.Show("Please enter the contents of each step");
                for(int i = 0; i < stepNumber; i++)
                {
                    //Creating a stack panel to hold the text blocks and text boxes
                    StackPanel Info = new StackPanel();

                    //Text block and text box for each step
                    TextBlock Step = new TextBlock { Width=200, FontSize=15, Margin= new Thickness(10), Text=$"Step {i + 1}:"};
                    TextBox step = new TextBox { Width=200, FontSize=15};
                    //Adding each method to the created stackpanel in the .xaml.cs file
                    Info.Children.Add(Step);
                    Info.Children.Add(step);
                    //Adding the created stackpanel in .xaml.cs to the stepsinfo stackpanel in the .xaml file so that they can be outputted
                    StepsInfo.Children.Add(Info);

                    iStepInputs.Add(step);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        //Method which creates the recipe after clicking the create recipe button and removes all resets the page to its original form
        private void CreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Recipe successfully created");

            rName.Clear();
            rIngredients.Clear();
            rSteps.Clear();
            IngredientsInfo.Children.Clear();
            StepsInfo.Children.Clear();

        }

        //Method which outputs the all recipe names in alphabetical order after clicking the view created recipe button
        private void ViewCreatedRecipe_Click(object sender, RoutedEventArgs e)
        {
            //Sorts the recipe names in alphabetical order
            recName.Sort();
            //For every recipe name in the list of recipe names, the following text blocks are created
            foreach(string recipeName in recName)
            {
                StackPanel Info = new StackPanel();
                TextBlock recipe = new TextBlock { Width=900, FontSize=15, Margin= new Thickness(10), Text=$"Recipe Name: {recipeName}"};

                Info.Children.Add(recipe);

                RecipeInfo.Children.Add(Info);
            }
        }

        //Method which outputs the full recipe after clicking the view full recipe button, the name that the user entered is outputted.
        private void ViewFullRecipe_Click(object sender, RoutedEventArgs e)
        {
            //Creating a variable for the recipe name that the user wants to view
            string viewR = VRecipeName.Text;
            //Checking if the recipe name is empty
            if (string.IsNullOrEmpty(viewR))
            {
                MessageBox.Show("Recipe name not found");
            }
            //If the recipe name is found, the recipe name is outputted along with all of its contents
            if (recName.Contains(viewR))
            {
                MessageBox.Show($"Recipe Name: {viewR}");
                foreach (TextBox iName in iNameInputs)
                {
                    MessageBox.Show($"Ingredient Name: {iName.Text}");
                }
                foreach (ComboBox imeasurement in imeasurementInputs)
                {
                    MessageBox.Show($"Measurement Unit: {imeasurement.SelectedItem}");
                }
                foreach (TextBox iAmount in iAmountInputs)
                {
                    MessageBox.Show($"Ingredient Quantity: {iAmount.Text}");
                }
                foreach (TextBox iCalories in iCaloriesInputs)
                {
                    MessageBox.Show($"Ingredient Calories: {iCalories.Text}");
                }
                foreach (ComboBox iGroup in iGroupInputs)
                {
                    MessageBox.Show($"Ingredient Group: {iGroup.SelectedItem}");
                }
                foreach (TextBox iStep in iStepInputs)
                {
                    MessageBox.Show($"Step: {iStep.Text}");
                }
            }

        }

        //Method which outputs the all recipe names in alphabetical order after clicking the view created recipe button
        private void ViewDelRecipe_Click(object sender, RoutedEventArgs e)
        {
            recName.Sort();
            //For every recipe name in the list of recipe names, the following text blocks are created
            foreach(string recipeName in recName)
            {
                StackPanel Info = new StackPanel();
                TextBlock recipe = new TextBlock { Width=900, FontSize=15, Margin= new Thickness(10), Text=$"Recipe Name: {recipeName}"};

                Info.Children.Add(recipe);

                DelRecipeInfo.Children.Add(Info);
            }
        }

          
        
    }
}

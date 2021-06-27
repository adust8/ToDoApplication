using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ToDoApp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
            
        

        public string Today => DateTime.Now.ToShortDateString();

        private void AddToDoButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new();
            addTaskWindow.Show();
            this.Close();
            
        }

        private void MyPlansListView_OnPreviewMouseDoubleClick(object sender, MouseButtonEventArgs e) => FileBaseClass.LoadAndFillDescription(this);


        private void DeleteTask_OnClick(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new();
            TaskBaseClass.DeleteTask(this);

        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            
            AddTaskWindow addTaskWindow = new();
            //FileBaseClass.LoadAndFillTodayTasks(addTaskWindow,this);
        }


        private void Yesterday_OnSelected(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new();
            FileBaseClass.LoadAndFillYesterdayTasks(addTaskWindow, this);
        }

        private void Today_OnSelected(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new();
            FileBaseClass.LoadAndFillTodayTasks(addTaskWindow, this);
        }

        private void LastWeek_OnSelected(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new();
            FileBaseClass.LoadAndFillLastWeekTasks(addTaskWindow, this);
        }
    }
}

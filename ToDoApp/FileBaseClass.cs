using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoApp
{
    public class FileBaseClass
    {
        //File path
        public static string FILE_PATH = @"E:\Моё\my_projects\csharp_projects\ToDoApp\ToDoTasksApp.txt";

        #region Write task
        public static void WriteTaskToFile(AddTaskWindow addTaskWindow)
        {
            using (StreamWriter sw = new(FILE_PATH, true))
            {
                TaskBaseClass task = new
                (
                    addTaskWindow.TaskNameTextBox.Text,
                    addTaskWindow.DescriptionTextBlock.Text,
                    DateTime.Now.ToShortDateString()
                );
                sw.WriteLine(task.TaskName + '-' + task.TaskDescription + '-' + task.TaskDate);

                sw.Close();
            }
        }

        #endregion

        #region Load and fill tasks
        public static void LoadAndFillTodayTasks(AddTaskWindow addTaskWindow,MainWindow mainWindow)
        {
            TaskBaseClass.TasksList.Clear();
            foreach (var lines in File.ReadAllLines(FileBaseClass.FILE_PATH))
            {
                var parts = lines.Split('-');
                if (parts.Length == 3)
                {
                    if (DateTime.Parse(parts[2]).Day == DateTime.Now.Day)
                    {
                        TaskBaseClass task = new(parts[0], parts[1], parts[2]);
                        TaskBaseClass.TasksList.Add(task);
                    }

                }
                else throw new ArgumentException();
            }

            var taskNames = TaskBaseClass.TasksList.Select(x => x.TaskName).ToList();
            mainWindow.MyPlansListView.ItemsSource = taskNames;
        }

        public static void LoadAndFillYesterdayTasks(AddTaskWindow addTaskWindow, MainWindow mainWindow)
        {
            TaskBaseClass.TasksList.Clear();
            foreach (var lines in File.ReadAllLines(FileBaseClass.FILE_PATH))
            {
                var parts = lines.Split('-');
                if (parts.Length == 3)
                {
                    if (DateTime.Parse(parts[2]).Day == DateTime.Now.Day - 1)
                    {
                        TaskBaseClass task = new(parts[0], parts[1], parts[2]);
                        TaskBaseClass.TasksList.Add(task);
                    }

                }
                else throw new ArgumentException();
            }

            var taskNames = TaskBaseClass.TasksList.Select(x => x.TaskName).ToList();
            mainWindow.MyPlansListView.ItemsSource = taskNames;
        }

        public static void LoadAndFillLastWeekTasks(AddTaskWindow addTaskWindow, MainWindow mainWindow)
        {
            TaskBaseClass.TasksList.Clear();
            foreach (var lines in File.ReadAllLines(FileBaseClass.FILE_PATH))
            {
                var parts = lines.Split('-');
                if (parts.Length == 3)
                {
                    if (DateTime.Parse(parts[2]).Day >= DateTime.Now.Day - 7)
                    {
                        TaskBaseClass task = new(parts[0], parts[1], parts[2]);
                        TaskBaseClass.TasksList.Add(task);
                    }

                }
                else throw new ArgumentException();
            }

            var taskNames = TaskBaseClass.TasksList.Select(x => x.TaskName).ToList();
            mainWindow.MyPlansListView.ItemsSource = taskNames;
        }

        #endregion

        #region Load and fill description
        public static void LoadAndFillDescription(MainWindow mainWindow)
        {
            mainWindow.DescriptionTextBlock.Visibility = Visibility.Visible;
            foreach (var item in TaskBaseClass.TasksList)
            {
                if (mainWindow.MyPlansListView.SelectedItem != null && item.TaskName == mainWindow.MyPlansListView.SelectedItem.ToString())
                    mainWindow.DescriptionTextBlock.Text = item.TaskDescription;
            }
        }



        #endregion

    }
}

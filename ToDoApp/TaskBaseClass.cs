using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;

namespace ToDoApp
{
    internal class TaskBaseClass:INotifyPropertyChanged
    {
        public static List<TaskBaseClass> TasksList= new List<TaskBaseClass>();
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public readonly string TaskDate;

        public TaskBaseClass(string name, string description, string date)
        {
            TaskName = name;
            TaskDescription = description;
            TaskDate = date;
        }

        #region Add task in list

        public static void AddTask(AddTaskWindow addTaskWindow)
        {
            MainWindow mainWindow = new();
            FileBaseClass.WriteTaskToFile(addTaskWindow);
            MessageBox.Show("Задача успешно создана.");
            mainWindow.Show();
            addTaskWindow.Close();
            //TasksList.Clear();
        }
        #endregion

        #region Delete task
        public static void DeleteTask(MainWindow mainWindow)
        {
            foreach (var item in TasksList.ToList())
            {
                if (item.TaskName == mainWindow.MyPlansListView.SelectedItem.ToString())
                    TasksList.Remove(item);
                MessageBox.Show($"Задача {item.TaskName} удалена.");

            }

            using (StreamWriter sw = new(FileBaseClass.FILE_PATH,false))
            {
                foreach (var item in TasksList.ToList())
                {
                    sw.WriteLine(item.TaskName+'-'+item.TaskDescription+'-'+item.TaskDate);
                }
            }

            mainWindow.MyPlansListView.ItemsSource = TasksList;
            mainWindow.DescriptionTextBlock.Clear();




        }

        #endregion


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
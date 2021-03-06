﻿using System;
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
using System.IO;


////http://csharp.net-informations.com/gui/cs-listbox.htm

namespace WpfList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var names = File.ReadLines(@"C:\Users\opilane\Documents\GitHub\class\WpfFirstSample\names.txt").ToList();
            InitializeComponent();
            

            List<TodoItem> items = new List<TodoItem>();
            
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            
            TodoListBox.ItemsSource = items;            
        }

        private void todoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TodoListBox.SelectedItem != null)
            {
                Title = (TodoListBox.SelectedItem as TodoItem).Title;
            }
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {            
            foreach (var item in TodoListBox.SelectedItems)
            {
                MessageBox.Show((item as TodoItem).Title);

            }
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            TodoListBox.SelectedIndex = TodoListBox.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if((TodoListBox.SelectedIndex >= 0) && (TodoListBox.SelectedIndex < (TodoListBox.Items.Count - 1)))
            {
                nextIndex = TodoListBox.SelectedIndex + 1;
            }
            TodoListBox.SelectedIndex = nextIndex;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                if((item is TodoItem) && ((item as TodoItem).Title.Contains("C#")))
                {
                    TodoListBox.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                TodoListBox.SelectedItems.Add(item);
            }
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}

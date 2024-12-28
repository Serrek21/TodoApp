using System.Windows;
using TodoApp.Components;
using TodoApp.Data;

namespace TodoApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Функція для додавання нової задачі
    public void OnAddClick(object sender, RoutedEventArgs e)
    {
        string title = TitleTextBox.Text;
        Todo newTodo = TodoList.Add(title);
        TodoComponent component = new TodoComponent(newTodo);
        TodoListPanel.Children.Add(component);
    }

    // Функція для очищення списку задач
    public void OnClearClick(object sender, RoutedEventArgs e)
    {
        TodoList.Clear();              // Очищує логічний список задач
        TodoListPanel.Children.Clear(); // Очищує візуальні компоненти
    }
}
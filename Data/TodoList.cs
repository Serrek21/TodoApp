namespace TodoApp.Data;

public static class TodoList
{
    private static List<Todo> todos = new();

    public static Todo Add(string title)
    {
        var newTodo = new Todo
        {
            Title = title,
            IsCompleted = false,
            Id = Guid.NewGuid()
        };
        todos.Add(newTodo);
        return newTodo;
    }

    public static void Delete(Guid id)
    {
        todos.RemoveAll(t => t.Id == id);
    }

    public static void Complete(Guid id)
    {
        Todo todo = todos.First(t => t.Id == id);
        todo.IsCompleted = true;
    }

    public static void Clear()
    {
        todos.Clear();
    }
}
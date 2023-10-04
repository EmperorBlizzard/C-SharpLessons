namespace TodoListApp.Models;

class Todo
{
    public string Activity { get; set; }
    public DateTime Created { get; set; }= DateTime.Now;
}

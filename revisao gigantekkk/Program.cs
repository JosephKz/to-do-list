
namespace toDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class taskManager
    {

        List<string> allTasks = new List<string>();

        public List<string> GetTasks()
        {
            return allTasks;
        }
        public void AddTask(string task)
        {
            allTasks.Add(task);
        }
        public void ViewTask()
        {
            if(allTasks.Count == 0)
            {
                Console.WriteLine("You have nou tarefaskkkk");
            }
           
        }
        public void RemoveTask(string task)
        {
            allTasks.Remove(task);
        }
    }
}

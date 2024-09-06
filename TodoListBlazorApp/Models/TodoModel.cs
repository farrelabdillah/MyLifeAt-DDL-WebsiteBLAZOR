namespace TodoListBlazorApp.Models
{
    public class TodoModel
    {
        public string TodoId { get; set; }
        public string Day { get; set; }
        public DateTime TodayDate { get; set; }
        public string Note { get; set; }
        public int DetailCount { get; set; }
        public List<TodoDetailModel> TodoDetails { get; set; } = new List<TodoDetailModel>();
    }

    public class TodoDetailModel
    {
        public string TodoDetailId { get; set; }
        public string TodoId { get; set; }
        public string Activity { get; set; }
        public string Category { get; set; }
        public string DetailNote { get; set; }
    }
}

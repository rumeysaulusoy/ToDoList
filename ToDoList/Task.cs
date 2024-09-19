namespace ToDoList {
    public class Task {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title) {
            Title = title;
            IsCompleted = false;
        }

        public override string ToString() {
            return IsCompleted ?  $"{Title} (Completed)" : Title;
        }

    }
    
    
}
namespace BlazorApp1.Models
{
    public class TodTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }  // Allow nulls when task is incomplete
        public bool IsImportant { get; set; }  // Fixed the type for IsImportant

        public void ToggleCompletion()
        {
            IsCompleted = !IsCompleted;
            if (IsCompleted)
            {
                CompletedAt = DateTime.Now;  // Set completion time
            }
            else
            {
                CompletedAt = null;  // Reset when marking incomplete
            }
        }
    }
}

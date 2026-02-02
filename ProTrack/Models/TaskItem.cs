using System;
using System.Collections.Generic;
using System.Text;

namespace ProTrack.Models
{
    public enum TaskStatus
    {
        Todo,
        InProgress,
        Completed
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public required string Title { get; set; } // 'required' ensures a task always has a name
        public string? Description { get; set; }   // '?' means the description can be empty (null)
        public TaskStatus Status { get; set; } = TaskStatus.Todo;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

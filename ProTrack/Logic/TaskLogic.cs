using ProTrack.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProTrack.Logic
{
    public class TaskLogic
    {
        // A private list to store our tasks in memory while the app is running
        private readonly List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        // Method to add a new task
        public void AddTask(string title, string? description)
        {
            var newTask = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                Status = TaskStatus.Todo
            };
            _tasks.Add(newTask);
        }

        // Method to get all tasks
        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }
    }
}

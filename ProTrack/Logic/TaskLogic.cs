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

        // To add a new task
        public void AddTask(string title, string? description)
        {
            var newTask = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                Status = TrackStatus.Todo
            };
            _tasks.Add(newTask);
        }

        // To get all tasks
        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }
    }
}

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
        //List is a dynamic array here from System.Collections.Generic
        //TaskItem yaha pe is dataType(Generic/Template) that u can only store TaskItem ke objects here
        //_tasks is reference type variable it stores the address of the list which is on heap memory
        private int _nextId = 1;

        // To add a new task
        public void AddTask(string title, string? description)
        {
            var newTask = new TaskItem
            {
                //this is Object initializer...one way to create objext and initialize without calling contructor.
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
